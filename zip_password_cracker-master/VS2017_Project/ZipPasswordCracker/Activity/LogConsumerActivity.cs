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
using System.Threading;
using System.Threading.Tasks;
using ZipPasswordCracker.Logic;
using ZipPasswordCracker.Queue;

namespace ZipPasswordCracker.Activity
{
    //
    // Log consumer activity class
    //
    class LogConsumerActivity : ITaskActivity
    {
        //
        // Members
        //
        #region Members

        // Log message queue
        private LogMessageQueue   mLogMessageQueue;
        // Log console logger
        private ConsoleLogger     mConsoleLogger;
        // Cancellation token
        private CancellationToken mCancToken;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public LogConsumerActivity(int               cThreadsNum, 
                                   LogMessageQueue   cLogMessageQueue,
                                   CancellationToken cCancToken)
        {
            // Initialize members
            mLogMessageQueue = cLogMessageQueue;
            mConsoleLogger   = new ConsoleLogger(cThreadsNum);
            mCancToken       = cCancToken;
        }

        // Run
        public async Task Run()
        {
            await Task.Run(() => this.LogMessages());
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        // Log messages
        private void LogMessages()
        {
            // Silently catch exception in case it is cancelled while taking from the queue
            try
            {
                // Continue until cancelled
                while (!mCancToken.IsCancellationRequested)
                {
                    // Get the next message ang log it to console
                    LogMessage log_msg = mLogMessageQueue.Take(mCancToken);
                    mConsoleLogger.LogMessage(log_msg);
                }
            }
            catch (OperationCanceledException)
            { }

            // Flush message queue before exiting
            FlushMessageQueue();
            // Reset cursor for printing at the right line
            mConsoleLogger.ResetCursor();
        }

        // Flush message queue
        private void FlushMessageQueue()
        {
            bool is_not_empty;

            do
            {
                LogMessage log_msg;

                is_not_empty = mLogMessageQueue.TryTake(out log_msg);
                if (is_not_empty)
                {
                    mConsoleLogger.LogMessage(log_msg);
                }
            } while (is_not_empty);
        }

        #endregion
    }
}
