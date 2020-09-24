using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MathGames
{
    public static class FullScreen
    {
        //Make Fullscreen
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        //This will set the console window to full screen
        public static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
    }
    public static class DivideScreen
    {
        //Variables for width
        public static int consoleWidth = Console.WindowWidth;
        public static int dividedWidth = consoleWidth / 2;
        public static string spaces = ' '.Repeat(dividedWidth);
    }
    //Class for Repeat Function - used for the text spaces and dividing the screen
    //Class was created to use the Repeat with spaces to center the text
    public static class CharExtensions
    {
        //Repeat method to keep adding spaces (or any char) to the set amount
        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }
    }
    public class MyName
    {
        //Opening Screen
        public static void Greet()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
                              ██╗ █████╗ ███╗   ███╗███████╗███████╗    ███████╗██╗██╗      ██████╗ ██████╗ ████████╗████████╗███████╗      
                              ██║██╔══██╗████╗ ████║██╔════╝██╔════╝    ██╔════╝██║██║     ██╔════╝██╔═══██╗╚══██╔══╝╚══██╔══╝██╔════╝      
                              ██║███████║██╔████╔██║█████╗  ███████╗    ███████╗██║██║     ██║     ██║   ██║   ██║      ██║   ███████╗      
                         ██   ██║██╔══██║██║╚██╔╝██║██╔══╝  ╚════██║    ╚════██║██║██║     ██║     ██║   ██║   ██║      ██║   ╚════██║      
                         ╚█████╔╝██║  ██║██║ ╚═╝ ██║███████╗███████║    ███████║██║███████╗╚██████╗╚██████╔╝   ██║      ██║   ███████║      
                          ╚════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝╚══════╝    ╚══════╝╚═╝╚══════╝ ╚═════╝ ╚═════╝    ╚═╝      ╚═╝   ╚══════╝      
                                                                                                                                            
                         ████████╗███████╗███████╗████████╗     ██████╗ ███████╗███╗   ██╗███████╗██████╗  █████╗ ████████╗ ██████╗ ██████╗ 
                         ╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝    ██╔════╝ ██╔════╝████╗  ██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
                            ██║   █████╗  ███████╗   ██║       ██║  ███╗█████╗  ██╔██╗ ██║█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝
                            ██║   ██╔══╝  ╚════██║   ██║       ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗
                            ██║   ███████╗███████║   ██║       ╚██████╔╝███████╗██║ ╚████║███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║
                            ╚═╝   ╚══════╝╚══════╝   ╚═╝        ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
                            
                                                                                                        █▀▄▀█ ▄▀█ ▀█▀ █░█   █▀▀ █▀▄ █ ▀█▀ █ █▀█ █▄░█
                                                                                                        █░▀░█ █▀█ ░█░ █▀█   ██▄ █▄▀ █ ░█░ █ █▄█ █░▀█
                    
");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Scoreboard.ShowScorboard();

        }
    }
    public class Game
    {
        //Static Variables declared
        public static bool gameIsActive = true;
        public static string responseOperations;
        public static string responseNumOfQuestions;
        public static string responseDifficultyLevel;
        public static GameState CurrentGameState;
        public static GameLevel CurrentLevel;
        public static int LevelNumber;
        public static double firstNumber;
        public static double secondNumber;
        public static double thirdNumber;
        public static double fourthNumber;
        public static double answerAdd;
        public static double answerSub;
        public static double answerMult;
        public static double answerDivide;
        public static string responseGuessNumber;
        public static double scoreCounterCorrect;
        public static double scoreCounterIncorrect;
        public static double overallScoreInt = 0;
        public static double answerAddTopStr;
        public static double answerAddBtmStr;
        public static double answerAddTopStrConvertedToInt;
        public static double answerAddBtmStrConvertedToInt;
        public static double answerAddTopStrConvertedToIntConvertedToDouble;
        public static double answerAddBtmStrConvertedToIntConvertedToDouble;
        public static double remainder;
        //Gamestates to change statuses
        public enum GameState
        {
            Intro,
            Addition,
            Subtraction,
            Multiplication,
            Division,
            TryAgain,
            EndGame,
            EasterEgg
        }
        //Level statuses
        public enum GameLevel
        {
            Easy,
            Normal,
            Hard
        }
        //Load method to always check statuses
        public static void Load()
        {
            while (gameIsActive)
            {
                //Gamestates
                switch (CurrentGameState)
                {
                    case GameState.Intro:
                        Introscreen();
                        break;
                    case GameState.Addition:
                        AskQuestions();
                        break;
                    case GameState.Subtraction:
                        AskQuestions();
                        break;
                    case GameState.Multiplication:
                        AskQuestions();
                        break;
                    case GameState.Division:
                        AskQuestions();
                        break;
                    case GameState.TryAgain:
                        TryAgain();
                        break;
                    case GameState.EndGame:
                        EndGame();
                        break;
                    case GameState.EasterEgg:
                        break;
                    default:
                        break;
                }
                //Level states
                switch (CurrentLevel)
                {
                    case GameLevel.Easy:
                        LevelNumber = 1;
                        break;
                    case GameLevel.Normal:
                        LevelNumber = 2;
                        break;
                    case GameLevel.Hard:
                        LevelNumber = 3;
                        break;
                }
            }
        }
        //Intro Method 
        public static void Introscreen()
        {
            MyName.Greet();
            //Check scorboard for egg
            var lookup = Scoreboard.highScores.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() >= 5);
            int countKeys = 0;
            foreach (var item in lookup)
            {
                var keys = item.Aggregate("", (s, v) => s + ", " + v);
                //var message = "The following keys have the value " + item.Key + ":" + keys;
                //Console.WriteLine(message);
                countKeys = countKeys + keys.Length;
            }
            //Check if the values (scores in the dictionary) are all 100's (which equals 15 length)
            if (countKeys >= 15)
            {
                CurrentGameState = GameState.EasterEgg;
            }
            else
            {
                CurrentGameState = GameState.Intro;
            }
            //Diffuculty Level Screen
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Welcome to James Silcott's Test Generator - The Math Edition");
            Console.WriteLine("");
            DifficultyLevels.LevelSet();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            if (Game.responseDifficultyLevel == "1")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "EASY MODE: Turned On");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Game.CurrentLevel = Game.GameLevel.Easy;
            }
            else if (Game.responseDifficultyLevel == "2")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "NORMAL MODE: Turned On");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Game.CurrentLevel = Game.GameLevel.Normal;
            }
            else if (Game.responseDifficultyLevel == "3")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "HARD MODE: Turned On");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Game.CurrentLevel = Game.GameLevel.Hard;
            }
            else
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a selection, try again");
                Game.Introscreen();
            }
            //Menu Selection for Operation Challenge
            Console.ForegroundColor = ConsoleColor.White;
            MyName.Greet();
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Welcome to James Silcott's Test Generator - The Math Edition");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            //Menu
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Select a math challenge:");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[A] Addition");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[S] Subtraction");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[M] Multiplication");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[D] Division");
            //Hidden unless player fills the scorboard (all five spots) with all 100% values or types in word "egg" for menu
            if (CurrentGameState == GameState.EasterEgg)
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[E] EASTER EGG!");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[Q] Quit");
            Console.WriteLine();
            responseOperations = Console.ReadLine().ToUpper();
            //if response does NOT equal these than do the following
                while (
                    responseOperations != "A" || 
                    responseOperations != "S" || 
                    responseOperations != "M" || 
                    responseOperations != "D" || 
                    responseOperations != "E" || 
                    responseOperations != "EGG" || 
                    responseOperations != "Q")
                {
                    //Addition Selector
                if (responseOperations == "A")
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Addition Challenge...");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                    responseNumOfQuestions = Console.ReadLine();
                    CurrentGameState = GameState.Addition;
                    break;
                }
                //Subtraction Selector
                else if (responseOperations == "S")
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Subtraction Challenge...");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                    responseNumOfQuestions = Console.ReadLine();
                    CurrentGameState = GameState.Subtraction;
                    break;
                }
                //Multi Selector
                else if (responseOperations == "M")
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Multiplication Challenge...");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                    responseNumOfQuestions = Console.ReadLine();
                    CurrentGameState = GameState.Multiplication;
                    break;
                }
                //Division Selector
                else if (responseOperations == "D")
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Division Challenge...");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                    responseNumOfQuestions = Console.ReadLine();
                    CurrentGameState = GameState.Division;
                    break;
                }
                //Quit Selector
                else if (responseOperations == "Q")
                {
                    CurrentGameState = GameState.EndGame;
                    EndGame();
                }
                //Easter Egg Selector - hidden till all five scores in scorboard show 100%
                else if (CurrentGameState == GameState.EasterEgg && responseOperations == "E")
                {
                    CurrentGameState = GameState.EasterEgg;
                    Easter.EasterEgg();
                    break;
                }
                //Easter Egg Selector - use to shortcut the easter egg
                else if (responseOperations == "EGG")
                {
                    Scoreboard.EggScores();
                    CurrentGameState = GameState.EasterEgg;
                    Console.Clear();
                    Introscreen();
                    break;
                }
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a selection, try again");
                responseOperations = Console.ReadLine().ToUpper();
            }
                //used in case a integer value
            while (!int.TryParse(responseNumOfQuestions, out int output))
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a selection, try again");
                responseNumOfQuestions = Console.ReadLine();
            }
            AskQuestions();
        }
        //Grading Scale
        public static class ScoreKeeper
        {
            public static string Grade()
            {
                //Grade A
                if (overallScoreInt <= 100 && overallScoreInt > 89)
                {
                    return "A";
                }
                //Grade B
                else if (overallScoreInt < 90 && overallScoreInt > 79)
                {
                    return "B";
                }
                //Grade C
                else if (overallScoreInt < 80 && overallScoreInt > 69)
                {
                    return "C";
                }
                //Grade D
                else if (overallScoreInt < 70 && overallScoreInt > 59)
                {
                    return "D";

                }
                //Grade F
                else if (overallScoreInt <= 59)
                {
                    return "F";
                }
                //Grade F - Catch All
                else
                {
                    return "F";
                }
            }
            //Output Scores
            public static string Tally()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Get score in percentage format
                overallScoreInt = ((scoreCounterCorrect / (scoreCounterCorrect + scoreCounterIncorrect)) * 100);
                //Change int value to string and "0" makes it into a integer value
                string overallScoreStr = overallScoreInt.ToString("0");
                return $"Your score is: {scoreCounterCorrect} out of {scoreCounterCorrect + scoreCounterIncorrect} = {overallScoreStr}%.  That's a {Grade()} letter grade";
            }
        }
        //Calculate and display numbers
        public static void Calculator()
        {
            //Random numbers assigned to variables
            firstNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            secondNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            thirdNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            fourthNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            //Depending on diffuculty level - Easy = 1 number, Normal = 2 numbers, and Hard = 3 numbers
            //Easy Mode
            if (CurrentLevel == GameLevel.Easy)
            {
                //Division Operation
                if (CurrentGameState == GameState.Division)
                {
                    //Calculate the operation
                    answerDivide = firstNumber / secondNumber;
                    //Rerun the calculator if ansewer does equal: zero, less than one, does NOT have a reaminder, has infinity value, or NaN ****NOTE: if remainder was not shown, it would show NaN****
                    if (answerDivide <= 0 || answerDivide < 1 || (answerDivide % 1 != 0) || double.IsInfinity(answerDivide) == true || double.IsNaN(answerDivide))
                    {
                        Calculator();
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FirstNumberArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{OperationSignSelection.OperationSignArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.SecondNumberArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "First, what is the number divisible by, then give me the remainder:");
                    }
                }
                //Add, Subtract, or Multiple Operations
                else
                {
                    answerSub = firstNumber - secondNumber;
                    //Ensure their are NO negative numbers for easy mode
                    if (CurrentGameState == GameState.Subtraction && answerSub < 0)
                    {
                        Calculator();
                    }
                    else if (CurrentGameState == GameState.Subtraction && answerSub >= 0)
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FirstNumberArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{OperationSignSelection.OperationSignArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.SecondNumberArt()}");
                    }
                    else
                    {
                        //Calculate the operation
                        answerAdd = firstNumber + secondNumber;
                        answerMult = firstNumber * secondNumber;
                     
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FirstNumberArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{OperationSignSelection.OperationSignArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.SecondNumberArt()}");
                    }
                }
            }
            //Normal Mode
            else if (CurrentLevel == GameLevel.Normal)
            {
                //Convert each random number into a string and concatenate to form the complete number
                //Top number
                string answerAddTopStr = firstNumber.ToString() + secondNumber.ToString();
                //Bottom Number
                string answerAddBtmStr = thirdNumber.ToString() + fourthNumber.ToString();
                //Division Operation
                if (CurrentGameState == GameState.Division)
                {
                    //Calculate the answer
                    answerDivide = double.Parse(answerAddTopStr) / double.Parse(answerAddBtmStr);
                    //Convert into double to elmininate the NaN and zero exceptions
                    answerAddTopStrConvertedToInt = double.Parse(answerAddTopStr);
                    answerAddBtmStrConvertedToInt = double.Parse(answerAddBtmStr);
                    //if ansewer does equal: zero, less than one, has a remainder, has infinity value, or NaN
                    if (answerDivide <= 0 || answerDivide < 1 || (answerDivide % 1 == 0) || double.IsInfinity(answerDivide) == true || double.IsNaN(answerDivide))
                    {
                        Calculator();
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + NumberSelection.FirstNumberArt() + "\n" + NumberSelection.SecondNumberArt().ToString());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + OperationSignSelection.OperationSignArt());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + NumberSelection.ThirdNumberArt() + "\n" + NumberSelection.FourthNumberArt().ToString());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "First, what is the number divisible by, then give me the remainder:");
                    }
                }
                //Add, Subtract, or Multiple Operations
                else
                {
                    answerSub = double.Parse(answerAddTopStr) - double.Parse(answerAddBtmStr);
                    //Ensure their are NO negative numbers for Normal mode
                    if (CurrentGameState == GameState.Subtraction && answerSub < 0)
                    {
                        Calculator();
                    }
                    else if (CurrentGameState == GameState.Subtraction && answerSub >= 0)
                    {
                        var sb1 = new StringBuilder();
                        var sb2 = new StringBuilder();
                        for (int i = 0; i < 1; i++)
                        {
                            sb1.AppendLine(NumberSelection.FirstNumberArt() + "\n" + NumberSelection.SecondNumberArt().ToString());
                            sb2.AppendLine(NumberSelection.ThirdNumberArt() + "\n" + NumberSelection.FourthNumberArt().ToString());
                        }
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + sb1.ToString() + $"{OperationSignSelection.OperationSignArt()}" + sb2.ToString());
                    }
                    else
                    {
                        var sb1 = new StringBuilder();
                        var sb2 = new StringBuilder();
                        for (int i = 0; i < 1; i++)
                        {
                            sb1.AppendLine(NumberSelection.FirstNumberArt() + "\n" + NumberSelection.SecondNumberArt().ToString());
                            sb2.AppendLine(NumberSelection.ThirdNumberArt() + "\n" + NumberSelection.FourthNumberArt().ToString());
                        }
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + sb1.ToString() + $"{OperationSignSelection.OperationSignArt()}" + sb2.ToString());
                        answerAdd = double.Parse(answerAddTopStr) + double.Parse(answerAddBtmStr);
                        answerMult = double.Parse(answerAddTopStr) * double.Parse(answerAddBtmStr);
                    }
                }
            }
            //Hard Mode
            else if (CurrentLevel == GameLevel.Hard)
            {
                string answerAddTopStr = firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString();
                string answerAddBtmStr = thirdNumber.ToString() + fourthNumber.ToString() + firstNumber.ToString();

                answerAddTopStrConvertedToInt = double.Parse(answerAddTopStr);
                answerAddBtmStrConvertedToInt = double.Parse(answerAddBtmStr);

                //Division Operation
                if (CurrentGameState == GameState.Division)
                {
                    answerDivide = answerAddTopStrConvertedToInt / answerAddBtmStrConvertedToInt;
                    if (answerDivide == 0 || answerDivide < 1 || (answerDivide % 1 == 0) || double.IsInfinity(answerDivide) == true || double.IsNaN(answerDivide))
                    {
                        Calculator();
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + NumberSelection.FirstNumberArt() + "\n" + NumberSelection.SecondNumberArt().ToString() + "\n" + NumberSelection.ThirdNumberArt());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + OperationSignSelection.OperationSignArt());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + NumberSelection.ThirdNumberArt() + "\n" + NumberSelection.FourthNumberArt().ToString() + "\n" + NumberSelection.FirstNumberArt());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "First, what is the number divisible by, then give me the remainder:");
                    }
                }
                //Add, Subtract, or Multiple Operations
                else
                {
                    //Use Stringbuilder method to join number art together
                    var sb3 = new StringBuilder();
                    var sb4 = new StringBuilder();
                    //loop thru once to combine numbers
                    for (int i = 0; i < 1; i++)
                    {
                        sb3.AppendLine(
                            NumberSelection.FirstNumberArt() +
                            "\n" +
                            NumberSelection.SecondNumberArt().ToString() +
                            "\n" +
                            NumberSelection.ThirdNumberArt().ToString());
                        sb4.AppendLine(
                            NumberSelection.ThirdNumberArt() +
                            "\n" +
                            NumberSelection.FourthNumberArt().ToString() +
                            "\n" +
                            NumberSelection.FirstNumberArt().ToString());
                    }
                    //display number art and operation sign art
                    Console.WriteLine(sb3.ToString() + $"{OperationSignSelection.OperationSignArt()}" + sb4.ToString());
                    //Calcualte the operations
                    answerAdd = double.Parse(answerAddTopStr) + double.Parse(answerAddBtmStr);
                    answerSub = double.Parse(answerAddTopStr) - double.Parse(answerAddBtmStr);
                    answerMult = double.Parse(answerAddTopStr) * double.Parse(answerAddBtmStr);
                }
            }
        }
        //Ask the user questions and respond
        public static void AskQuestions()
        {
            for (int i = 0; i < Convert.ToInt32(responseNumOfQuestions); i++)
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"Question {i + 1}:");
                //Change color every question
                ColorChanger.RandomColor();
                //Run calc to get numbers with art
                Calculator();
                //Get input for guess
                responseGuessNumber = Console.ReadLine();
                //While the guess is NOT a number keep asking
                int y;
                //Check if number is a integer
                bool success = int.TryParse(responseGuessNumber, out y);
                while (success == false)
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, didn't understand you. Try again");
                    responseGuessNumber = Console.ReadLine();
                    success = int.TryParse(responseGuessNumber, out y);
                }
                //Addition Question
                if (CurrentGameState == GameState.Addition)
                {
                    if (Convert.ToInt32(responseGuessNumber) == (answerAdd))
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                        scoreCounterCorrect = scoreCounterCorrect + 1;
                    }
                    else if (Convert.ToInt32(responseGuessNumber) != (answerAdd))
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + (answerAdd));
                        scoreCounterIncorrect = scoreCounterIncorrect + 1;
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that wasn't a correct response.  Try again.");
                        AskQuestions();
                    }
                }
                //Subtraction Question
                else if (CurrentGameState == GameState.Subtraction)
                {
                    if (Convert.ToInt32(responseGuessNumber) == (answerSub))
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                        scoreCounterCorrect = scoreCounterCorrect + 1;
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + (answerSub));
                        scoreCounterIncorrect = scoreCounterIncorrect + 1;
                    }
                }
                //Multipcation Question
                else if (CurrentGameState == GameState.Multiplication)
                {
                    if (Convert.ToInt32(responseGuessNumber) == (answerMult))
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                        scoreCounterCorrect = scoreCounterCorrect + 1;
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + (answerMult));
                        scoreCounterIncorrect = scoreCounterIncorrect + 1;
                    }
                }
                //Division Question
                else if (CurrentGameState == GameState.Division)
                {
                    //If answer is not an integer - it has a remainder
                    if (answerDivide % 1 != 0)
                    {
                        //if guess equals the answer rounded down to nearest integer
                        if (Convert.ToInt32(responseGuessNumber) == Math.Floor(answerDivide))
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "What's the remainder:");
                            //answerDivide = Math.Floor(Math.Ceiling(answerDivide) - Math.Floor(answerDivide));//used but didn't work all the way - keep for record
                            //if easy mode, which uses two numbers
                            if (LevelNumber == 1)
                            {
                                //remainder = Math.Ceiling(firstNumber) % Math.Floor(secondNumber);
                                remainder = firstNumber % secondNumber;

                            }
                            //else use the string conversion number from either Normal or Hard modes
                            else
                            {
                                remainder = answerAddTopStrConvertedToInt % answerAddBtmStrConvertedToInt;
                            }
                            //Get remainder guess input
                            string responseDiv1 = Console.ReadLine();
                            //While the guess is NOT a number keep asking
                            double z;
                            //Check if number is a double
                            bool successAgain = double.TryParse(responseDiv1, out z);
                            while (successAgain == false)
                            {
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, didn't understand you. Try again");
                                responseDiv1 = Console.ReadLine();
                                successAgain = double.TryParse(responseDiv1, out z);
                            }
                            //Convert response to double
                            double responseDiv2 = double.Parse(responseDiv1);
                            //if remainder guess is correct
                            if (responseDiv2 == remainder)
                            {
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                                //set correct counter 
                                scoreCounterCorrect = scoreCounterCorrect + 1;
                            }
                            //If remainder guess is wrong
                            else
                            {
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Floor(answerDivide));
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Remainder is:");
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Ceiling(remainder));
                                //set incorrect counter
                                scoreCounterIncorrect = scoreCounterIncorrect + 1;
                            }
                        }
                        else
                        {
                            //If the guess was wrong
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Floor(answerDivide));
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Remainder is:");
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Ceiling(remainder));
                            scoreCounterIncorrect = scoreCounterIncorrect + 1;
                        }
                    }
                    else
                    {
                        //if no remainder in answer
                        answerDivide = firstNumber / secondNumber;
                        //if guess is correct
                        if (Convert.ToInt32(responseGuessNumber) == (answerDivide))
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                            //set correct counter
                            scoreCounterCorrect = scoreCounterCorrect + 1;
                        }
                        //if guess is wrong
                        else
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + (answerDivide));
                            //set incorrect counter
                            scoreCounterIncorrect = scoreCounterIncorrect + 1;
                        }
                    }
                }
                //Catch all
                else
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was not correct.");
                    AskQuestions();
                }
                //Set condition for user to exit the for loop by using the spacebar
                if (i != Convert.ToInt32(responseNumOfQuestions) - 1)
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Press Enter to Continue or Spacebar to Exit");
                    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    {
                        i = Convert.ToInt32(responseNumOfQuestions);
                    }
                }
            }
            ColorChanger.BackColorBlack();
            //Show and calculate up scores
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + ScoreKeeper.Tally());
            overallScoreInt = ((scoreCounterCorrect / (scoreCounterCorrect + scoreCounterIncorrect)) * 100);
            Console.ForegroundColor = ConsoleColor.Green;
            //Add scores to dicitonary
            Scoreboard.AddScoresToDictionary();
            //Try again
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Do you want to play again? [Y] or [N]");
            string responsePlayAgain = Console.ReadLine().ToUpper();
            if (responsePlayAgain == "Y")
            {
                AskQuestions();
            }
            else if (responsePlayAgain == "N")
            {
                //reset score counters
                scoreCounterCorrect = 0;
                scoreCounterIncorrect = 0;
                //go back to intro screen
                Console.Clear();
                CurrentGameState = GameState.Intro;
                Introscreen();
            }
            else
            {
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a choice. Try again?"));
                TryAgain();
            }
        }
        //Endgame Method
        public static void EndGame()
        {
            Game.gameIsActive = false;
            ThankYouEnding();
        }
        //Thank You Message
        public static void ThankYouEnding()
        {
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                Have a nice day!                   "));

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + " _   _                 _                           "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| | | |               | |                          "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| |_| |__   __ _ _ __ | | ___   _  ___  _   _      "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| __| '_ \\ / _` | '_ \\| |/ / | | |/ _ \\| | | |  "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| |_| | | | (_| | | | |   <| |_| | (_) | |_| |     "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "\\___|_| |_|\\__,_|_| |_|_|\\_\\__, |\\___/ \\__,__|"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                            __/  |                 "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                           |____/                  "));
        }
        //Try again Method
        public static void TryAgain()
        {
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Would you like to play again?");
            var response = Console.ReadLine().ToUpper();

            if (response == "Y")
            {
                Console.Clear();
                Game.CurrentGameState = GameState.Intro;
            }
            else if (response == "N")
            {
                Console.Clear();
                Game.CurrentGameState = GameState.EndGame;
            }
            else
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, I didn't understand that. Try again.");
                TryAgain();
            }
        }
    }
    //Random number generator
    public static class Randomizer
    {
        //Get a random number 0 to 9
        public static int RandomNumberUnder10()
        {
            Random random = new Random();
            int newRandom = random.Next(0, 9);
            return newRandom;
        }
        //Get a random number 10 to 100
        public static int RandomNumber10to100()
        {
            Random random = new Random();
            int newRandom = random.Next(10, 100);
            return newRandom;
        }
        //Get a random number 100 to 1000
        public static int RandomNumber100to1000()
        {
            Random random = new Random();
            int newRandom = random.Next(100, 1000);
            return newRandom;
        }
        //Random Array to generate number 0 thru 10
        public static Array RandomTenNumbers()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Random randNum = new Random();
            int rand = 0;
            int temp;
            for (int x = 0; x < 10; x++)
            {
                rand = randNum.Next(0, 10 - x);
                temp = array[rand];
                array[rand] = array[9 - x];
                array[9 - x] = temp;
            }
            return array;
        }
    }
    //Difficulty Level Menu
    public static class DifficultyLevels
    {
        public static void LevelSet()
        {
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "                           Difficulty Settings");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "            Easy Mode: Single Digits, No Negatives, & No Remainders");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "          Normal Mode: Double Digits, No Negatives");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "            Hard Mode: Triple Digits");
            Console.WriteLine();
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "                         Pick a Difficulty Level");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "                                [1] Easy");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "                                [2] Normal");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 24) + "                                [3] Hard");
            Game.responseDifficultyLevel = Console.ReadLine();
        }
    }
    //Operational Sign Conditionals that assign Methods
    public static class OperationSignSelection
    {
        public static string OperationSignArt()
        {
            if (Game.CurrentGameState == Game.GameState.Addition)
            {
                return ASCII_Art.Plus();
            }
            else if (Game.CurrentGameState == Game.GameState.Subtraction)
            {
                return ASCII_Art.Minus();
            }
            else if (Game.CurrentGameState == Game.GameState.Multiplication)
            {
                return ASCII_Art.Times();
            }
            else if (Game.CurrentGameState == Game.GameState.Division)
            {
                return ASCII_Art.Divide();
            }
            else
            {
                return null;
            }
        }
    }
    //Operational Sign Conditionals that assign Methods
    public static class NumberSelection
    {
        //First Number Generated Artwork
        public static string FirstNumberArt()
        {
            if (Game.firstNumber == 0)
            {
                return ASCII_Art.Zero();
            }
            else if (Game.firstNumber == 1)
            {
                return ASCII_Art.One();
            }
            else if (Game.firstNumber == 2)
            {
                return ASCII_Art.Two();
            }
            else if (Game.firstNumber == 3)
            {
                return ASCII_Art.Three();
            }
            else if (Game.firstNumber == 4)
            {
                return ASCII_Art.Four();
            }
            else if (Game.firstNumber == 5)
            {
                return ASCII_Art.Five();
            }
            else if (Game.firstNumber == 6)
            {
                return ASCII_Art.Six();
            }
            else if (Game.firstNumber == 7)
            {
                return ASCII_Art.Seven();
            }
            else if (Game.firstNumber == 8)
            {
                return ASCII_Art.Eight();
            }
            else
            {
                return ASCII_Art.Nine();
            }
        }
        //Second Number Generated Artwork
        public static string SecondNumberArt()
        {
            if (Game.secondNumber == 0)
            {
                return ASCII_Art.Zero();
            }
            else if (Game.secondNumber == 1)
            {
                return ASCII_Art.One();
            }
            else if (Game.secondNumber == 2)
            {
                return ASCII_Art.Two();
            }
            else if (Game.secondNumber == 3)
            {
                return ASCII_Art.Three();
            }
            else if (Game.secondNumber == 4)
            {
                return ASCII_Art.Four();
            }
            else if (Game.secondNumber == 5)
            {
                return ASCII_Art.Five();
            }
            else if (Game.secondNumber == 6)
            {
                return ASCII_Art.Six();
            }
            else if (Game.secondNumber == 7)
            {
                return ASCII_Art.Seven();
            }
            else if (Game.secondNumber == 8)
            {
                return ASCII_Art.Eight();
            }
            else
            {
                return ASCII_Art.Nine();
            }
        }
        //Third Number Generated Artwork
        public static string ThirdNumberArt()
        {
            if (Game.thirdNumber == 0)
            {
                return ASCII_Art.Zero();
            }
            else if (Game.thirdNumber == 1)
            {
                return ASCII_Art.One();
            }
            else if (Game.thirdNumber == 2)
            {
                return ASCII_Art.Two();
            }
            else if (Game.thirdNumber == 3)
            {
                return ASCII_Art.Three();
            }
            else if (Game.thirdNumber == 4)
            {
                return ASCII_Art.Four();
            }
            else if (Game.thirdNumber == 5)
            {
                return ASCII_Art.Five();
            }
            else if (Game.thirdNumber == 6)
            {
                return ASCII_Art.Six();
            }
            else if (Game.thirdNumber == 7)
            {
                return ASCII_Art.Seven();
            }
            else if (Game.thirdNumber == 8)
            {
                return ASCII_Art.Eight();
            }
            else
            {
                return ASCII_Art.Nine();
            }
        }
        //Fourth Number Generated Artwork
        public static string FourthNumberArt()
        {
            if (Game.fourthNumber == 0)
            {
                return ASCII_Art.Zero();
            }
            else if (Game.fourthNumber == 1)
            {
                return ASCII_Art.One();
            }
            else if (Game.fourthNumber == 2)
            {
                return ASCII_Art.Two();
            }
            else if (Game.fourthNumber == 3)
            {
                return ASCII_Art.Three();
            }
            else if (Game.fourthNumber == 4)
            {
                return ASCII_Art.Four();
            }
            else if (Game.fourthNumber == 5)
            {
                return ASCII_Art.Five();
            }
            else if (Game.fourthNumber == 6)
            {
                return ASCII_Art.Six();
            }
            else if (Game.fourthNumber == 7)
            {
                return ASCII_Art.Seven();
            }
            else if (Game.fourthNumber == 8)
            {
                return ASCII_Art.Eight();
            }
            else
            {
                return ASCII_Art.Nine();
            }
        }
    }
    public static class ASCII_Art
    {
        //Operations Signs
        //Addition
        public static string Plus()
        {
            string plus = @"
                                                                              88     
                                                                              88     
                                                                          888ADD8888 
                                                                              88     
                                                                              88
                                                                         ";
            return plus;
        }
        //Subtraction
        public static string Minus()
        {

            string minus = @"
                                                                                     
                                                                                     
                                                                          -SUBTRACT- 
                                                                                     
                                                                                
                                                                         ";
            return minus;
        }
        //Multiplication
        public static string Times()
        {

            string times = @"
                                                                          888    888 
                                                                            88  88  
                                                                             MULT    
                                                                            88  88   
                                                                          888    888
                                                                         ";
            return times;
        }
        //Division
        public static string Divide()
        {

            string divide = @"
                                                                              88     
                                                                                     
                                                                          8888888888 
                                                                                     
                                                                              88
                                                                         ";
            return divide;
        }
        //Number Artwork
        //Zero
        public static string Zero()
        {

            string zero = @"
                                                                           ██████  
                                                                          ██  ████ 
                                                                          ██ ██ ██ 
                                                                          ████  ██ 
                                                                           ██████";
            return zero;
        }
        //One
        public static string One()
        {

            string one = @"
                                                                              ██      
                                                                             ███      
                                                                              ██      
                                                                              ██      
                                                                              ██";
            return one;
        }
        //Two
        public static string Two()
        {

            string two = @"
                                                                          ██████   
                                                                               ██  
                                                                           █████   
                                                                          ██       
                                                                          ███████";
            return two;
        }
        //Three
        public static string Three()
        {

            string three = @"
                                                                          ██████   
                                                                               ██  
                                                                           █████   
                                                                               ██  
                                                                          ██████";
            return three;
        }
        //Four
        public static string Four()
        {

            string four = @"
                                                                          ██   ██  
                                                                          ██   ██  
                                                                          ███████  
                                                                               ██  
                                                                               ██";
            return four;
        }
        //Five
        public static string Five()
        {

            string five = @"
                                                                          ███████  
                                                                          ██       
                                                                          ███████  
                                                                               ██  
                                                                          ███████";
            return five;
        }
        //Six
        public static string Six()
        {

            string six = @"
                                                                           ██████  
                                                                          ██       
                                                                          ███████  
                                                                          ██    ██ 
                                                                           ██████";
            return six;
        }
        //Seven
        public static string Seven()
        {

            string seven = @"
                                                                          ███████  
                                                                               ██  
                                                                              ██   
                                                                             ██    
                                                                             ██";
            return seven;
        }
        //Eight
        public static string Eight()
        {

            string eight = @"
                                                                           █████   
                                                                          ██   ██  
                                                                           █████   
                                                                          ██   ██  
                                                                           █████";
            return eight;
        }
        //Nine
        public static string Nine()
        {

            string nine = @"
                                                                           █████   
                                                                          ██   ██  
                                                                           ██████  
                                                                               ██  
                                                                           █████";
            return nine;
        }
    }
    //Color Changing Class
    public static class ColorChanger
    {

        //Array of methods to chagne the color methods
        public static void RandomColor()
        {
            Action[] methods = new Action[5];
            methods[0] = BackColorBlack;
            methods[1] = BackColorYellow;
            methods[2] = BackColorRed;
            methods[3] = BackColorGreen;
            methods[4] = BackColorWhite;
            //Pick a random array index
            Random randomColor = new Random();
            var randomPicker = randomColor.Next(0, 4);
            Action newPicker = methods[randomPicker];
            newPicker();
        }

        //Methods to change the background colors
        //Background Yellow
        public static void BackColorYellow()
        {
            //Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        //Background Black
        public static void BackColorBlack()
        {
            // Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Background Green
        public static void BackColorGreen()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        //Background Red
        public static void BackColorRed()
        {
            // Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        //Background White
        public static void BackColorWhite()
        {
            // Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
    //EasterEgg Class
    public static class Easter
    {
        //Egg Main Method
        public static void EasterEgg()
        {
            Console.Clear();
            ChangeColor();
            Console.WriteLine();
            Console.WriteLine();
            EggActivity();
        }
        //Loading Method
        public static void EggActivity()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Press Spacebar");

            while (Console.ReadKey(true).Key != ConsoleKey.X)
            {
                do
                {
                    Game.firstNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
                    Game.secondNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
                    Game.thirdNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
                    Game.fourthNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
                    Console.Clear();
                    ColorChanger.RandomColor();
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FirstNumberArt()}");
                    ColorChanger.RandomColor();
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.SecondNumberArt()}");
                    ColorChanger.RandomColor();
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.ThirdNumberArt()}");
                    ColorChanger.RandomColor();
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FourthNumberArt()}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Press Spacebar to Generate Random Numbers");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "            Hold X to Exit");

                    //Timer to repeat the methods
                    Thread.Sleep(80);
                } while (Console.ReadKey(true).Key == ConsoleKey.Spacebar);
            }
            Console.Clear();
            ChangeColor();
            Console.Clear();
            Game.CurrentGameState = Game.GameState.Intro;
            Scoreboard.LoadDefaults();
            Game.Introscreen();
        }
        //Egg Art
        public static void ChangeColor()
        {
            //Set counter to cycle through the while loop on the specified amount of times
            int counter = 0;
            //Do first
            do
            {
                //Increment the counter
                counter++;
                //Display Egg Art with random colors
                Console.Clear();
                ColorChanger.BackColorBlack();
                Console.Write(DivideScreen.spaces.Remove(0, 19) + " YOU'VE FOUND A\n");
                ColorChanger.BackColorBlack();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + "    ");
                ColorChanger.RandomColor();
                Console.Write(".-\" -.\n");
                ColorChanger.BackColorBlack();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + "  ");
                ColorChanger.RandomColor();
                Console.Write(".'=^=^='.\n");
                ColorChanger.BackColorBlack();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + " ");
                ColorChanger.RandomColor();
                Console.Write("/=^=^=^=^=\\\n");
                ColorChanger.BackColorBlack();
                ColorChanger.RandomColor();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + ":^= EASTER=^;\n");
                ColorChanger.BackColorBlack();
                ColorChanger.RandomColor();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + "|^   EGG   ^|\n");
                ColorChanger.BackColorBlack();
                ColorChanger.RandomColor();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + ":^=^=^=^=^=^:\n");
                ColorChanger.BackColorBlack();
                Console.Write(" ");
                ColorChanger.RandomColor();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + "\\=^=^=^=^=/\n");
                ColorChanger.BackColorBlack();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + "  ");
                ColorChanger.RandomColor();
                Console.Write("`.=^=^=.'\n");
                ColorChanger.BackColorBlack();
                Console.Write(DivideScreen.spaces.Remove(0, 18) + "    ");
                ColorChanger.RandomColor();
                Console.Write("`~~~`\n");
                ColorChanger.BackColorBlack();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                //Timer to repeat the methods
                Thread.Sleep(20);
            } while (counter < 100);//when counter reaches 100, then stop
        }
    }
    //Scoreboard Class
    public static class Scoreboard
    {
        //Dictionary to hold names and scores
        public static Dictionary<string, int> highScores = new Dictionary<string, int>();
        //Declare Variables
        public static string responseName;
        public static bool loadDefaults = true;
        public static bool addedPerson = false;
        public static bool stopAdding = false;
        //Default Keys and Values
        public static string spot1 = "CPU";
        public static string spot2 = "KZS";
        public static string spot3 = "TJS";
        public static string spot4 = "VZS";
        public static string spot5 = "JBS";

        //Default values to load at the begininig and after Easter Egg runs
        public static void LoadDefaults()
        {
            highScores.Clear();
            spot1 = "CPU";
            spot2 = "KZS";
            spot3 = "TJS";
            spot4 = "VZS";
            spot5 = "JBS";
            AddDefaultScoresToDictionary();
        }
        //Clear out dictionary names and values and input new ones for Easter Egg
        public static void EggScores()
        {
            //remove all keys from dictionary
            highScores.Clear();
            //rename variable strings
            spot1 = "YOU";
            spot2 = "FND";
            spot3 = " A ";
            spot4 = "EST";
            spot5 = "EGG";
            //load new keys and values 
            highScores.Add(spot1, 100);
            highScores.Add(spot2, 100);
            highScores.Add(spot3, 100);
            highScores.Add(spot4, 100);
            highScores.Add(spot5, 100);
        }
        //Add new names if needed to dictioanry
        public static void AddDefaultScoresToDictionary()
        {
            if (loadDefaults == true)
            {
                highScores.Add(spot1, 99);
                highScores.Add(spot2, 80);
                highScores.Add(spot3, 75);
                highScores.Add(spot4, 25);
                highScores.Add(spot5, 5);
            }
        }
        //Refresh Dictionary and keep only 5 names
        public static void AddScoresToDictionary()
        {
            //Sort Dictionary every time
            highScores = highScores.Take(5).OrderByDescending(i => i.Value).ToDictionary(i => i.Key, i => i.Value);
            //Count the number of keys in a dictionary
            var numberofelements = highScores.Count;
            //get teh last value in a dicitonary
            var min = highScores.Values.Last();
            //get the first value in the dictionary
            var max = highScores.Values.First();
            //get the key of the last value in a dictionary
            var myKeyLast = highScores.FirstOrDefault(x => x.Value == min).Key;
            //get the key of the first value in the dictionary
            var myKeyFirst = highScores.FirstOrDefault(x => x.Value == max).Key;
            //if the players score is more than the least numberin the scoreboard then add them
            if (Convert.ToInt32(Math.Floor(Game.overallScoreInt)) > min)
            {
                ScoreboardInput();
                //if the number of scores is equal or more than 5 remove and update players
                if (numberofelements >= 5)
                {
                    //If scoreboard has the same name entered again
                    if (highScores.ContainsKey(responseName))
                    {
                        highScores.Remove(responseName);
                        highScores.Add(responseName, Convert.ToInt32(Math.Floor(Game.overallScoreInt)));
                    }
                    //if last value in scorboard = name entered
                    if (myKeyLast == responseName)
                    {
                        highScores[myKeyLast] = Convert.ToInt32(Math.Floor(Game.overallScoreInt));

                    }
                    //if scorboard does NOT have name entered
                    else if (!highScores.ContainsKey(responseName))
                    {
                        highScores.Remove(myKeyLast);
                        highScores.Add(responseName, Convert.ToInt32(Math.Floor(Game.overallScoreInt)));
                    }
                    //Catch all and it removes the last name in the scoreboard
                    else
                    {
                        //If scoreboard has the same name entered again
                        if (highScores.ContainsKey(responseName))
                        {
                            highScores.Remove(responseName);
                            highScores.Add(responseName, Convert.ToInt32(Math.Floor(Game.overallScoreInt)));
                        }
                        else
                        {
                            highScores.Remove(myKeyLast);
                            highScores.Add(responseName, Convert.ToInt32(Math.Floor(Game.overallScoreInt)));
                        }
                  
                    }
                }
            }
        }
        //Display the scoreboard
        public static void ShowScorboard()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int scoreLength;
            string emptyStr = "          ";
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "███████████████████████████████████████████████████████████");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "█                    TOP 5 SCORES                         █");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "█    NAMES:                            SCORES:            █");


            //Sort dictionary - from highest value to lowest
            var items = from pair in highScores
                        orderby pair.Value descending
                        select pair;
            //Find the length of the values to reformat the scoreboard art
            foreach (KeyValuePair<string, int> pair in items)
            {
                if (pair.Value.ToString().Length == 3)
                {
                    scoreLength = 3;
                }
                else if (pair.Value.ToString().Length == 2)
                {
                    scoreLength = 2;
                }
                else if (pair.Value.ToString().Length == 1)
                {
                    scoreLength = 1;
                }
                else
                {
                    scoreLength = 0;
                }
                //Show name and scores, also remove/add spaces dependeing on above lengths
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"█" + emptyStr.Remove(0, 3) + $"{ pair.Key}" + "                               " + $"{pair.Value}%" + emptyStr.Remove(0, scoreLength) + "     █");
            }
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "███████████████████████████████████████████████████████████");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White; ;
        }
        //Ask player for top score name
        public static void ScoreboardInput()
        {
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Congrats you have a top score!");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Let's add you to the scoreboard to show your friends");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "TYPE INITIALS - 3 Letters");
            responseName = Console.ReadLine().ToUpper();
            //if response is NOT 3 char long
            while (responseName.Length > 3 || responseName.Length < 3)
            {
                if (responseName.Length > 3)
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "That's more than 3 letters, try again");
                }
                else if (responseName.Length < 3)
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "That's less than 3 letters, try again");
                }
                responseName = Console.ReadLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Reset color
            ColorChanger.BackColorBlack();
            //Fullscreen Method
            FullScreen.WideScreenMethod();
            //Load default scores to dictionary
            Scoreboard.AddDefaultScoresToDictionary();
            //Set game is active conditional
            Game.gameIsActive = true;
            //Set game state status
            Game.CurrentGameState = Game.GameState.Intro;
            //Load Method that is always checking statuses
            Game.Load();
        }
    }
}
