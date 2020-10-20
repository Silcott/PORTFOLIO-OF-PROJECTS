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
    // Password producer activity class
    //
    class PasswordProducerActivity : ITaskActivity
    {
        //
        // Members
        //
        #region Members

        // Password queue
        private PasswordQueue     mPasswordQueue;
        // Password generator
        private PasswordGenerator mPasswordGenerator;
        // Cancellation token
        private CancellationToken mCancToken;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public PasswordProducerActivity(string            cInitialPassword,
                                        PasswordQueue     cPasswordQueue,
                                        CancellationToken cCancToken)
        {
            // Initialize members
            mPasswordQueue     = cPasswordQueue;
            mPasswordGenerator = new PasswordGenerator(cInitialPassword);
            mCancToken         = cCancToken;
        }

        // Run
        public async Task Run()
        {
            await Task.Run(() => this.GeneratePassword());
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods
        
        // Generate password
        private void GeneratePassword()
        {
            // Silently catch exception in case it is cancelled while adding to the queue
            try
            {
                // Continue until cancelled
                while (!mCancToken.IsCancellationRequested)
                {
                    // Generate a new password and enqueue it
                    string next_pwd = mPasswordGenerator.NextPassword();
                    mPasswordQueue.Add(next_pwd, mCancToken);
                }
            }
            catch (OperationCanceledException)
            { }
        }

        #endregion
    }
}
