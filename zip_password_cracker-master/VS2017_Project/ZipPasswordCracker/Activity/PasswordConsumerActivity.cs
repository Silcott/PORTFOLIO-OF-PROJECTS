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
using System.IO;
using System.Threading.Tasks;
using ZipPasswordCracker.Logic;
using ZipPasswordCracker.Queue;

namespace ZipPasswordCracker.Activity
{
    // Exception in case Zip file does not exist
    class ZipFileNotExistentException : Exception
    { }

    // Exception in case Zip file is not password protected
    class ZipFileNotPasswordProtectedException : Exception
    { }

    //
    // Password consumer activity class
    //
    class PasswordConsumerActivity : ITaskActivity
    {
        //
        // Members
        //
        #region Members

        // File name
        private string                       mFileName;
        // Stop event
        private TaskCompletionSource<string> mPasswordRes;
        // Password queue
        private PasswordQueue                mPasswordQueue;
        // Password checker
        private PasswordChecker              mPasswordChecker;
        // Message log queue
        private LogMessageQueue              mLogMessageQueue;
        // Consumer index
        private int                          mIndex;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public PasswordConsumerActivity(string                       cFileName,
                                        int                          cIndex,
                                        TaskCompletionSource<string> cPasswordRes,
                                        PasswordQueue                cPasswordQueue,
                                        LogMessageQueue              cMessageLogQueue) 
        {
            // Initialize members
            mFileName           = cFileName;
            mPasswordRes        = cPasswordRes;
            mPasswordQueue      = cPasswordQueue;
            mPasswordChecker    = new PasswordChecker(cFileName);
            mLogMessageQueue    = cMessageLogQueue;
            mIndex              = cIndex;
        }

        // Run
        public async Task Run()
        {
            await Task.Run(() => this.FindPassword());
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        // Find password
        private void FindPassword()
        {
            // File must be existent
            if (!File.Exists(mFileName))
            {
                mPasswordRes.TrySetException(new ZipFileNotExistentException());
            }
            // File must be protected by password
            else if (!mPasswordChecker.IsPasswordProtected())
            {
                mPasswordRes.TrySetException(new ZipFileNotPasswordProtectedException());
            }

            // Continue until a task founds the password
            // If an exception has been set, completed will be true and the loop will not be executed
            while (!mPasswordRes.Task.IsCompleted)
            {
                // Get next password
                string curr_pwd = mPasswordQueue.Take();

                // Try to log (just discard the message if not added, there is no reason to block)
                mLogMessageQueue.TryAdd(new LogMessage(String.Format("Thread {0} - Trying password: {1}", mIndex, curr_pwd), mIndex));
                // Check password
                bool found = mPasswordChecker.TryPassword(curr_pwd);
                
                // Set password result if found
                if (found)
                {
                    mPasswordRes.SetResult(curr_pwd);
                }
            }

            // Final print
            if (!mPasswordChecker.PasswordFound)
            {
                mLogMessageQueue.Add(new LogMessage(String.Format("Thread {0} - Exiting...", mIndex), mIndex, true));
            }
            else
            {
                mLogMessageQueue.Add(new LogMessage(String.Format("Thread {0} - Found password: {1}, exiting...", mIndex, mPasswordChecker.Password), mIndex, true));
            }
        }

        #endregion
    }
}
