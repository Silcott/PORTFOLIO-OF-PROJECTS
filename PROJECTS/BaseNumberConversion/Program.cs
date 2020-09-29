using System;

namespace BaseNumberConversion
{
    public static class LoadProgram
    {
        public static string response;
        public static string responseInt;
        public static string baseName = "";
        public static void Opening()
        {
            Console.Write("Enter Q to Exit, C to Calculate, N to Convert: [N] ");
            response = Console.ReadLine().ToUpper();
            if (response == "Q")
                Environment.Exit(0);
            else if (response == "N")
                AskQuestion();
            else if (response == "C")
            {
                BaseCalculator.AskCalcQuestion();
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                Opening();
            }
        }
        public static void GetBaseNumber()
        {
            Console.WriteLine("\nExamples: Binary: 00011010  -  Octal: 32  -  Decimal: 26  -  Hex: 1A\n");
            Console.Write($"     Please enter the [{baseName}] number to convert: ");
            responseInt = Console.ReadLine();
            Console.Write($"       Number: {responseInt}, base: {response}");
        }
        public static void AskQuestion()
        {
            Console.Write("\n     Please enter the base to convert from [     2      |     8     |     10    |     16    ] ");
            Console.Write("\n                                           [   binary   |   octal   |  decimal  |    hex    ]: ");
            response = Console.ReadLine().ToUpper();
            if (response == "2" || response == "BINARY")
            {
                baseName = "binary";
                GetBaseNumber();
                BaseConversion.BinaryConversionPrintCalc();
            }
            else if (response == "8" || response == "OCTAL")
            {
                baseName = "octal";
                GetBaseNumber();
                BaseConversion.OctalConversionPrintCalc();
            }
            else if (response == "10" || response == "DECIMAL")
            {
                baseName = "decimal";
                GetBaseNumber();
                BaseConversion.DecimalConversionPrintCalc();
            }
            else if (response == "16" || response == "HEX")
            {
                baseName = "hex";
                GetBaseNumber();
                BaseConversion.HexConversionPrintCalc();
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                AskQuestion();
            }
        }
    }
    public static class BaseConversion
    {
        //2 - Binary
        public static void BinaryConversionPrintCalc()
        {
            Console.Write($"\n\n binary conversion is: {LoadProgram.responseInt}");
            Console.Write($"\n  octal conversion is: {BaseConverter.DecimalToOctal(BaseConverter.BinaryToDecimal(Convert.ToInt32(LoadProgram.responseInt)))}");
            Console.Write($"\n decimal conversion is: {BaseConverter.BinaryToDecimal(Convert.ToInt32(LoadProgram.responseInt))}");
            Console.Write($"\n    hex conversion is: ");
            BaseConverter.DecimalToHex(BaseConverter.BinaryToDecimal(Convert.ToInt32(LoadProgram.responseInt)));
            Console.WriteLine();
            Load.Start();
        }
        //8- Octal
        public static void OctalConversionPrintCalc()
        {
            Console.Write($"\n\n  binary conversion is: {BaseConverter.DecimalToBinary(BaseConverter.OctalToDecimal(Convert.ToInt32(LoadProgram.responseInt)))}");
            Console.Write($"\n decimal conversion is: {BaseConverter.OctalToDecimal(Convert.ToInt32(LoadProgram.responseInt))}");
            Console.Write($"\n  octal conversion is: {LoadProgram.responseInt}");
            Console.Write("\n     hex conversion is: ");
            BaseConverter.DecimalToHex(BaseConverter.OctalToDecimal(Convert.ToInt32(LoadProgram.responseInt)));
            Console.WriteLine();
            Load.Start();
        }
        //10 - Decimal
        public static void DecimalConversionPrintCalc()
        {
            Console.Write($"\n\n binary conversion is: {BaseConverter.DecimalToBinary(Convert.ToInt32(LoadProgram.responseInt))}");
            Console.Write($"\n   octal conversion is: {BaseConverter.DecimalToOctal(Convert.ToInt32(LoadProgram.responseInt))}");
            Console.Write($"\n decimal conversion is: {Convert.ToDecimal(Convert.ToInt32(LoadProgram.responseInt))}");
            Console.Write($"\n     hex conversion is: ");
            BaseConverter.DecimalToHex(Convert.ToInt32(LoadProgram.responseInt));
            Console.WriteLine();
            Load.Start();
        }
        //16 - Hex
        public static void HexConversionPrintCalc()
        {
            Console.Write($"\n\n binary conversion is: {BaseConverter.DecimalToBinary(Convert.ToInt32(BaseConverter.HexToDecimal(LoadProgram.responseInt.ToCharArray())))}");
            Console.Write($"\n   octal conversion is: {BaseConverter.DecimalToOctal(Convert.ToInt32(BaseConverter.HexToDecimal(LoadProgram.responseInt.ToCharArray())))}");
            Console.Write($"\n decimal conversion is: {BaseConverter.HexToDecimal(LoadProgram.responseInt.ToCharArray())}");
            Console.Write($"\n     hex conversion is: {LoadProgram.responseInt}");
            Console.WriteLine();
            Load.Start();
        }
    }
    public static class BaseConverter
    {
        public static string binaryConversion;
        public static string octalConversion;
        //Octal to Decimal
        public static int OctalToDecimal(int number)
        {
            int decimalValue = 0;
            int baseNumber = 1;
            int tempNum = number;

            while (tempNum > 0)
            {
                int last_digit = tempNum % 10;
                tempNum = tempNum / 10;

                decimalValue = decimalValue + last_digit * baseNumber;
                baseNumber = baseNumber * 8;
            }
            return decimalValue;
        }
        //Binary to Decimal
        public static int BinaryToDecimal(int number)
        {
            int decimalValue = 0;
            int baseVal = 1;
            int binVal = number;
            while (number > 0)
            {
                int tempNum = number % 10;
                decimalValue = decimalValue + tempNum * baseVal;
                number = number / 10;
                baseVal = baseVal * 2;
            }

            return decimalValue;
        }
        //Hex to Decimal
        public static int HexToDecimal(char[] number)
        {
            int len = number.Length;
            int baseNumber = 1;
            int dec_val = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    dec_val += (number[i] - 48) * baseNumber;
                    baseNumber = baseNumber * 16;
                }
                else if (number[i] >= 'A' && number[i] <= 'F')
                {
                    dec_val += (number[i] - 55) * baseNumber;
                    baseNumber = baseNumber * 16;
                }
            }
            return dec_val;
        }
        //Decimal to Binary
        public static string DecimalToBinary(int number)
        {
            binaryConversion = "";
            while (number > 1)
            {
                int remainder = number % 2;
                binaryConversion = Convert.ToString(remainder) + binaryConversion;
                number /= 2;
            }
            binaryConversion = Convert.ToString(number) + binaryConversion;
            return binaryConversion;
        }
        //Decimal to Octal
        public static string DecimalToOctal(int number)
        {
            int indexPlace = 1;
            int octalNumber = 0;
            for (int j = number; j > 0; j = j / 8)
            {
                octalNumber = octalNumber + (j % 8) * indexPlace;
                indexPlace = indexPlace * 10;
                number = number / 8;
            }
            octalConversion = Convert.ToString(octalNumber);
            return octalConversion;
        }
        //Decimal to Hex
        public static void DecimalToHex(int number)
        {
            int decimalNumber = 0;
            for (int i = number; i > 0; i = i / 16)
            {
                int tempNumber = i % 16;
                if (tempNumber < 10)
                    tempNumber = tempNumber + 48;
                else
                    tempNumber = tempNumber + 55;
                decimalNumber = decimalNumber * 100 + tempNumber;
            }
            for (int x = decimalNumber; x > 0; x = x / 100)
            {
                int characterHex = x % 100;
                Console.Write($"{(char)characterHex}");
            }
        }
    }
    //NOT part of the exercise
    public static class BaseCalculator
    {
        public static string response1;
        public static string response2;
        public static string response3;
        public static string baseName1 = "";
        public static string baseName2 = "";
        public static string number1;
        public static string number2;
        public static int number1Converted;
        public static int number2Converted;
        public static int answer;
        public static string answerString;
        public static string finalAnswer;
        public static int finalAnswerInt;

        public static void AskCalcQuestion()
        {
            Console.WriteLine("Choose the [first] base type:");
            Console.Write("\n          [     2      |     8     |     10    |     16    ] ");
            Console.Write("\n          [   binary   |   octal   |  decimal  |    hex    ]: ");
            response1 = Console.ReadLine().ToUpper();
            if (response1 == "2" || response1 == "BINARY")
            {
                baseName1 = "binary";
                Console.Write($"     Please enter the first [{baseName1}] number to convert: ");
                number1 = Console.ReadLine();
                number1Converted = BaseConverter.BinaryToDecimal(Convert.ToInt32(number1));
            }
            else if (response1 == "8" || response1 == "OCTAL")
            {
                baseName1 = "octal";
                Console.Write($"     Please enter the first [{baseName1}] number to convert: ");
                number1 = Console.ReadLine();
                number1Converted = BaseConverter.OctalToDecimal(Convert.ToInt32(number1));
            }
            else if (response1 == "10" || response1 == "DECIMAL")
            {
                baseName1 = "decimal";
                Console.Write($"     Please enter the first [{baseName1}] number to convert: ");
                number1 = Console.ReadLine();
                number1Converted = Convert.ToInt32(number1);
            }
            else if (response1 == "16" || response1 == "HEX")
            {
                baseName1 = "hex";
                Console.Write($"     Please enter the first [{baseName1}] number to convert: ");
                number1 = Console.ReadLine();
                number1Converted = BaseConverter.HexToDecimal(number1.ToCharArray());
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                AskCalcQuestion();
            }
            Console.WriteLine();
            Console.WriteLine("Choose the [second] base type:");
            Console.Write("\n          [     2      |     8     |     10    |     16    ] ");
            Console.Write("\n          [   binary   |   octal   |  decimal  |    hex    ]: ");
            response2 = Console.ReadLine().ToUpper();
            if (response2 == "2" || response2 == "BINARY")
            {
                baseName2 = "binary";
                Console.Write($"     Please enter the second [{baseName2}] number to convert: ");
                number2 = Console.ReadLine();
                number2Converted = BaseConverter.BinaryToDecimal(Convert.ToInt32(number2));

            }
            else if (response2 == "8" || response2 == "OCTAL")
            {
                baseName2 = "octal";
                Console.Write($"     Please enter the second [{baseName2}] number to convert: ");
                number2 = Console.ReadLine();
                number2Converted = BaseConverter.OctalToDecimal(Convert.ToInt32(number2));
            }
            else if (response2 == "10" || response2 == "DECIMAL")
            {
                baseName2 = "decimal";
                Console.Write($"     Please enter the second [{baseName2}] number to convert: ");
                number2 = Console.ReadLine();
                number2Converted = Convert.ToInt32(number2);
            }
            else if (response2 == "16" || response2 == "HEX")
            {
                baseName2 = "hex";
                Console.Write($"     Please enter the second [{baseName2}] number to convert: ");
                number2 = Console.ReadLine();
                number2Converted = BaseConverter.HexToDecimal(number2.ToCharArray());
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                AskCalcQuestion();
            }
            Console.WriteLine();
            Console.WriteLine($"    Ok, we have, " +
                              $"\n    first number is a {baseName1} with a value of {number1}" +
                              $"\n    second number is a {baseName2} with a value of {number2}");
            Console.WriteLine("");
            Console.WriteLine("[A] Addition");
            Console.WriteLine("[S] Subtraction");
            Console.WriteLine("[M] Multiplication");
            Console.WriteLine("[D] Division");
            Console.Write("Choose an operator:");
            response3 = Console.ReadLine().ToUpper();
            if (response3 == "A")
            {
                AddCalc();
            }
            else if (response3 == "S")
            {
                SubCalc();
            }
            else if (response3 == "M")
            {
                MultCalc();
            }
            else if (response3 == "D")
            {
                DivCalc();
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                AskCalcQuestion();
            }
        }
        public static void PrintCalculations()
        {
            if (response1 == "2" || response2 == "BINARY")
            {
                finalAnswer = BaseConverter.DecimalToBinary(answer);
                    Console.WriteLine($"Answer in decimal is: {answer}");
                Console.WriteLine($"Answer in binary is: {finalAnswer}");
                if (response2 == "2" || response2 == "BINARY")
                {
                    finalAnswer = BaseConverter.DecimalToBinary(answer);
                    Console.WriteLine($"Answer in binary is: {finalAnswer}");
                }
                else if (response2 == "8" || response2 == "OCTAL")
                {
                    finalAnswer = BaseConverter.DecimalToOctal(answer);
                    Console.WriteLine($"Answer in octal is: {finalAnswer}");
                }
                else if (response2 == "10" || response2 == "DECIMAL")
                {
                    Console.WriteLine($"Answer in decimal is: {answer}");
                }
                else if (response2 == "16" || response2 == "HEX")
                {
                    Console.Write($"Answer in hex is: ");
                    BaseConverter.DecimalToHex(answer);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                    AskCalcQuestion();
                }
            }
            else if (response1 == "8" || response1 == "OCTAL")
            {
                finalAnswer = BaseConverter.DecimalToOctal(answer);
                    Console.WriteLine($"Answer in decimal is: {answer}");
                Console.WriteLine($"Answer in octal is: {finalAnswer}");

                if (response2 == "2" || response2 == "BINARY")
                {
                    finalAnswer = BaseConverter.DecimalToBinary(answer);
                    Console.WriteLine($"Answer in binary is: {finalAnswer}");
                }
                else if (response2 == "8" || response2 == "OCTAL")
                {
                    finalAnswer = BaseConverter.DecimalToOctal(answer);
                    Console.WriteLine($"Answer in octal is: {finalAnswer}");
                }
                else if (response2 == "10" || response2 == "DECIMAL")
                {
                    Console.WriteLine($"Answer in decimal is: {answer}");
                }
                else if (response2 == "16" || response2 == "HEX")
                {
                    Console.Write($"Answer in hex is: ");
                    BaseConverter.DecimalToHex(answer);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                    AskCalcQuestion();
                }
            }
            else if (response1 == "10" || response1 == "DECIMAL")
            {
                Console.WriteLine($"Answer in decimal is: {answer}");

                if (response2 == "2" || response2 == "BINARY")
                {
                    finalAnswer = BaseConverter.DecimalToBinary(answer);
                    Console.WriteLine($"Answer in binary is: {finalAnswer}");
                }
                else if (response2 == "8" || response2 == "OCTAL")
                {
                    finalAnswer = BaseConverter.DecimalToOctal(answer);
                    Console.WriteLine($"Answer in octal is: {finalAnswer}");
                }
                else if (response2 == "10" || response2 == "DECIMAL")
                {
                    Console.WriteLine($"Answer in decimal is: {answer}");
                }
                else if (response2 == "16" || response2 == "HEX")
                {
                    Console.Write($"Answer in hex is: ");
                    BaseConverter.DecimalToHex(answer);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                    AskCalcQuestion();
                }
                finalAnswer = answer.ToString();
            }
            else if (response1 == "16" || response1 == "HEX")
            {
                    Console.WriteLine($"Answer in decimal is: {answer}");
                Console.Write($"Answer in hex is: ");
                BaseConverter.DecimalToHex(answer);
                Console.WriteLine();

                if (response2 == "2" || response2 == "BINARY")
                {
                    finalAnswer = BaseConverter.DecimalToBinary(answer);
                    Console.WriteLine($"Answer in binary is: {finalAnswer}");
                }
                else if (response2 == "8" || response2 == "OCTAL")
                {
                    finalAnswer = BaseConverter.DecimalToOctal(answer);
                    Console.WriteLine($"Answer in octal is: {finalAnswer}");
                }
                else if (response2 == "10" || response2 == "DECIMAL")
                {
                    Console.WriteLine($"Answer in decimal is: {answer}");
                }
                else if (response2 == "16" || response2 == "HEX")
                {
                    Console.Write($"Answer in hex is: ");
                    BaseConverter.DecimalToHex(answer);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                    AskCalcQuestion();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't a correct choice, try again.");
                AskCalcQuestion();
            }
        }
        public static void AddCalc()
        {
            answer = number1Converted + number2Converted;
            answerString = answer.ToString();
            PrintCalculations();
            Load.Start();
        }

        public static void SubCalc()
        {
            answer = number1Converted - number2Converted;
            answerString = answer.ToString();
            PrintCalculations();
            Load.Start();
        }

        public static void MultCalc()
        {
            answer = number1Converted * number2Converted;
            answerString = answer.ToString();
            PrintCalculations();
            Load.Start();
        }
        public static void DivCalc()
        {
            answer = number1Converted / number2Converted;
            answerString = answer.ToString();
            PrintCalculations();
            Load.Start();
        }
    }
    public class Load
    {
        public static void Start()
        {
            LoadProgram.Opening();
        }
    }
    class Program : Load
    {
        public Program()
        {
            Load.Start();
        }
        static void Main(string[] args)
        {
            Program load = new Program();
        }
    }
}



//Programming Exercise 10
//Base Number Conversion
//C# Step by Step
//Three number systems common in computing are binary (base 2), octal(base 8), and decimal(base 10).
//We commonly use the base 10 number system in everyday life. The legal digits are [0, 1, 2, 3, 4, 5, 6, 7, 8,
//9], and the places are ones, tens, hundreds, thousands, etc. This is equivalent to 10n, where n is the place,
//i.e. 100 = 1, 101 = 10, 102 = 100, etc. Machine code is commonly represented in base 2. The legal digits are
//[0, 1], and the places are ones, twos, fours, eights, etc. This is equivalent to 10n, where n is the place, i.e.
//2
//0 = 1, 2
//1 = 2, 2
//2 = 4, etc. Base 8 number systems are commonly used for operation system utilities and
//configuration files, and base 8 is not generally familiar to the public. The legal digits are [0, 1, 2, 3, 4, 5, 6,
//7], and the places are ones, 64ths, 512ths, 4096ths, etc. This is equivalent to 8n, where n is the place, i.e.
//8
//0 = 1, 8
//1 = 8, 102 = 64, etc.
//This exercise consists of writing functions to convert a number between bases. Write six functions as
//described below. Do not use any built-in library or third party library! You are required to
//hand build all of these functions. Note that I have placed all of my functions in a Util class; this is a
//result of my own disfunctionality — you do not have to do this.
//1. binary → octal
//2. binary → decimal
//3. binary → hex
//4. octal → binary
//5. octal → decimal
//6. octal → hex
//7. decimal → binary
//8. decimal → octal
//9. decimal → hex
//10. hex → binary
//11. hex → octal
//12. hex → decimal
//Use the code below as a skeleton. I have written the function headers. Your task is to write correct
//implementations. Here are some equivalents: decimal 15 = octal 17 = binary 1111; decimal 42 = octal 52
//= binary 101010; decimal 99 = octal 143 = binary 1100011.
//This code is extremely easy to write. The only math operators you need are addition, multiplication,
//integer division, and modular division. The challenge is thinking how to solve the problems! Spend two days
//figuring out how to do the conversion. This takes absolutely no programming knowledge whatsoever. Then,
//spend an hour or two writing the code