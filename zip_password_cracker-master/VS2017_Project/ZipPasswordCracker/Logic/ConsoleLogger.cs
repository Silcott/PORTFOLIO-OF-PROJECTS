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
using ZipPasswordCracker.Queue;

namespace ZipPasswordCracker.Logic
{
    //
    // Console logger class
    //
    class ConsoleLogger
    {
        //
        // Members
        //
        #region Members

        // Initial top cursor position
        private int mInitialCursorTop;
        // Maximum index
        private int mMaxRow;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public ConsoleLogger(int cMaxRow)
        {
            mInitialCursorTop = Console.CursorTop;
            mMaxRow           = cMaxRow;
        }

        // Reset cursor
        public void ResetCursor()
        {
            // Move console cursor after the end to avoid overlapping texts
            Console.SetCursorPosition(0, mInitialCursorTop + mMaxRow + 2);
        }
 
        // Log message
        public void LogMessage(LogMessage cLogMessage)
        {
            if ((cLogMessage.Row > 0) && (cLogMessage.Row <= mMaxRow))
            {
                int real_row = cLogMessage.Row + mInitialCursorTop;

                // Clear row if needed
                if (cLogMessage.ClearRow)
                {
                    ClearRow(real_row);
                }
                else
                {
                    Console.SetCursorPosition(0, real_row);
                }
                // Write message
                Console.Write(cLogMessage.Message);
            }
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        // Clear row
        void ClearRow(int cRow)
        {
            Console.SetCursorPosition(0, cRow);
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.SetCursorPosition(0, cRow);
        }

        #endregion
    }
}
