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
        //this is for the fullscreen mode
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
        public static int consoleWidth = Console.WindowWidth;
        public static int dividedWidth = consoleWidth / 2;
        public static string spaces = ' '.Repeat(dividedWidth);
    }
    //Class for Repeat Function - used for the text spaces and dividing the screen
    //Class was created to use the Repeat with spaces to center the text
    public static class CharExtensions
    {
        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }
    }
    public static class ThankYouMessage
    {
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
    }
    public class MyName
    {
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
        public enum GameLevel
        {
            Easy,
            Normal,
            Hard
        }
        public static void Load()
        {
            while (gameIsActive)
            {
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
        public static void Introscreen()
        {
            MyName.Greet();
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
            Console.ForegroundColor = ConsoleColor.White;
            MyName.Greet();
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Welcome to James Silcott's Test Generator - The Math Edition");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Select a math challenge:");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[A] Addition");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[S] Subtraction");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[M] Multiplication");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[D] Division");
            Console.WriteLine();
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[Q] Quit");
            Console.WriteLine();
            responseOperations = Console.ReadLine().ToUpper();
            if (responseOperations == "A")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Addition Challenge...");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                responseNumOfQuestions = Console.ReadLine();
                CurrentGameState = GameState.Addition;
            }
            else if (responseOperations == "S")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Subtraction Challenge...");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                responseNumOfQuestions = Console.ReadLine();
                CurrentGameState = GameState.Subtraction;
            }
            else if (responseOperations == "M")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Multiplication Challenge...");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                responseNumOfQuestions = Console.ReadLine();
                CurrentGameState = GameState.Multiplication;
            }
            else if (responseOperations == "D")
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"You selected {responseOperations}");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Loading Division Challenge...");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "");
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "How many questions do you want?");
                responseNumOfQuestions = Console.ReadLine();
                CurrentGameState = GameState.Division;
            }
            else if (responseOperations == "Q")
            {
                CurrentGameState = GameState.EndGame;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a selection, try again");
                Game.Introscreen();
            }
            while (!int.TryParse(responseNumOfQuestions, out int output))
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a selection, try again");
                responseNumOfQuestions = Console.ReadLine();
            }
            AskQuestions();

        }
        public static class ScoreKeeper
        {
            public static string Grade()
            {
                if (overallScoreInt <= 100 && overallScoreInt > 89)
                {
                    return "A";
                }
                else if (overallScoreInt < 90 && overallScoreInt > 79)
                {
                    return "B";
                }
                else if (overallScoreInt < 80 && overallScoreInt > 69)
                {
                    return "C";
                }
                else if (overallScoreInt < 70 && overallScoreInt > 59)
                {
                    return "D";

                }
                else if (overallScoreInt <= 59)
                {
                    return "F";
                }
                else
                {
                    return "F";
                }
            }
            public static string Tally()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                overallScoreInt = ((scoreCounterCorrect / (scoreCounterCorrect + scoreCounterIncorrect)) * 100);
                string overallScoreStr = overallScoreInt.ToString("00");
                return $"Your score is: {scoreCounterCorrect} out of {scoreCounterCorrect + scoreCounterIncorrect} = {overallScoreStr}%.  That's a {Grade()} letter grade";
            }
        }

        public static void Calculator()
        {
            firstNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            secondNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            thirdNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");
            fourthNumber = double.Parse($"{Randomizer.RandomNumberUnder10()}");

            if (CurrentLevel == GameLevel.Easy)
            {
                if (CurrentGameState == GameState.Division)
                {
                    answerDivide = firstNumber / secondNumber;
                    if (answerDivide == 0 || answerDivide < 1 || (answerDivide % 1 == 0) || double.IsInfinity(answerDivide) == true || double.IsNaN(answerDivide))
                    {
                        Calculator();
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FirstNumberArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{OperationSignSelection.OperationSignArt()}");
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.SecondNumberArt()}");
                        Console.WriteLine("First, what is the number divisible by, then give me the remainder:");
                    }
                }
                else
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.FirstNumberArt()}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{OperationSignSelection.OperationSignArt()}");
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"{NumberSelection.SecondNumberArt()}");

                    answerAdd = firstNumber + secondNumber;
                    answerSub = firstNumber - secondNumber;
                    answerMult = firstNumber * secondNumber;
                }
            }
            else if (CurrentLevel == GameLevel.Normal)
            {
                string answerAddTopStr = firstNumber.ToString() + secondNumber.ToString();
                string answerAddBtmStr = thirdNumber.ToString() + fourthNumber.ToString();

                if (CurrentGameState == GameState.Division)
                {
                    answerDivide = double.Parse(answerAddTopStr) / double.Parse(answerAddBtmStr);

                    answerAddTopStrConvertedToInt = double.Parse(answerAddTopStr);
                    answerAddBtmStrConvertedToInt = double.Parse(answerAddBtmStr);


                    if (answerDivide == 0 || answerDivide < 1 || (answerDivide % 1 == 0) || double.IsInfinity(answerDivide) == true || double.IsNaN(answerDivide))
                    {
                        Calculator();
                    }
                    else
                    {
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + NumberSelection.FirstNumberArt() + "\n" + NumberSelection.SecondNumberArt().ToString());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + OperationSignSelection.OperationSignArt());
                        Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + NumberSelection.ThirdNumberArt() + "\n" + NumberSelection.FourthNumberArt().ToString());
                        Console.WriteLine("First, what is the number divisible by, then give me the remainder:");
                    }
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
                    answerSub = double.Parse(answerAddTopStr) - double.Parse(answerAddBtmStr);
                    answerMult = double.Parse(answerAddTopStr) * double.Parse(answerAddBtmStr);
                }
            }
            else if (CurrentLevel == GameLevel.Hard)
            {
                string answerAddTopStr = firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString();
                string answerAddBtmStr = thirdNumber.ToString() + fourthNumber.ToString() + firstNumber.ToString();

                answerAddTopStrConvertedToInt = double.Parse(answerAddTopStr);
                answerAddBtmStrConvertedToInt = double.Parse(answerAddBtmStr);


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
                else
                {
                    var sb3 = new StringBuilder();
                    var sb4 = new StringBuilder();

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
                    Console.WriteLine(sb3.ToString() + $"{OperationSignSelection.OperationSignArt()}" + sb4.ToString());

                    answerAdd = double.Parse(answerAddTopStr) + double.Parse(answerAddBtmStr);
                    answerSub = double.Parse(answerAddTopStr) - double.Parse(answerAddBtmStr);
                    answerMult = double.Parse(answerAddTopStr) * double.Parse(answerAddBtmStr);
                }
            }
        }

        public static void AskQuestions()
        {
            for (int i = 0; i < Convert.ToInt32(responseNumOfQuestions); i++)
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"Question {i + 1}:");
                ColorChanger.RandomColor();
                Calculator();
                responseGuessNumber = Console.ReadLine();
                int y;
                bool success = int.TryParse(responseGuessNumber, out y);
                while (success == false)
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, didn't understand you. Try again");
                    responseGuessNumber = Console.ReadLine();
                    success = int.TryParse(responseGuessNumber, out y);
                }
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
                else if (CurrentGameState == GameState.Division)
                {
                    if (answerDivide % 1 != 0)
                    {
                        if (Convert.ToInt32(responseGuessNumber) == Math.Floor(answerDivide))
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "What's the remainder:");
                            //answerDivide = Math.Floor(Math.Ceiling(answerDivide) - Math.Floor(answerDivide));//used but didn't work all the way
                            if (LevelNumber == 1)
                            {
                                remainder = Math.Floor(Math.Ceiling(firstNumber) % Math.Floor(secondNumber));
                            }
                            else
                            {
                                remainder = answerAddTopStrConvertedToInt % answerAddBtmStrConvertedToInt;
                            }
                            double responseDiv2 = double.Parse(Console.ReadLine());
                            if (responseDiv2 == remainder)
                            {
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                                scoreCounterCorrect = scoreCounterCorrect + 1;
                            }
                            else
                            {
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Floor(answerDivide));
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Remainder is:");
                                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Ceiling(remainder));

                                scoreCounterIncorrect = scoreCounterIncorrect + 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Floor(answerDivide));
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Remainder is:");
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + Math.Ceiling(remainder));
                            scoreCounterIncorrect = scoreCounterIncorrect + 1;
                        }
                    }
                    else
                    {
                        answerDivide = firstNumber / secondNumber;
                        if (Convert.ToInt32(responseGuessNumber) == (answerDivide))
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Correct, Good Job!");
                            scoreCounterCorrect = scoreCounterCorrect + 1;
                        }
                        else
                        {
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was wrong,the correct answer is:");
                            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + (answerDivide));
                            scoreCounterIncorrect = scoreCounterIncorrect + 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry that was not correct.");
                    AskQuestions();
                }
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
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + ScoreKeeper.Tally());
            overallScoreInt = ((scoreCounterCorrect / (scoreCounterCorrect + scoreCounterIncorrect)) * 100);
            Console.ForegroundColor = ConsoleColor.Green;
            Scoreboard.AddScoresToDictionary();
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
            }
            else
            {
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Sorry, that wasn't a choice. Try again?"));
                TryAgain();
            }
        }


        public static void EndGame()
        {
            Game.gameIsActive = false;
            ThankYouEnding();
        }


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
    public static class Randomizer
    {
        public static int RandomNumberUnder10()
        {
            Random random = new Random();
            int newRandom = random.Next(0, 9);
            return newRandom;
        }
        public static int RandomNumber10to100()
        {
            Random random = new Random();
            int newRandom = random.Next(10, 100);
            return newRandom;
        }
        public static int RandomNumber100to1000()
        {
            Random random = new Random();
            int newRandom = random.Next(100, 1000);
            return newRandom;
        }
        public static Array RandomTenNumbers()
        {
            //Random Array to generate number 0 thru 10
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

    public static class DifficultyLevels
    {
        public static void LevelSet()
        {
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Pick a Difficulty Level");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[1] Easy");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[2] Normal");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "[3] Hard");
            Game.responseDifficultyLevel = Console.ReadLine();
        }
    }
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
    public static class NumberSelection
    {
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
        public static string Minus()
        {

            string minus = @"
                                                                                     
                                                                                     
                                                                          -SUBTRACT- 
                                                                                     
                                                                                
                                                                         ";
            return minus;
        }
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
        public static string Divide()
        {

            string divide = @"
                                                                              88     
                                                                                     
                                                                          8888888888 
                                                                                     
                                                                              88
                                                                         ";
            return divide;
        }
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
        public static string Three()
        {

            string three = @"
                                                                          ██████   
                                                                               ██  
                                                                           █████   
                                                                               ██  
                                                                          ██████   
                                                                                ";
            return three;
        }
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

        //Egg Art
        //public static void ChangeColor()
        //{
        //    //Set counter to cycle through the while loop on the specified amount of times
        //    int counter = 0;
        //    //Do first
        //    do
        //    {
        //        //Increment the counter
        //        counter++;

        //        Console.Clear();
        //        BackColorBlack();
        //        Console.Write(" YOU'VE FOUND A\n");
        //        BackColorBlack();
        //        Console.Write("    ");
        //        RandomColor();
        //        Console.Write(".-\" -.\n");
        //        BackColorBlack();
        //        Console.Write("  ");
        //        RandomColor();
        //        Console.Write(".'=^=^='.\n");
        //        BackColorBlack();
        //        Console.Write(" ");
        //        RandomColor();
        //        Console.Write("/=^=^=^=^=\\\n");
        //        BackColorBlack();
        //        RandomColor();
        //        Console.Write(":^= EASTER=^;\n");
        //        BackColorBlack();
        //        RandomColor();
        //        Console.Write("|^   EGG   ^|\n");
        //        BackColorBlack();
        //        RandomColor();
        //        Console.Write(":^=^=^=^=^=^:\n");
        //        BackColorBlack();
        //        Console.Write(" ");
        //        RandomColor();
        //        Console.Write("\\=^=^=^=^=/\n");
        //        BackColorBlack();
        //        Console.Write("  ");
        //        RandomColor();
        //        Console.Write("`.=^=^=.'\n");
        //        BackColorBlack();
        //        Console.Write("    ");
        //        RandomColor();
        //        Console.Write("`~~~`\n");
        //        BackColorBlack();
        //        Console.WriteLine("");
        //        Console.WriteLine("");
        //        Console.WriteLine("");

        //        //Timer to repeat the methods
        //        Thread.Sleep(20);
        //    } while (counter < 100);
        //}
    }

    public static class Scoreboard
    {
        public static Dictionary<string, int> highScores = new Dictionary<string, int>();
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
        public static bool trigger;
        public static string lowest;
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
        public static void AddScoresToDictionary()
        {
            //Sort Dictionary every time
            highScores = highScores.Take(5).OrderByDescending(i => i.Value).ToDictionary(i => i.Key, i => i.Value);

            var numberofelements = highScores.Count;
            var min = highScores.Values.Last();
            var max = highScores.Values.First();
            var myKeyLast = highScores.FirstOrDefault(x => x.Value == min).Key;
            var myKeyFirst = highScores.FirstOrDefault(x => x.Value == max).Key;
            if (Convert.ToInt32(Math.Floor(Game.overallScoreInt)) > min)
            {
                ScoreboardInput();
                if (numberofelements >= 5)
                {
                    if (highScores.ContainsKey(responseName))
                    {
                        highScores.Remove(myKeyLast);
                        highScores.Add(responseName, Convert.ToInt32(Math.Floor(Game.overallScoreInt)));
                    }
                    if (myKeyLast == responseName)
                    {
                        highScores[myKeyLast] = Convert.ToInt32(Math.Floor(Game.overallScoreInt));

                    }
                    else if (!highScores.ContainsKey(responseName))
                    {
                        highScores.Remove(myKeyLast);
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

        public static void ShowScorboard()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int scoreLength;
            string emptyStr = "          ";
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "███████████████████████████████████████████████████████████");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "█                    TOP 5 SCORES                         █");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "█    NAMES:                            SCORES:            █");


            //Sort dictionary
            var items = from pair in highScores
                        orderby pair.Value descending
                        select pair;

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

                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + $"█" + emptyStr.Remove(0, 3) + $"{ pair.Key}" + "                               " + $"{pair.Value}%" + emptyStr.Remove(0, scoreLength) +"     █");

            }
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "███████████████████████████████████████████████████████████");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White; ;

        }
        public static void ScoreboardInput()
        {
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Congrats you have a top score!");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Let's add you to the scoreboard to show your friends");
            Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "TYPE INITIALS - 3 Letters");
            responseName = Console.ReadLine().ToUpper();
            while (responseName.Length > 3)
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "That's more than 3 letters, try again");
                responseName = Console.ReadLine();
            }
            while (responseName.Length < 3)
            {
                Console.WriteLine(DivideScreen.spaces.Remove(0, 18) + "Sorry, we need 3 letters or use the spacebar, try again");
                responseName = Console.ReadLine();
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ColorChanger.BackColorBlack();
            FullScreen.WideScreenMethod();
            Scoreboard.AddDefaultScoresToDictionary();
            Game.gameIsActive = true;
            Game.CurrentGameState = Game.GameState.Intro;
            Game.Load();

        }
    }
}
