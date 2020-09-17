using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace MasterClasses
{
    public static class Shorts
    {
        //This will allow me to pass a string into the method without calling the Writline method
        public static void Write(string str)
        {
            Console.Write(str);
        }
        //This will add blank spaces cutting my time and code down
        public static void AddSpace(int num)
        {
            do
            {
                Console.WriteLine();
                num--;
            } while (num > 0);

        }
        //This takes the users text they type and assigns it and return its value so i can call upon it later
        public static string ConsoleInput()
        {
            string conInput = Console.ReadLine();
            return conInput;
        }
    }
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
    public static class ASCII_Art
    {
        //Text Color White
        public static void TextColorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Text Color Red
        public static void TextColorRed()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        //Text Color Black
        public static void TextColorBlack()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }

        //Background Black
        public static void BackColorBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        //Background Green
        public static void BackColorGreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }

        //Background Red
        public static void BackColorRed()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        public static void RouletteTableArt()
        {
            //line 0
            BackColorBlack();
            BackColorGreen();
            Console.Write("  ____________________________________________________________________________________________________________________\n");
            //line 1
            Console.Write(" /       |");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|           |\n");
            //line 2
            Console.Write(" /       |");
            BackColorRed();
            Console.Write("   3   ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   6   ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   9   ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   12  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   15  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   18  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   21  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   24  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   27  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   30  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   33  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   36  ");
            BackColorGreen();
            Console.Write("| Column 1  |\n");
            //line 3
            Console.Write(" /   00  |");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|___________|\n");
            //line 4
            Console.Write(" /       |");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|           |\n");
            //line 5
            Console.Write(" /_______|");
            BackColorBlack();
            Console.Write("   2   ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   5   ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   8   ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   11  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   14  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   17  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   20  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   23  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   26  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   29  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   32  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   35  ");
            BackColorGreen();
            Console.Write("| Column 2  |\n");
            //line 6
            Console.Write(" \\       |");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|___________|\n");
            //line 7
            Console.Write(" \\       |");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("       ");
            BackColorGreen();
            Console.Write("|           |\n");
            //line 8
            Console.Write(" \\   0   |");
            BackColorRed();
            Console.Write("   1   ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   4   ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   7   ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   10  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   13  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   16  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   19  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   22  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   25  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   28  ");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("   31  ");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("   34  ");
            BackColorGreen();
            Console.Write("| Column 3  |\n");
            //line 9
            Console.Write(" \\       |");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorBlack();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|");
            BackColorRed();
            Console.Write("_______");
            BackColorGreen();
            Console.Write("|___________|\n");
            BackColorBlack();
            //line 10
            BackColorGreen();
            Console.Write(" \\_______|                               |                               |                               |\n");
            BackColorBlack();
            Console.Write("         ");
            BackColorGreen();
            Console.Write("|          DOZEN 1-12           |         DOZEN 13-24           |         DOZEN 25-36           |\n");
            BackColorBlack();
            Console.Write("         ");
            BackColorGreen();
            Console.Write("|_______________________________|_______________________________|_______________________________|\n");
            BackColorBlack();
            Console.Write("         ");
            BackColorGreen();
            Console.Write("|               |               |               |               |               |               |\n");
            BackColorBlack();
            Console.Write("         ");
            BackColorGreen();
            Console.Write("|      1-18     |     EVEN      |");
            TextColorRed();
            Console.Write("      RED      ");
            TextColorWhite();
            Console.Write("|");
            TextColorBlack();
            Console.Write("     BLACK     ");
            TextColorWhite();
            Console.Write("|      ODD      |     19-36     |\n");
            BackColorBlack();
            Console.Write("         ");
            BackColorGreen();
            Console.Write("|_______________|_______________|_______________|_______________|_______________|_______________|\n");
            BackColorBlack();
        }
    }
    public static class TryAgainMessage
    {
        public static string tryAgainResponse = "Y";
        //Try again method to play again or game over
        public static bool TryAgain()
        {
            Console.WriteLine("Play Again? [Y] or [N]");
            var response = Console.ReadLine().ToUpper();
            if (response == "N")
            {
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
    }
    public static class Account
    {
        //Set the variable money to an integer
        public static int currentMoney = 10;
        //This method shows the current account balance from the varaiable money in Account Class
        public static void Bank()
        {
            Shorts.Write($"Current Account Balance: ${currentMoney}.00\n");
        }
        public static int CheckMoneyStatus()
        {
            return currentMoney;
        }
        //This method will add the current account money and the amount that was bet
        public static void Add(int bet)
        {
            currentMoney = currentMoney + bet;
        }
        public static void Subtract(ref int wage)
        {
            if ((currentMoney - wage) < 0)
            {
                wage = currentMoney;
                Shorts.AddSpace(1);
                Shorts.Write($"Sorry, but according to our bank you don't have enough to make that bet.  Your account shows: $" + wage + ".00\n");
            }
            else
            {
                currentMoney = currentMoney - wage;
            }
        }
    }
    public static class GameOverConditions
    {
        public static bool DetermineIfGameOver()
        {
            //If money is zero or less retrun true
            if (Account.currentMoney <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool GameOver()
        {
            Console.WriteLine("GAME OVER - Thanks for playing");
            return Game.rouletteConditional = false;

        }
    }
    public static class Game
    {
        public static bool rouletteConditional = true;
        public static int currentBankAmount = Account.CheckMoneyStatus();
        public static int amountWaged;
        public static int ballNumber = 0;
        public static void AddMoney(ref int money)
        {
            if (money > 0)
            {
                Account.currentMoney = money;
                Shorts.AddSpace(1);
                Shorts.Write($"Nice! Your account shows: $" + money + ".00\n");
            }
            else
            {
                GameOverConditions.DetermineIfGameOver();
            }
        }
        public static void WageSelection()
        {
            Shorts.Write("How much would you like to wage? \n");
            if (currentBankAmount > 0)
            {

                amountWaged = Convert.ToInt32(Shorts.ConsoleInput());
                //If statement for different bet amounts
                if (amountWaged > 0)
                {
                    Console.Clear();
                    //if current money amount equals the amount betted - All in! 
                    if (amountWaged == Account.CheckMoneyStatus())
                    {
                        if (GameOverConditions.DetermineIfGameOver() == true)
                        {
                            Shorts.AddSpace(1);
                            Shorts.Write("ALRIGHT YOU ARE ALL IN\n");
                            Shorts.Write("Good Luck!!!\n");
                            Shorts.AddSpace(1);
                            //Use the subtract method called from the Account class and pass the variable amountBetted using the ref keywaord, which is needed to pass an argument to a method
                            //Wage minus Current Money
                            Account.Subtract(ref amountWaged);
                            Game.SelectionBetMenu();
                        }
                        else
                        {
                            rouletteConditional = false;
                        }
                    }
                    else if (amountWaged > Convert.ToInt32(Account.CheckMoneyStatus()))
                    {
                        //Console.WriteLine(amountWaged);
                        //Console.WriteLine(Account.CheckMoneyStatus());
                        Console.WriteLine("Sorry, but that wager is higher than what's in your account");
                        Account.Bank();
                        TryAgainMessage.TryAgain();
                    }
                    else
                    {
                        Account.Subtract(ref amountWaged);
                        int newBalance = currentBankAmount - amountWaged;
                        Console.WriteLine($"Alright you made a bet of: ${amountWaged}.00 leaving you a balance of ${newBalance}.00");
                        Shorts.AddSpace(1);
                        Game.SelectionBetMenu();
                    }
                }
                else
                {
                    GameOverConditions.GameOver();
                }

            }
        }
        public static void SelectionBetMenu()
        {
            Shorts.Write("PLACE YOUR BET:\n");
            Shorts.Write("[ 1]  Pick a Number\n" +
                    "[ 2]  Red\n" +
                    "[ 3]  Black\n" +
                    "[ 4]  Even\n" +
                    "[ 5]  Odd\n" +
                    "[ 6]  Low (1 thru 18)\n" +
                    "[ 7]  High (19 thru 36\n" +
                    "[ 8]  Dozens\n" +
                    "[ 9]  Columns\n" +
                    "[10]  Street\n" +
                    "[11]  Six Numbers\n" +
                    "[12]  Splits\n" +
                    "[13]  Corners\n" +
                    "[14]  PLAY ALL BETS");
            Shorts.AddSpace(2);
            ASCII_Art.RouletteTableArt();
            Console.WriteLine();
            RouletteGame();
        }
        public static int BallLandsOnThisNUmber()
        {
            Random randAll = new Random();
            //37 and 38 are 0 and 00
            int[] all_numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38 };
            int randomNum = randAll.Next(1, all_numbers.Length);

            //Used to Debug - wage max and pick a number - number 0
            //int[] all_numbers = { 35 };
            //var randomNum = random.Next(35, 35);
            int ballNumber = randomNum;
            return ballNumber;
        }
        public static void BallDrops()
        {
            Console.WriteLine("ALL BETS ARE CLOSED!");
            Console.WriteLine("Wheel spins....");
            Console.WriteLine("Ball drops");
            if (BallLandsOnThisNUmber() == 37)
            {
                Console.WriteLine($"The ball landed on: 00");
            }
            else if (BallLandsOnThisNUmber() == 38)
            {
                Console.WriteLine($"The ball landed on: 0");
            }
            else
            {
                Console.WriteLine($"The ball landed on: {BallLandsOnThisNUmber()}");
            }
        }
        public static void PlayAgainQuestion()
        {

            if (currentBankAmount <= 0)
            {
                GameOverConditions.GameOver();
            }
            else if (currentBankAmount - amountWaged <= 0)//amount - current 
            {
                GameOverConditions.GameOver();
            }
            else
            {
                Console.WriteLine("Want to play again?");
                var response = Console.ReadLine();
                var responseConverted = response.ToUpper();
                if (responseConverted == "Y")
                {
                    Console.Clear();
                    ASCII_Art.RouletteTableArt();
                    Account.Bank();
                    WageSelection();
                }
                else if (responseConverted == "N")
                {
                    GameOverConditions.GameOver();

                }
                else
                {
                    Console.WriteLine("Incorrect fomrat, enter a [Y] or [N]");
                    PlayAgainQuestion();
                }
            }
        }
        public static void PickANUmber()
        {
            Console.WriteLine("Pick a number: 0, 00, or 1 thru 36");
            string pickANumber;
            pickANumber = Console.ReadLine();
            int ballNumber = BallLandsOnThisNUmber();
            if (pickANumber == "0" || pickANumber == "00")
            {
                switch (pickANumber)
                {
                    case "00":
                        Console.WriteLine($"You selected 00");
                        BallDrops();
                        if (ballNumber == 37)
                        {
                            Console.WriteLine($"YOU WON ${amountWaged * 35}.00!");
                            currentBankAmount = (amountWaged * 35) + currentBankAmount;
                            Console.WriteLine($"You have ${currentBankAmount}.00");
                        }
                        else
                        {
                            Console.WriteLine("Sorry you lost");
                            Account.Bank();
                        }
                        break;
                    case "0":
                        Console.WriteLine($"You selected Zero");
                        BallDrops();
                        if (ballNumber == 0)
                        {
                            Console.WriteLine($"YOU WON ${amountWaged * 35}.00!");
                            currentBankAmount = (amountWaged * 35) + currentBankAmount;
                            Console.WriteLine($"You have ${currentBankAmount}.00");
                            Game.AddMoney(ref currentBankAmount);
                            Account.Bank();
                        }
                        else
                        {
                            Console.WriteLine("Sorry you lost");
                            Account.Bank();
                        }
                        break;
                }
            }
            else if (pickANumber == "1" || pickANumber == "2" || pickANumber == "3" || pickANumber == "4" || pickANumber == "5" || pickANumber == "6" || pickANumber == "7" || pickANumber == "8" || pickANumber == "9" || pickANumber == "10" || pickANumber == "11" || pickANumber == "12" || pickANumber == "13" || pickANumber == "14" || pickANumber == "15" || pickANumber == "16" || pickANumber == "17" || pickANumber == "18" || pickANumber == "19" || pickANumber == "20" || pickANumber == "21" || pickANumber == "22" || pickANumber == "23" || pickANumber == "24" || pickANumber == "25" || pickANumber == "26" || pickANumber == "27" || pickANumber == "28" || pickANumber == "29" || pickANumber == "30" || pickANumber == "31" || pickANumber == "32" || pickANumber == "33" || pickANumber == "34" || pickANumber == "35" || pickANumber == "36")
            {
                int pickANumberConverted = Convert.ToInt32(pickANumber);
                if (pickANumberConverted > 0 && pickANumberConverted < 37)
                {
                    Console.WriteLine($"You selected {pickANumberConverted}");

                    BallDrops();
                    if (ballNumber == pickANumberConverted)
                    {
                        Console.WriteLine($"YOU WON ${amountWaged * 35}.00!");
                        currentBankAmount = (amountWaged * 35) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                    }
                    else
                    {
                        if (currentBankAmount - amountWaged <= 0)//amount - current 
                        {
                            GameOverConditions.GameOver();
                            rouletteConditional = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry you lost");
                            Account.Bank();


                        }
                    }

                }
                else
                {
                    Console.WriteLine($"That's not the correct format.  You typed {pickANumber}");
                    PickANUmber();
                }
            }
            else
            {
                Console.WriteLine($"That's not the correct format.  You typed {pickANumber}");
                PickANUmber();
            }

        }
        public static void Red()
        {
            //RED CODE
            int[] red_nums = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

            Console.WriteLine("You selected Red");
            BallLandsOnThisNUmber();
            BallDrops();

            if (red_nums.Any(i => i == ballNumber))
            {
                Console.WriteLine($"IT'S RED - YOU WON! ${amountWaged * 2}.00!");
                currentBankAmount = (amountWaged * 2) + currentBankAmount;
                Console.WriteLine($"You have ${currentBankAmount}.00");
                Game.AddMoney(ref currentBankAmount);
                Account.Bank();



            }
            else if (red_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
            {
                Console.WriteLine("Sorry, it's Black, you lose");
                Account.Bank();

            }
            else
            {
                Console.WriteLine("GREEN, sorry you lose");
                Account.Bank();

            }
        }
        public static void Black()
        {
            //BLACK CODE
            int[] black_nums = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };


            Console.WriteLine("You selected Black");
            BallLandsOnThisNUmber();
            BallDrops();

            if (black_nums.Any(i => i == ballNumber))
            {
                Console.WriteLine($"IT'S BLACK - YOU WON! ${amountWaged * 2}.00!");
                currentBankAmount = (amountWaged * 2) + currentBankAmount;
                Console.WriteLine($"You have ${currentBankAmount}.00");
                Game.AddMoney(ref currentBankAmount);
                Account.Bank();
            }
            else if (black_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
            {
                Console.WriteLine("Sorry, it's Red, you lose");
                Account.Bank();

            }
            else
            {
                Console.WriteLine("GREEN, sorry you lose");
                Account.Bank();

            }

        }
        public static void Even()
        {
            //Even CODE
            int[] even_nums = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };

            Console.WriteLine("You selected Even");
            BallLandsOnThisNUmber();
            BallDrops();

            if (even_nums.Any(i => i == ballNumber))
            {
                Console.WriteLine($"IT'S EVEN - YOU WON! ${amountWaged * 2}.00!");
                currentBankAmount = (amountWaged * 2) + currentBankAmount;
                Console.WriteLine($"You have ${currentBankAmount}.00");
                Game.AddMoney(ref currentBankAmount);
                Account.Bank();
            }
            else if (even_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
            {
                Console.WriteLine("Sorry, it's Odd, you lose");
                Account.Bank();

            }
            else
            {
                Console.WriteLine("GREEN, sorry you lose");
                Account.Bank();

            }

        }
        public static void Odd()
        {
            //Odd CODE
            int[] odd_nums = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };

            Console.WriteLine("You selected Odd");
            BallLandsOnThisNUmber();
            BallDrops();

            if (odd_nums.Any(i => i == ballNumber))
            {
                Console.WriteLine($"IT'S ODD - YOU WON! ${amountWaged * 2}.00!");
                currentBankAmount = (amountWaged * 2) + currentBankAmount;
                Console.WriteLine($"You have ${currentBankAmount}.00");
                Game.AddMoney(ref currentBankAmount);
                Account.Bank();
            }
            else if (odd_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
            {
                Console.WriteLine("Sorry, it's Even, you lose");
                Account.Bank();

            }
            else
            {
                Console.WriteLine("GREEN, sorry you lose");
                Account.Bank();

            }

        }
        public static void Low()
        {
            //Low CODE
            int[] low_nums = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            Console.WriteLine("You selected Low");
            BallLandsOnThisNUmber();
            BallDrops();

            if (low_nums.Any(i => i == ballNumber))
            {
                Console.WriteLine($"IT'S LOW - YOU WON! ${amountWaged * 2}.00!");
                currentBankAmount = (amountWaged * 2) + currentBankAmount;
                Console.WriteLine($"You have ${currentBankAmount}.00");
                Game.AddMoney(ref currentBankAmount);
                Account.Bank();
            }
            else if (low_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
            {
                Console.WriteLine("Sorry, it's High, you lose");
                Account.Bank();

            }
            else
            {
                Console.WriteLine("GREEN, sorry you lose");
                Account.Bank();

            }

        }
        public static void High()
        {
            //High CODE
            int[] high_nums = { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

            Console.WriteLine("You selected High");
            BallLandsOnThisNUmber();
            BallDrops();

            if (high_nums.Any(i => i == ballNumber))
            {
                Console.WriteLine($"IT'S HIGH - YOU WON! ${amountWaged * 2}.00!");
                currentBankAmount = (amountWaged * 2) + currentBankAmount;
                Console.WriteLine($"You have ${currentBankAmount}.00");
                Game.AddMoney(ref currentBankAmount);
                Account.Bank();
            }
            else if (high_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
            {
                Console.WriteLine("Sorry, it's Low, you lose");
                Account.Bank();

            }
            else
            {
                Console.WriteLine("GREEN, sorry you lose");
                Account.Bank();

            }
        }
        public static void Dozens()
        {
            Console.WriteLine("Choose a Dozen:");
            Console.WriteLine("[1] 1 thru 12");
            Console.WriteLine("[2] 13 thru 24");
            Console.WriteLine("[3] 25 thru 36");
            string pickADozen;
            pickADozen = Console.ReadLine();
            if (pickADozen == "1" || pickADozen == "2" || pickADozen == "3")
            {
                Console.WriteLine($"You selected {pickADozen}");
                if (pickADozen == "1")
                {
                    //1-12 Code
                    int[] lowDozen_nums = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

                    Console.WriteLine("You selected 1 thru 12");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (lowDozen_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S 1 thru 12 - YOU WON! ${amountWaged * 2}.00!");
                        currentBankAmount = (amountWaged * 2) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (lowDozen_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not 1 thru 12, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickADozen == "2")
                {
                    //13-24 Code
                    int[] midDozen_nums = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

                    Console.WriteLine("You selected 13 thru 24");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (midDozen_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S 13 thru 24 - YOU WON! ${amountWaged * 2}.00!");
                        currentBankAmount = (amountWaged * 2) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (midDozen_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not 13 thru 24, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }

                }
                else
                {
                    //25-36 Code
                    int[] highDozen_nums = { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38 };

                    Console.WriteLine("You selected 25 thru 36");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (highDozen_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S 25 thru 36 - YOU WON! ${amountWaged * 2}.00!");
                        currentBankAmount = (amountWaged * 2) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (highDozen_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not 25 thru 36, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
            }
            else
            {
                if (pickADozen == "0")
                {
                    Console.WriteLine($"You selected {pickADozen}");
                }
                else
                {
                    Console.WriteLine($"You selected {pickADozen}");
                    Console.WriteLine("That's not a choice, try again");
                    Dozens();
                }
            }
        }
        public static void Columns()
        {
            Console.WriteLine("Choose a Column:");
            Console.WriteLine("[1] Column 1");
            Console.WriteLine("[2] Column 2");
            Console.WriteLine("[3] Column 3");
            string pickColumnn;
            pickColumnn = Console.ReadLine();
            if (pickColumnn == "1" || pickColumnn == "2" || pickColumnn == "3")
            {


                Console.WriteLine($"You selected {pickColumnn}");
                if (pickColumnn == "1")
                {
                    //Column 1 Code
                    int[] column1_nums = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

                    Console.WriteLine("You selected Column 1");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (column1_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Column 1 - YOU WON! ${amountWaged * 3}.00!");
                        currentBankAmount = (amountWaged * 3) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (column1_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Column 1, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();

                    }

                }
                else if (pickColumnn == "2")
                {
                    //Column 2 Code
                    int[] column2_nums = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };

                    Console.WriteLine("You selected Column 2");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (column2_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Column 2- YOU WON! ${amountWaged * 3}.00!");
                        currentBankAmount = (amountWaged * 3) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (column2_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Column 2, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();

                    }
                }
                else
                {
                    //Column 3 Code
                    int[] column3_nums = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

                    Console.WriteLine("Column 3");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (column3_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Column 3 - YOU WON! ${amountWaged * 3}.00!");
                        currentBankAmount = (amountWaged * 3) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (column3_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Column 3, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
            }
            else
            {
                if (pickColumnn == "0")
                {
                    Console.WriteLine($"You selected {pickColumnn}");
                }
                else
                {
                    Console.WriteLine($"You selected {pickColumnn}");
                    Console.WriteLine("That's not a choice, try again");
                    Columns();
                }
            }
        }
        public static void Street()
        {
            Console.WriteLine("Choose a Street:");
            Console.WriteLine("[ 1] Numbers 1 thru 3");
            Console.WriteLine("[ 2] Numbers 4 thru 6");
            Console.WriteLine("[ 3] Numbers 7 thru 9");
            Console.WriteLine("[ 4] Numbers 10 thru 12");
            Console.WriteLine("[ 5] Numbers 13 thru 15");
            Console.WriteLine("[ 6] Numbers 16 thru 18");
            Console.WriteLine("[ 7] Numbers 19 thru 21");
            Console.WriteLine("[ 8] Numbers 22 thru 24");
            Console.WriteLine("[ 9] Numbers 25 thru 27");
            Console.WriteLine("[10] Numbers 28 thru 30");
            Console.WriteLine("[11] Numbers 31 thru 33");
            Console.WriteLine("[12] Numbers 34 thru 36");

            string pickStreet;
            pickStreet = Console.ReadLine();
            if (pickStreet == "1" || pickStreet == "2" || pickStreet == "3" || pickStreet == "4" || pickStreet == "5" || pickStreet == "6" || pickStreet == "7" || pickStreet == "8" || pickStreet == "9" || pickStreet == "10" || pickStreet == "11" || pickStreet == "12")
            {
                Console.WriteLine($"You selected {pickStreet}");
                if (pickStreet == "1")
                {
                    //Street 1 Code
                    int[] street1_nums = { 1, 2, 3 };

                    Console.WriteLine("You selected Street 1");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street1_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 1 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street1_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 1, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "2")
                {
                    //Street 2 Code
                    int[] street2_nums = { 4, 5, 6 };

                    Console.WriteLine("You selected Street 2");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street2_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 2- YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street2_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 2, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }

                }
                else if (pickStreet == "3")
                {
                    //Street 3 Code
                    int[] street3_nums = { 7, 8, 9 };

                    Console.WriteLine("You selected Street 3");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street3_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 3 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street3_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 3, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }

                }
                else if (pickStreet == "4")
                {
                    //Street 4 Code
                    int[] street4_nums = { 10, 11, 12 };

                    Console.WriteLine("You selected Street 4");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street4_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 4 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street4_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 4, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "5")
                {
                    //Street 5 Code
                    int[] street5_nums = { 13, 14, 15 };

                    Console.WriteLine("You selected Street 5");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street5_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 5 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street5_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 5, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "6")
                {
                    //Street 6 Code
                    int[] street6_nums = { 16, 17, 18 };

                    Console.WriteLine("You selected Street 6");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street6_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 6 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street6_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 6, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "7")
                {
                    //Street 7 Code
                    int[] street7_nums = { 19, 20, 21 };

                    Console.WriteLine("You selected Street 7");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street7_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 7 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street7_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 7, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "8")
                {
                    //Street 8 Code
                    int[] street8_nums = { 22, 23, 24 };

                    Console.WriteLine("You selected Street 8");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street8_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 8 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street8_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 8, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "9")
                {
                    //Street 9 Code
                    int[] street9_nums = { 25, 26, 27 };

                    Console.WriteLine("You selected Street 9");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street9_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 9 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street9_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 9, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "10")
                {
                    //Street 10 Code
                    int[] street10_nums = { 28, 29, 30 };

                    Console.WriteLine("You selected Street 10");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street10_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 10 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street10_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 10, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "11")
                {
                    //Street 11 Code
                    int[] street11_nums = { 31, 32, 33 };

                    Console.WriteLine("You selected Street 11");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street11_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 11 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street11_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 11, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickStreet == "12")
                {
                    //Street 12 Code
                    int[] street12_nums = { 34, 35, 36 };

                    Console.WriteLine("You selected Street 12");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (street12_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 12 - YOU WON! ${amountWaged * 11}.00!");
                        currentBankAmount = (amountWaged * 11) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (street12_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Street 12, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
            }
            else
            {
                if (pickStreet == "0")
                {
                    Console.WriteLine($"You selected {pickStreet}");
                }
                else
                {
                    Console.WriteLine($"You selected {pickStreet}");
                    Console.WriteLine("That's not a choice, try again");
                    Street();
                }
            }
        }
        public static void SixLine()
        {
            Console.WriteLine("Choose a Six Line:");
            Console.WriteLine("[ 1] Numbers 1 thru 6");
            Console.WriteLine("[ 2] Numbers 4 thru 9");
            Console.WriteLine("[ 3] Numbers 7 thru 12");
            Console.WriteLine("[ 4] Numbers 10 thru 15");
            Console.WriteLine("[ 5] Numbers 13 thru 18");
            Console.WriteLine("[ 6] Numbers 16 thru 21");
            Console.WriteLine("[ 7] Numbers 19 thru 24");
            Console.WriteLine("[ 8] Numbers 22 thru 27");
            Console.WriteLine("[ 9] Numbers 25 thru 30");
            Console.WriteLine("[10] Numbers 28 thru 33");
            Console.WriteLine("[11] Numbers 31 thru 36");

            string pickSixLine;
            pickSixLine = Console.ReadLine();
            if (pickSixLine == "1" || pickSixLine == "2" || pickSixLine == "3" || pickSixLine == "4" || pickSixLine == "5" || pickSixLine == "6" || pickSixLine == "7" || pickSixLine == "8" || pickSixLine == "9" || pickSixLine == "10" || pickSixLine == "11")
            {

                Console.WriteLine($"You selected {pickSixLine}");
                if (pickSixLine == "1")
                {
                    //Six Line 1 Code
                    int[] sixLine1_nums = { 1, 2, 3, 4, 5, 6 };

                    Console.WriteLine("You selected Six Line 1");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine1_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 1 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine1_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 1, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();

                    }

                }
                else if (pickSixLine == "2")
                {

                    //Six Line 2 Code
                    int[] sixLine2_nums = { 4, 5, 6, 7, 8, 9 };

                    Console.WriteLine("You selected Six Line 2");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine2_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 2- YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine2_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 2, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();

                    }

                }
                else if (pickSixLine == "3")
                {
                    //Six Line 3 Code
                    int[] sixLine3_nums = { 7, 8, 9, 10, 11, 12 };

                    Console.WriteLine("You selected Six Line 3");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine3_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 3 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine3_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 3, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }

                }
                else if (pickSixLine == "4")
                {
                    //Six Line 4 Code
                    int[] sixLine4_nums = { 10, 11, 12, 13, 14, 15 };

                    Console.WriteLine("You selected Six Line 4");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine4_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 4 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine4_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 4, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "5")
                {
                    //Six Line 5 Code
                    int[] sixLine5_nums = { 13, 14, 15, 16, 17, 18 };

                    Console.WriteLine("You selected Six Line 5");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine5_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 5 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine5_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 5, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "6")
                {
                    //Six Line 6 Code
                    int[] sixLine6_nums = { 16, 17, 18, 19, 20, 21 };

                    Console.WriteLine("You selected Six Line 6");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine6_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 6 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine6_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 6, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "7")
                {
                    //Six Line 7 Code
                    int[] sixLine7_nums = { 19, 20, 21, 22, 23, 24 };

                    Console.WriteLine("You selected Six Line 7");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine7_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 7 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine7_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 7, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "8")
                {
                    //Six Line 8 Code
                    int[] sixLine8_nums = { 22, 23, 24, 25, 26, 27 };

                    Console.WriteLine("You selected Six Line 8");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine8_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 8 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine8_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 8, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "9")
                {
                    //Six Line 9 Code
                    int[] sixLine9_nums = { 25, 26, 27, 28, 29, 30 };

                    Console.WriteLine("You selected Six Line 9");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine9_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 9 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine9_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 9, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "10")
                {
                    //Six Line 10 Code
                    int[] sixLine10_nums = { 28, 29, 30, 31, 32, 33 };

                    Console.WriteLine("You selected Six Line 10");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine10_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Street 10 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine10_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 10, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
                else if (pickSixLine == "11")
                {
                    //Six Line 11 Code
                    int[] sixLine11_nums = { 31, 32, 33, 34, 35, 36 };

                    Console.WriteLine("You selected Six Line 11");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (sixLine11_nums.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S Six Line 11 - YOU WON! ${amountWaged * 5}.00!");
                        currentBankAmount = (amountWaged * 5) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (sixLine11_nums.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine("Sorry, it's not Six Line 11, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                }
            }
            else
            {
                if (pickSixLine == "0")
                {
                    Console.WriteLine($"You selected {pickSixLine}");
                }
                else
                {
                    Console.WriteLine($"You selected {pickSixLine}");
                    Console.WriteLine("That's not a choice, try again");
                    SixLine();
                }
            }
        }
        public static void Spilts()
        {
            Console.WriteLine("Choose a Spilts:");
            Console.WriteLine("Type two numbers with the lowest number first");
            Console.WriteLine("example if you want to split numbers 4 and 7 type: \"4 7\"");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1 2":
                    int[] nums1 = { 1, 2 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums1.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums1.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "1 4":
                    int[] nums2 = { 1, 4 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums2.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums2.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "2 3":
                    int[] nums3 = { 2, 3 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums3.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums3.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "3 6":
                    int[] nums4 = { 3, 6 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums4.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums4.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "4 5":
                    int[] nums5 = { 4, 5 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums5.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums5.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "5 6":
                    int[] nums6 = { 5, 6 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums6.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums6.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "4 7":
                    int[] nums7 = { 4, 7 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums7.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums7.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "7 8":
                    int[] nums8 = { 7, 8 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums8.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums8.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "5 8":
                    int[] nums9 = { 5, 8 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums9.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums9.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "6 9":
                    int[] nums10 = { 6, 9 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums10.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums10.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "8 9":
                    int[] nums11 = { 8, 9 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums11.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums11.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "7 10":
                    int[] nums12 = { 7, 10 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums12.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums12.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "10 11":
                    int[] nums13 = { 10, 11 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums13.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums13.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "8 11":
                    int[] nums14 = { 8, 11 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums14.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums14.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "11 12":
                    int[] nums15 = { 11, 12 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums15.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums15.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "9 12":
                    int[] nums16 = { 9, 12 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums16.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums16.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "10 13":
                    int[] nums17 = { 10, 13 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums17.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums17.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "11 14":
                    int[] nums18 = { 11, 14 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums18.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums18.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "12 15":
                    int[] nums19 = { 12, 15 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums19.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums19.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "13 14":
                    int[] num20 = { 13, 14 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (num20.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (num20.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "14 15":
                    int[] nums21 = { 14, 15 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums21.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums21.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "13 16":
                    int[] nums22 = { 13, 16 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums22.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums22.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "14 17":
                    int[] nums23 = { 14, 17 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums23.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums23.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "15 18":
                    int[] nums24 = { 15, 18 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums24.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums24.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "16 17":
                    int[] nums25 = { 16, 17 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums25.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums25.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "17 18":
                    int[] nums26 = { 17, 18 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums26.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums26.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "16 19":
                    int[] nums27 = { 16, 19 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums27.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums27.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "17 20":
                    int[] nums28 = { 17, 20 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums28.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums28.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "18 21":
                    int[] nums29 = { 18, 21 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums29.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums29.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "19 20":
                    int[] nums30 = { 19, 20 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums30.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums30.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "20 21":
                    int[] nums31 = { 20, 21 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums31.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums31.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "19 22":
                    int[] nums32 = { 19, 22 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums32.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums32.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "20 23":
                    int[] nums33 = { 20, 23 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums33.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums33.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "21 24":
                    int[] nums34 = { 21, 24 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums34.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums34.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "22 23":
                    int[] nums35 = { 22, 23 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums35.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums35.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "23 24":
                    int[] nums36 = { 23, 24 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums36.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums36.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "22 25":
                    int[] nums37 = { 22, 25 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums37.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums37.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "23 26":
                    int[] nums38 = { 23, 26 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums38.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums38.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "24 27":
                    int[] nums39 = { 24, 27 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums39.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums39.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "25 26":
                    int[] nums40 = { 25, 26 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums40.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums40.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "26 27":
                    int[] nums41 = { 26, 27 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums41.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums41.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "25 28":
                    int[] nums42 = { 25, 28 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums42.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums42.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "26 29":
                    int[] nums43 = { 26, 29 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums43.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums43.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "27 30":
                    int[] nums44 = { 27, 30 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums44.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums44.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "28 29":
                    int[] nums45 = { 28, 29 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums45.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums45.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "29 30":
                    int[] nums46 = { 29, 30 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums46.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums46.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "28 31":
                    int[] nums47 = { 28, 31 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums47.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums47.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "29 32":
                    int[] nums48 = { 29, 32 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums48.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums48.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "30 33":
                    int[] nums49 = { 30, 33 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums49.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums49.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "31 32":
                    int[] nums50 = { 31, 32 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums50.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums50.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "32 33":
                    int[] nums51 = { 32, 33 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums51.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums51.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "31 34":
                    int[] nums52 = { 31, 34 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums52.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums52.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "32 35":
                    int[] nums53 = { 32, 35 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums53.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums53.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "33 36":
                    int[] nums54 = { 33, 36 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums54.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums54.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "34 35":
                    int[] nums55 = { 34, 35 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums55.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums55.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "35 36":
                    int[] nums56 = { 35, 36 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();

                    if (nums56.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S {input} - YOU WON! ${amountWaged * 17}.00!");
                        currentBankAmount = (amountWaged * 17) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums56.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not {input}, you lose");
                        Account.Bank();

                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                default:
                    Console.WriteLine($"That's not the correct format.  You typed {input}");
                    Spilts();
                    break;
            }
        }
        public static void Corner()
        {
            Console.WriteLine("Choose a Corner:");
            Console.WriteLine("[ 1] Numbers 1, 2, 4, 5");
            Console.WriteLine("[ 2] Numbers 2, 3, 5, 6");
            Console.WriteLine("[ 3] Numbers 4, 5, 7, 8");
            Console.WriteLine("[ 4] Numbers 5, 6, 8, 9");
            Console.WriteLine("[ 5] Numbers 7, 8, 10, 11");
            Console.WriteLine("[ 6] Numbers 8, 9, 11, 12");
            Console.WriteLine("[ 7] Numbers 10, 11, 13, 14");
            Console.WriteLine("[ 8] Numbers 11, 12, 14, 15");
            Console.WriteLine("[ 9] Numbers 13, 14, 16, 17");
            Console.WriteLine("[10] Numbers 14, 15, 17, 18");
            Console.WriteLine("[11] Numbers 16, 17, 19, 20");
            Console.WriteLine("[12] Numbers 17, 18, 20, 21");
            Console.WriteLine("[13] Numbers 19, 20, 22, 23");
            Console.WriteLine("[14] Numbers 20, 21, 23, 24");
            Console.WriteLine("[15] Numbers 22, 23, 25, 26");
            Console.WriteLine("[16] Numbers 23, 24, 26, 27");
            Console.WriteLine("[17] Numbers 25, 26, 28, 29");
            Console.WriteLine("[18] Numbers 26, 27, 29, 30");
            Console.WriteLine("[19] Numbers 28, 29, 31, 32");
            Console.WriteLine("[20] Numbers 29, 30, 32, 33");
            Console.WriteLine("[21] Numbers 31, 32, 34, 35");
            Console.WriteLine("[22] Numbers 32, 33, 35, 36");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    int[] nums1 = { 1, 2, 4, 5 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums1.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums1.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "2":
                    int[] nums2 = { 2, 3, 5, 6 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums2.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE{input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums2.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "3":
                    int[] nums3 = { 4, 5, 7, 8 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums3.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE{input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums3.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "4":
                    int[] nums4 = { 5, 6, 8, 9 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums4.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE{input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums4.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "5":
                    int[] nums5 = { 7, 8, 10, 11 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums5.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums5.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "6":
                    int[] nums6 = { 8, 9, 11, 12 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums6.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums6.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "7":
                    int[] nums7 = { 10, 11, 13, 14 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums7.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums7.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "8":
                    int[] nums8 = { 11, 12, 14, 15 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums8.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums8.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "9":
                    int[] nums9 = { 13, 14, 16, 17 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums9.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums9.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "10":
                    int[] nums10 = { 14, 15, 17, 18 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums10.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums10.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "11":
                    int[] nums11 = { 16, 17, 19, 20 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums11.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums11.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "12":
                    int[] nums12 = { 17, 18, 20, 21 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums12.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums12.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "13":
                    int[] nums13 = { 19, 20, 22, 23 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums13.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums13.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "14":
                    int[] nums14 = { 20, 21, 23, 24 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums14.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums14.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "15":
                    int[] nums15 = { 22, 23, 25, 26 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums15.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums15.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "16":
                    int[] nums16 = { 23, 24, 26, 27 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums16.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums16.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "17":
                    int[] nums17 = { 25, 26, 28, 29 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums17.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums17.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "18":
                    int[] nums18 = { 26, 27, 29, 30 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums18.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums18.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "19":
                    int[] nums19 = { 28, 29, 31, 32 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums19.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums19.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "20":
                    int[] nums20 = { 29, 30, 32, 33 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums20.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums20.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "21":
                    int[] nums21 = { 31, 32, 34, 35 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums21.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums21.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                case "22":
                    int[] nums22 = { 32, 33, 35, 36 };

                    Console.WriteLine($"You selected {input}");
                    BallLandsOnThisNUmber();
                    BallDrops();
                    if (nums22.Any(i => i == ballNumber))
                    {
                        Console.WriteLine($"IT'S LINE {input} - YOU WON! ${amountWaged * 8}.00!");
                        currentBankAmount = (amountWaged * 8) + currentBankAmount;
                        Console.WriteLine($"You have ${currentBankAmount}.00");
                        Game.AddMoney(ref currentBankAmount);
                        Account.Bank();
                    }
                    else if (nums22.Any(i => i != ballNumber && ballNumber != 37 && ballNumber != 38))
                    {
                        Console.WriteLine($"Sorry, it's not LINE {input}, you lose");
                        Account.Bank();
                    }
                    else
                    {
                        Console.WriteLine("GREEN, sorry you lose");
                        Account.Bank();
                    }
                    break;
                default:
                    Console.WriteLine($"That's not the correct format.  You typed {input}");
                    Corner();
                    break;
            }

        }
        public static void PlayAllBets()
        {
            PickANUmber();
            Red();
            Black();
            Even();
            Odd();
            Low();
            High();
            Dozens();
            Columns();
            Street();
            SixLine();
            Spilts();
            Corner();
        }
        public static void GambleTime()
        {
            int betSelection;
            betSelection = Convert.ToInt32(Shorts.ConsoleInput());


            if (betSelection == 1)
            {
                PickANUmber();

            }
            else if (betSelection == 2)
            {
                Red();

            }
            else if (betSelection == 3)
            {
                Black();

            }
            else if (betSelection == 4)
            {
                Even();

            }
            else if (betSelection == 5)
            {
                Odd();

            }
            else if (betSelection == 6)
            {
                Low();

            }
            else if (betSelection == 7)
            {
                High();

            }
            else if (betSelection == 8)
            {
                Dozens();

            }
            else if (betSelection == 9)
            {
                Columns();

            }
            else if (betSelection == 10)
            {
                Street();

            }
            else if (betSelection == 11)
            {
                SixLine();

            }
            else if (betSelection == 12)
            {
                Spilts();

            }
            else if (betSelection == 13)
            {
                Corner();

            }
            else if (betSelection == 14)
            {
                PlayAllBets();

            }
            else
            {
                Console.WriteLine($"That's not the correct format.  You typed {betSelection}");
                SelectionBetMenu();
            }
            PlayAgainQuestion();


        }
        public static void RouletteGame()
        {
            //If the players money reaches zero or less exit out the while loop
            if (rouletteConditional == true)
            {
                //WageSelection();
                GambleTime();
            }
        }
    }
    public static class Program
    {
        public static void Main(string[] args)
        {
            //MasterClasses.FullScreen.WideScreenMethod();
            Console.WriteLine("Hello World!");
            Console.Clear();
            ASCII_Art.RouletteTableArt();
            Shorts.AddSpace(2);
            Shorts.Write("Welcome to James Silcott's Casino!\n");
            Shorts.Write("Let's Play Roulette\n");
            Shorts.AddSpace(3);
            Account.Bank();
            Shorts.AddSpace(1);
            Game.WageSelection();
        }

    }
}