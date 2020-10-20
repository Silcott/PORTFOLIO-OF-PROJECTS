/*
 * Copyright (c) 2020 Emanuele Bellocchia
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using ZipPasswordCracker.Activity;
using ZipPasswordCracker.Queue;

namespace ZipPasswordCracker
{
    // Exception in case zip file is not valid
    class InvalidZipFileException : Exception
    {
        // Constructor
        public InvalidZipFileException(string cMessage) :
            base(cMessage)
        { }
    }

    // Exception in case log file is not valid
    class InvalidLogFileException : Exception
    {
        // Constructor
        public InvalidLogFileException(string cMessage, Exception cInnerEx) :
            base(cMessage, cInnerEx)
        { }
    }

    //
    // Password brute force cracker class
    // 
    class PasswordBruteForceCracker
    {
        //
        // Members
        //
        #region Members

        // File name
        private string mFileName;
        // Log file
        private string mLogFile;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public PasswordBruteForceCracker(string cFileName,
                                         string cLogFile)
        {
            mFileName = cFileName;
            mLogFile = cLogFile;
        }

        // Crack password
        public void CrackPassword(int cThreadsNum,
                                  string cInitialPassword)
        {
            // Check thread number
            if (cThreadsNum <= 0)
            {
                throw new ArgumentException(String.Format("Invalid threads number ({0}), please insert a value between 1 and {1}.", cThreadsNum, Constants.THREADS_MAX_NUM));
            }
            else if (cThreadsNum > Constants.THREADS_MAX_NUM)
            {
                throw new ArgumentException(String.Format("Too many threads requested ({0}), the maximum number is {1}.", cThreadsNum, Constants.THREADS_MAX_NUM));
            }

            // Print header
            PrintHeader(cThreadsNum);
            // Do the job
            DoCrackPassword(cThreadsNum, cInitialPassword);
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        // Crack password
        private void DoCrackPassword(int cThreadsNum,
                                    string cInitialPassword)
        {
            // Create cancellation token
            using (CancellationTokenSource token_src = new CancellationTokenSource())
            {
                // Create task list
                List<Task> task_list = new List<Task>();

                // Create queues
                var log_msg_queue = new LogMessageQueue();
                var password_queue = new PasswordQueue();

                // Create and add password producer
                var pwd_producer = new PasswordProducerActivity(cInitialPassword, password_queue, token_src.Token);
                task_list.Add(pwd_producer.Run());

                // Create and add log consumer
                var log_consumer = new LogConsumerActivity(cThreadsNum, log_msg_queue, token_src.Token);
                task_list.Add(log_consumer.Run());

                // Start stopwatch
                Stopwatch stop_watch = new Stopwatch();
                stop_watch.Start();

                // Create and add password consumers 
                TaskCompletionSource<string> password_src = new TaskCompletionSource<string>();
                for (int i = 1; i <= cThreadsNum; i++)
                {
                    var pwd_consumer = new PasswordConsumerActivity(mFileName, i, password_src, password_queue, log_msg_queue);
                    task_list.Add(pwd_consumer.Run());
                }

                try
                {
                    // Wait for password to be found
                    Task<string> password_res = password_src.Task;
                    password_res.Wait();
                    // Log password
                    LogPassword(password_res.Result);
                }
                catch (Exception ex)
                {
                    // Re-throw exception if cannot be handled
                    if (!HandleException(ex))
                    {
                        throw;
                    }
                }
                finally
                {
                    // Stop stopwatch
                    stop_watch.Stop();
                    // Cancel the other tasks (log consumer and password producer)
                    token_src.Cancel();
                    // Wait for all to finish
                    Task.WaitAll(task_list.ToArray());
                    // Print elapsed time
                    Console.WriteLine(String.Format("Elapsed time: {0}", stop_watch.Elapsed));
                }
            }
        }

        // Print header
        private void PrintHeader(int cThreadsNum)
        {
            // Start from a clean console
            Console.Clear();
            // Print header
            Console.WriteLine(String.Format("Threads number: {0}", cThreadsNum));
            Console.WriteLine(String.Format("Log file: '{0}'", mLogFile));
            Console.WriteLine(String.Format("Cracking file '{0}'...", mFileName));
        }

        // Log password
        private void LogPassword(string cPassword)
        {
            // Write the found password to file
            File.WriteAllText(mLogFile, String.Format("Password found: {0}\n", cPassword));
        }

        // Handle exception
        private bool HandleException(Exception cEx)
        {
            bool handled = true;

            // Exception thrown by password consumers
            if (cEx is AggregateException)
            {
                if (cEx.InnerException is ZipFileNotExistentException)
                {
                    throw new InvalidZipFileException("The specified zip file is not existent.");
                }
                else if (cEx.InnerException is ZipFileNotPasswordProtectedException)
                {
                    throw new InvalidZipFileException("The specified zip file is not protected by password.");
                }
            }
            // Some problems with log file (e.g. path not existent)
            else if ((cEx is DirectoryNotFoundException) ||
                     (cEx is PathTooLongException) ||
                     (cEx is UnauthorizedAccessException) ||
                     (cEx is IOException))
            {
                throw new InvalidLogFileException(cEx.Message, cEx);
            }
            // Unexpected exception
            else
            {
                handled = false;
            }

            return handled;
        }

        #endregion
    }
}
