﻿/*
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

namespace ZipPasswordCracker.Queue
{
    //
    // Log message
    //
    class LogMessage
    {
        //
        // Members
        //
        #region Members

        // Row where message shall be printed
        private int    mRow;
        // Message
        private string mMessage;
        // Clear row flag
        private bool   mClearRow;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public LogMessage(string cMessage, 
                          int    cRow, 
                          bool   cClearRow = false)
        {
            mRow      = cRow;
            mMessage  = cMessage;
            mClearRow = cClearRow;
        }

        #endregion

        //
        // Properties
        //
        #region Properties
            
        // Row property
        public int Row
        {
            get { return mRow; }
        }

        // Message property
        public string Message
        {
            get { return mMessage; }
        }

        // Clear row property
        public bool ClearRow
        {
            get { return mClearRow; }
        }

        #endregion
    }
}
