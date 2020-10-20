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
using Ionic.Zip;

namespace ZipPasswordCracker.Logic
{
    //
    // Password checker
    //
    class PasswordChecker
    {
        //
        // Members
        //
        #region Members

        // File name
        private string mFileName;
        // Found password
        private string mFoundPassword;

        #endregion

        //
        // Public methods
        //
        #region Public methods
        
        // Constructor
        public PasswordChecker(string cFileName)
        {
            mFileName      = cFileName;
            mFoundPassword = String.Empty;
        }

        // Get if the zip file is protected by password
        public bool IsPasswordProtected()
        {
            // If not protected, an empty password will return true
            return !ZipFile.CheckZipPassword(mFileName, "");
        }

        // Try the specified password on zip file
        public bool TryPassword(string cPassword)
        {
            bool success = false;

            try
            {
                // Try if password works
                success = ZipFile.CheckZipPassword(mFileName, cPassword);
                if (success)
                {
                    mFoundPassword = cPassword;
                }
            }
            catch { }

            return success;
        }

        #endregion

        //
        // Properties
        //
        #region Properties

        // Get found password
        public string Password
        {
            get { return mFoundPassword; }
        }

        // Get if password is found
        public bool PasswordFound
        {
            get { return (mFoundPassword != String.Empty); }
        }

        #endregion
    }
}
