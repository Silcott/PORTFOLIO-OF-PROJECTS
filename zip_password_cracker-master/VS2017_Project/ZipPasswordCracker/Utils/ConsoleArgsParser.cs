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
using System.Collections.Generic;

namespace ZipPasswordCracker.Utils
{
    //
    // Console arguments parser class
    //
    class ConsoleArgsParser 
    {
        //
        // Types
        //
        #region Types

        // Argument validator delegate
        private delegate bool ArgValidator(string cArg);

        #endregion

        //
        // Constants
        //
        #region Constants

        // File name parameter
        private const string FILE_NAME_PRM   = "-f";
        // Initial password parameter
        private const string INIT_PWD_PRM    = "-i";
        // Log file parameter
        private const string LOG_FILE_PRM    = "-l";
        // Threads number parameter
        private const string THREADS_NUM_PRM = "-n";
 
        // Arguments configuration
        private static readonly Dictionary<string, ArgValidator> ARGS_CONFIG = 
            new Dictionary<string, ArgValidator>
            {
                { FILE_NAME_PRM  , (string cArg) => { return (cArg != String.Empty); } },
                { INIT_PWD_PRM   , (string cArg) => { return true; } },
                { LOG_FILE_PRM   , (string cArg) => { return (cArg != String.Empty); } },
                { THREADS_NUM_PRM, (string cArg) => { int val; return (int.TryParse(cArg, out val) && (val > 0)); } },
            };

        #endregion

        //
        // Members
        //
        #region Members

        // Arguments dictionary
        private Dictionary<string, string> mArgs;

        #endregion

        //
        // Public methods
        //
        #region Public methods

        // Constructor
        public ConsoleArgsParser()
        {
            mArgs = new Dictionary<string, string>();
            // Initialize arguments with empty values
            foreach (var arg in ARGS_CONFIG)
            {
                mArgs[arg.Key] = "";
            }
        }

        // Get if valid
        public bool IsValid()
        { 
            bool is_valid = false;

            // Check if each argument is valid using the validator function
            foreach (var arg in mArgs)
            {
                is_valid = IsArgValid(arg.Key);

                if (!is_valid)
                {
                    break;
                }
            }

            return is_valid;
        }

        // Get file name
        public string GetFileName()
        {
            return (IsArgValid(FILE_NAME_PRM) ? mArgs[FILE_NAME_PRM] : String.Empty);
        }

        // Get file name
        public string GetInitialPassword()
        {
            return (IsArgValid(INIT_PWD_PRM) ? mArgs[INIT_PWD_PRM] : String.Empty);
        }

        // Get log file name
        public string GetLogFileName()
        {
            return (IsArgValid(LOG_FILE_PRM) ? mArgs[LOG_FILE_PRM] : String.Empty);
        }

        // Get threads number
        public int GetThreadsNum()
        {
            return (IsArgValid(THREADS_NUM_PRM) ? int.Parse(mArgs[THREADS_NUM_PRM]) : 1);
        }

        // Parse arguments
        public bool Parse(string[] cArgs)
        {
            string last_arg = String.Empty;

            foreach (string arg in cArgs)
            {
                if (ARGS_CONFIG.ContainsKey(arg.ToLower()))
                {
                    last_arg = arg;
                }
                else
                {
                    mArgs[last_arg] = arg;
                }
            }

            return IsValid();
        }

        #endregion


        //
        // Private methods
        //
        #region Private methods

        // Get if argument is valid
        private bool IsArgValid(string cArg)
        {
            return (mArgs.ContainsKey(cArg) ? ARGS_CONFIG[cArg](mArgs[cArg]) : false);
        }

        #endregion
    }
}
