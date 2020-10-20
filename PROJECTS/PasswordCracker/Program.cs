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

namespace ZipPasswordCracker
{
    //
    // Program
    //
    class Program
    {
        //
        // Main function
        //
        static void Main(string[] args)
        {
            // Parse arguments
            var arg_parser = new Utils.ConsoleArgsParser();

            if (arg_parser.Parse(args))
            {
                try
                {
                    // Create password cracker
                    var pwd_cracker = new PasswordBruteForceCracker(arg_parser.GetFileName(), arg_parser.GetLogFileName());
                    // Crack password
                    pwd_cracker.CrackPassword(arg_parser.GetThreadsNum(), arg_parser.GetInitialPassword());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(String.Format("Error - {0}", ex.Message));
                }
                catch (InvalidZipFileException ex)
                {
                    Console.WriteLine(String.Format("Error - Invalid zip file. Description: {0}", ex.Message));
                }
                catch (InvalidLogFileException ex)
                {
                    Console.WriteLine(String.Format("Error - Unable to save password to file. Description: {0}", ex.Message));
                }
            }
            else
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("  ZipPasswordCracker.exe -f <ZIP_FILE_PATH> -l <LOG_FILE_PATH> [-n <THREADS_NUM> -i <INITIAL_PASSWORD>]");
                Console.WriteLine("Arguments description:");
                Console.WriteLine("  -f : zip file name");
                Console.WriteLine("  -i : initial password (empty if not specified)");
                Console.WriteLine("  -l : log file name (log.txt if not specified)");
                Console.WriteLine("  -n : number of threads (1 if not specified)");
            }

            // Pause console
            Console.WriteLine("\nProgram terminated, press a key to continue...");
            Console.ReadKey();
        }
    }
}