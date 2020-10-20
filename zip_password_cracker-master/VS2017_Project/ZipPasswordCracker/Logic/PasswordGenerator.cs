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

using System.Text;

namespace ZipPasswordCracker.Logic
{
    //
    // Password generator class
    // 
    class PasswordGenerator
    {
        //
        // Constants
        //
        #region Constants
        
        // First character
        private const char FIRST_CHARACTER = ' ';
        // Last character
        private const char LAST_CHARACTER  = '~';

        #endregion

        //
        // Members
        //
        #region Members
        
        // Password builder
        private StringBuilder mPasswordBuilder;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public PasswordGenerator(string cInitialPassword = "")
        {
            mPasswordBuilder = new StringBuilder(cInitialPassword);
        }

        // Get next password
        public string NextPassword()
        {
            string curr_pwd = mPasswordBuilder.ToString();
            GenerateNextPassword();

            return curr_pwd;
        }

        #endregion

        //
        // Private methods
        //
        #region Private methods

        // Generate next password
        private void GenerateNextPassword()
        {
            // Append character if empty
            if (mPasswordBuilder.Length == 0)
            {
                AppendNewCharacter();
            }
            else
            {
                int i = 0;
                bool stop = false;

                while (!stop)
                {
                    // Get next character
                    mPasswordBuilder[i] = NextCharacter(mPasswordBuilder[i]);

                    // If it overflowed to first character, move to the next character
                    if (IsFirstCharacter(mPasswordBuilder[i]))
                    {
                        i++;
                        // If the end of the string is reached, append a new one character
                        if (i == mPasswordBuilder.Length)
                        {
                            AppendNewCharacter();
                            stop = true;
                        }
                    }
                    // Otherwise the password is ok
                    else
                    {
                        stop = true;
                    }
                }
            }
        }

        // Append new character
        private void AppendNewCharacter()
        {
            mPasswordBuilder.Append(FIRST_CHARACTER);
        }

        // Get the next of the given character
        private char NextCharacter(char cChar)
        {
            char next_char;

            if (IsLastCharacter(cChar))
            {
                next_char = FIRST_CHARACTER;
            }
            else
            {
                next_char = ++cChar;
            }

            return next_char;
        }

        // Get if first character
        private bool IsFirstCharacter(char cChar)
        {
            return (cChar <= FIRST_CHARACTER);
        }

        // Get if last character
        private bool IsLastCharacter(char cChar)
        {
            return (cChar >= LAST_CHARACTER);
        }

        #endregion
    }
}
