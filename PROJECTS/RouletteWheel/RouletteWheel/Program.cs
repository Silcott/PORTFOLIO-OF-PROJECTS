using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;

namespace RouletteWheel
{

    class Casino
    {
        //METHODS

        //This will allow me to pass a string into the method without calling the Writline method
        static void Write(string str)
        {
            Console.Write(str);
        }
        //This will add blank spaces cutting my time and code down
        static void AddSpace(int num)
        {
            do
            {
                Console.WriteLine();
                num--;
            } while (num > 0);

        }
        //This takes the users text they type and assigns it and return its value so i can call upon it later
        static string ConsoleInput()
        {
            string conInput = Console.ReadLine();
            return conInput;
        }
        //VARIABLES
        static int[] red_nums = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        static int[] black_nums = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        static int[] green_nums = { 37, 38 };

        static int[] even_nums = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        static int[] odd_nums = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };


        static int[] low_nums = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        static int[] high_nums = { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };


        static Random random = new Random();


        //CLASSES
        public class Account
        {
            //Set the variable money to an integer
            static int currentMoney;
            //Declare the class to put the variable money in so I can call it later and store any added/subtracted integers
            public Account()
            {
                currentMoney = 10;
            }
            //This method shows the current account balance from the varaiable money in Account Class
            public void Bank()
            {
                Write($"Current Account Balance: ${currentMoney}.00\n");
            }
            public int CheckMoneyStatus()
            {
                return currentMoney;
            }
            //This method will add the current account money and the amount that was bet
            public void Add(int bet)
            {
                currentMoney = currentMoney + bet;
            }
            public void Subtract(ref int wage)
            {
                if ((currentMoney - wage) < 0)
                {
                    wage = currentMoney;
                    AddSpace(1);
                    Write($"Sorry, but according to our bank you don't have enough to make that bet.  Your account shows: $" + wage + ".00\n");
                }
                else
                {
                    currentMoney = currentMoney - wage;
                }
            }
            public void AddMoney(ref int money)
            {
                if (money > 0)
                {
                    currentMoney = money;
                    AddSpace(1);
                    Write($"Nice! Your account shows: $" + money + ".00\n");
                }
                else
                {
                    DetermineIfGameOver();
                }
            }


            //Method boolean to see if the current money account reaches zero, if yes game over
            public bool DetermineIfGameOver()
            {
                //If money is zero or less retrun true
                if (currentMoney <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        //Make Fullscreen
        #region FULLSCREEN MODE
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
        static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
        #endregion
        //Main Program
        public static void Main(string[] args)
        {
            bool rouletteConditional = true;

            //Variable to set the condiotnal for the while loop
            //While loop to run the game over and over till the conditional returns false
            while (rouletteConditional == true)
            {
                void GameOver()
                {
                    Console.WriteLine("GAME OVER - Thanks for playing");
                    rouletteConditional = false;

                }
                THEGAME();
                void THEGAME()
                {
                    //This will set the console window to full screen
                    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                    ShowWindow(ThisConsole, MAXIMIZE);

                    static void RouletteTableArt()
                    {

                        //Text Color White
                        void TextColorWhite()
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        //Text Color Red
                        void TextColorRed()
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }

                        //Text Color Black
                        void TextColorBlack()
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        //Background Black
                        void BackColorBlack()
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        //Background Green
                        void BackColorGreen()
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                        }

                        //Background Red
                        void BackColorRed()
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        }

                        //This will allow me to pass a string into the method without calling the Writline method
                        static void Write(string str)
                        {
                            Console.Write(str);
                        }
                        //line 0
                        BackColorBlack();
                        BackColorGreen();
                        Write("  ____________________________________________________________________________________________________________________\n");
                        //line 1
                        Write(" /       |");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|           |\n");
                        //line 2
                        Write(" /       |");
                        BackColorRed();
                        Write("   3   ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   6   ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   9   ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   12  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   15  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   18  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   21  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   24  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   27  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   30  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   33  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   36  ");
                        BackColorGreen();
                        Write("|   Row 1   |\n");
                        //line 3
                        Write(" /   00  |");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|___________|\n");
                        //line 4
                        Write(" /       |");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|           |\n");
                        //line 5
                        Write(" /_______|");
                        BackColorBlack();
                        Write("   2   ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   5   ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   8   ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   11  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   14  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   17  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   20  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   23  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   26  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   29  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   32  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   35  ");
                        BackColorGreen();
                        Write("|   Row 2   |\n");
                        //line 6
                        Write(" \\       |");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|___________|\n");
                        //line 7
                        Write(" \\       |");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("       ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("       ");
                        BackColorGreen();
                        Write("|           |\n");
                        //line 8
                        Write(" \\   0   |");
                        BackColorRed();
                        Write("   1   ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   4   ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   7   ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   10  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   13  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   16  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   19  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   22  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   25  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   28  ");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("   31  ");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("   34  ");
                        BackColorGreen();
                        Write("|   Row 3   |\n");
                        //line 9
                        Write(" \\       |");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorBlack();
                        Write("_______");
                        BackColorGreen();
                        Write("|");
                        BackColorRed();
                        Write("_______");
                        BackColorGreen();
                        Write("|___________|\n");
                        BackColorBlack();
                        //line 10
                        BackColorGreen();
                        Write(" \\_______|                               |                               |                               |\n");
                        BackColorBlack();
                        Write("         ");
                        BackColorGreen();
                        Write("|          DOZEN 1-12           |         DOZEN 13-24           |         DOZEN 25-36           |\n");
                        BackColorBlack();
                        Write("         ");
                        BackColorGreen();
                        Write("|_______________________________|_______________________________|_______________________________|\n");
                        BackColorBlack();
                        Write("         ");
                        BackColorGreen();
                        Write("|               |               |               |               |               |               |\n");
                        BackColorBlack();
                        Write("         ");
                        BackColorGreen();
                        Write("|      1-18     |     EVEN      |");
                        TextColorRed();
                        Write("      RED      ");
                        TextColorWhite();
                        Write("|");
                        TextColorBlack();
                        Write("     BLACK     ");
                        TextColorWhite();
                        Write("|      ODD      |     19-36     |\n");
                        BackColorBlack();
                        Write("         ");
                        BackColorGreen();
                        Write("|_______________|_______________|_______________|_______________|_______________|_______________|\n");
                        BackColorBlack();
                    }

                    //Call the Account constructor -- no arguments -- this allows me to access the classes methods
                    Account player = new Account();
                    //Assign variable for conditional loop
                    int currentBankAmount = player.CheckMoneyStatus();
                    AddSpace(2);
                    Write("Welcome to James Silcott's Casino!\n");
                    Write("Let's Play Roulette\n");
                    AddSpace(3);
                    //RouletteTableArt();
                    AddSpace(3);
                    player.Bank();
                    AddSpace(1);
                    int ballNumber = 0;
                    WageSelection();

                    int amountWaged;

                    void TryAgain()
                    {
                        WageSelection();
                    }
                    void WageSelection()
                    {

                        Write("How much would you like to wage? \n");
                        if (currentBankAmount > 0)
                        {
                            amountWaged = Convert.ToInt32(ConsoleInput());
                            //If statement for different bet amounts
                            if (amountWaged > 0)
                            {
                                Console.Clear();
                                //if current money amount equals the amount betted - All in! 
                                if (amountWaged == player.CheckMoneyStatus())
                                {
                                    if (player.DetermineIfGameOver() == true)
                                    {
                                        AddSpace(1);
                                        Write("ALRIGHT YOU ARE ALL IN\n");
                                        Write("Good Luck!!!\n");
                                        AddSpace(1);
                                        //Use the subtract method called from the Account class and pass the variable amountBetted using the ref keywaord, which is needed to pass an argument to a method
                                        //Wage minus Current Money
                                        player.Subtract(ref amountWaged);
                                        SelectionBetMenu();
                                    }
                                    else
                                    {
                                        rouletteConditional = false;
                                    }
                                }
                                else if (amountWaged > Convert.ToInt32(player.CheckMoneyStatus()))
                                {
                                    //Console.WriteLine(amountWaged);
                                    //Console.WriteLine(player.CheckMoneyStatus());
                                    Console.WriteLine("Sorry, but that wager is higher than what's in your account");
                                    player.Bank();
                                    TryAgain();
                                }
                                else
                                {
                                    player.Subtract(ref amountWaged);
                                    int newBalance = currentBankAmount - amountWaged;
                                    Console.WriteLine($"Alright you made a bet of: ${amountWaged}.00 leaving you a balance of ${newBalance}.00");
                                    AddSpace(1);
                                    SelectionBetMenu();
                                }
                            }
                        }
                        else
                        {
                            rouletteConditional = false;
                        }


                    }
                    void SelectionBetMenu()
                    {
                        Write("PLACE YOUR BET:\n");
                        Write("[ 1]  Pick a Number\n" +
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
                                "[12]  Splits" +
                                "[13]  Corners\n" +
                                "[14]  PLAY ALL BETS");
                        AddSpace(2);
                        RouletteTableArt();
                        Console.WriteLine();
                        RouletteGame();
                    }

                    //Code the Ball Drop Randomizer
                    void BallDrops()
                    {
                        Console.WriteLine("ALL BETS ARE CLOSED!");
                        Console.WriteLine("Wheel spins....");
                        Console.WriteLine("Ball drops");
                        Console.WriteLine($"The ball landed on: {ballNumber}");
                    }

                    int PickANumSelection()
                    {

                        Random randAll = new Random();
                        //37 and 38 are 0 and 00
                        //int[] all_numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38 };
                        //var randomNum = random.Next(1, all_numbers.Length);

                        //Used to Debug - wage max and pick a number - number 0
                        int[] all_numbers = { 37 };
                        var randomNum = random.Next(37, all_numbers.Length);

                        return randomNum;
                    }


                    void PlayAgainQuestion()
                    {

                        if (currentBankAmount - amountWaged <= 0)//amount - current 
                        {
                            rouletteConditional = false;
                        }
                        else
                        {


                            Console.WriteLine("Want to play again?");
                            var response = Console.ReadLine();
                            var responseConverted = response.ToUpper();
                            if (responseConverted == "Y")
                            {
                                Console.Clear();
                                RouletteTableArt();
                                player.Bank();
                                WageSelection();
                            }
                            else if (responseConverted == "N")
                            {
                                GameOver();

                            }
                            else
                            {
                                Console.WriteLine("Incorrect fomrat, enter a [Y] or [N]");
                                PlayAgainQuestion();
                            }
                        }
                    }


                    void RouletteGame()
                    {
                        //If the players money reaches zero or less exit out the while loop
                        while (rouletteConditional == true)
                        {
                            //WageSelection();
                            GambleTime();
                            //Use the subtract method called from the Account class and pass the variable amountBetted using the ref keywaord, which is needed to pass an argument to a method
                            //Wage minus Current Money
                            void GambleTime()
                            {
                                int betSelection;
                                betSelection = Convert.ToInt32(ConsoleInput());
                                if (betSelection! > 0 && betSelection! <= 14)
                                {
                                    switch (betSelection)
                                    {
                                        case 1:
                                            PickANUmber();
                                            void PickANUmber()
                                            {
                                                Console.WriteLine("Pick a number: 0, 00, or 1 thru 36");
                                                string pickANumber;
                                                pickANumber = Console.ReadLine();
                                                int pickANumberConverted = Convert.ToInt32(pickANumber);
                                                string doubleZeroChar = "00";
                                                //try
                                                //{
                                                    if (pickANumber == "0" || pickANumber == "00")
                                                    {


                                                        switch (pickANumber)
                                                        {
                                                            case "00":
                                                                Console.WriteLine($"You selected 00");
                                                                BallDrops();
                                                                if (PickANumSelection() == 37)
                                                                {
                                                                    Console.WriteLine($"YOU WON ${amountWaged * 35}.00!");
                                                                    currentBankAmount = (amountWaged * 35) + currentBankAmount;
                                                                    Console.WriteLine($"You have ${currentBankAmount}.00");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Sorry you lost");
                                                                }
                                                                break;
                                                            case "0":
                                                                Console.WriteLine($"You selected Zero");
                                                                BallDrops();
                                                                if (PickANumSelection() == 0)
                                                                {
                                                                    Console.WriteLine($"YOU WON ${amountWaged * 35}.00!");
                                                                    currentBankAmount = (amountWaged * 35) + currentBankAmount;
                                                                    Console.WriteLine($"You have ${currentBankAmount}.00");
                                                                    player.AddMoney(ref currentBankAmount);
                                                                    player.Bank();
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Sorry you lost");
                                                                }
                                                                break;
                                                        }
                                                    }

                                                    else if (pickANumberConverted > 0 && pickANumberConverted < 37)
                                                    {
                                                        ballNumber = PickANumSelection();

                                                        try
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
                                                                    GameOver();
                                                                    rouletteConditional = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Sorry you lost");

                                                                }
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine($"That's not the correct format.  You typed {pickANumber}");
                                                            PickANUmber();
                                                        }
                                                    }
                                                    PlayAgainQuestion();
                                                //}
                                                //catch (Exception)
                                                //{

                                                //    Console.WriteLine($"That's not the correct format.  You typed {pickANumber}");

                                                //}
                                            }
                                            break;
                                        case 2:
                                            Red();
                                            void Red()
                                            {
                                                //RED CODE
                                            }
                                            break;
                                        case 3:
                                            Black();
                                            void Black()
                                            {
                                                //BLACK CODE
                                            }
                                            break;
                                        case 4:
                                            Even();
                                            void Even()
                                            {
                                                //Even CODE
                                            }
                                            break;
                                        case 5:
                                            Odd();
                                            void Odd()
                                            {
                                                //Odd CODE
                                            }
                                            break;
                                        case 6:
                                            Low();
                                            void Low()
                                            {
                                                //Low CODE
                                            }
                                            break;
                                        case 7:
                                            High();
                                            void High()
                                            {
                                                //High CODE
                                            }
                                            break;
                                        case 8:
                                            Dozens();
                                            void Dozens()
                                            {
                                                Console.WriteLine("Choose a Dozen:");
                                                Console.WriteLine("[1] 1 thru 12");
                                                Console.WriteLine("[2] 13 thru 24");
                                                Console.WriteLine("[3] 25 thru 36");
                                                string pickADozen;
                                                pickADozen = Console.ReadLine();
                                                if (pickADozen != "1" && pickADozen != "2")
                                                {
                                                    try
                                                    {
                                                        int convertPickANUmber = int.Parse(pickADozen.ToLower());
                                                        if (convertPickANUmber! > 0 && convertPickANUmber! < 37)
                                                        {
                                                            Console.WriteLine($"You selected {convertPickANUmber}");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"That's not a correct number from the selection.  You typed {convertPickANUmber}");
                                                            PickANUmber();
                                                        }

                                                    }
                                                    catch (Exception)
                                                    {

                                                        Console.WriteLine($"That's not the correct format.  You typed {pickADozen}");
                                                        PickANUmber();
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
                                                    }
                                                }
                                            }
                                            break;
                                    }
                                }
                                else if (betSelection == 15)
                                {
                                    Console.WriteLine("EASTER EGG");
                                }
                                else
                                {
                                    if (currentBankAmount - amountWaged <= 0)//amount - current 
                                    {
                                        rouletteConditional = false;
                                    }
                                }



                            }


                        }
                    }
                }
            }
        }
    }
}

//Programming Exercise 07
//Roulette
//C# Step by Step
//Playing Roulette is a very simple game. A roulette wheel has 38 bins. Thirty-six bins are numbered from
//1 to 36. The last two bins contain 0 and 00. The two zero bins are colored green. The others are colored
//randomly red and black, 18 of each color. As the wheel spins, a ball is dropped into the wheel. When the
//wheel stops spinning, the ball comes to rest in one bin. See Figure 1.
//Betting Betting is much more complicated. Bets are pictured in Figure 2. The following bets can win:
//1.Numbers: the number of the bin
//2. Evens/Odds: even or odd numbers
//3. Reds/Blacks: red or black colored numbers
//4. Lows/Highs: low(1 – 18) or high(19 – 38) numbers.
//5.Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36
//6. Columns: first, second, or third columns
//7. Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24
//8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26
//9.Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
//10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
//    Assignment You are to write a program that models a roulette wheel. The ball can fall randomly into
//one of 38 different bins. You are to calculate all the winning bets according to the bin the ball falls into.
//Use arrays to model this game. You should use two arrays to model the wheel (numbers and colors).
//You can use arrays as appropriate to determine the winning bets.
//As output, your program should print the winning bin to standard output, together with all the winning
//bets. For example, if the ball comes to rest in square 26, the winning Split bets could be 23/26, 26/27,
//26/29, and 25/26, while the winning Corner bets could be 22/23/25/26, 23/24/26/27, 25/26/28/29, and
//26/27/29/30.
//Grading There are ten bets in this exercise. Each bet carries ten points. You will receive 10 points for
//every bet implemented, for a total of 100 points.

//Write("[0]  Red\n" +
//"[1]  Black\n" +
//"[2]  Pick a Number-----------------(0, 00, or 1 thru 36)\n" +
//"[3]  Even--------------------------(2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36)\n" +
//"[4]  Odd---------------------------(1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, \n" +
//"[5]  Low---------------------------(1 thru 18)\n" +
//"[6]  High--------------------------(19 thru 36\n" +
//"[7]  Dozens Left-------------------(1 thru 12) (\n" +
//"[8]  Dozens Middle-----------------(13 thru 24)\n" +
//"[9]  Dozens Right------------------(25 thru 36)\n" +
//"[10] Bottom Column-----------------(1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34)\n" +
//"[11] Middle Column-----------------(2, 5, 8 11, 14, 17, 20, 23, 26, 29, 32, 35)\n" +
//"[12] Top Column--------------------(3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36)\n" +
//"[13] Street------------------------(1, 2, 3)\n" +
//"[14] Street------------------------(4, 5, 6)\n" +
//"[15] Street------------------------(7, 8, 9)\n" +
//"[16] Street------------------------(10, 11, 12)\n" +
//"[17] Street------------------------(13, 14, 15)\n" +
//"[18] Street------------------------(16, 17, 18)\n" +
//"[19] Street------------------------(19, 20, 21)\n" +
//"[20] Street------------------------(22, 23, 24)\n" +
//"[21] Street------------------------(25, 26, 27)\n" +
//"[22] Street------------------------(28, 29, 30)\n" +
//"[23] Street------------------------(31, 32, 33)\n" +
//"[24] Street------------------------(34, 35, 36)\n" +
//"[25] Six Numbers-------------------(1, 2, 3, 4, 5, 6)\n" +
//"[26] Six Numbers-------------------(6, 7, 8, 9, 10, 11, 12)\n" +
//"[27] Six Numbers-------------------(13, 14, 15, 16, 17, 18)\n" +
//"[28] Six Numbers-------------------(19, 20, 21, 22, 23, 24)\n" +
//"[29] Six Numbers-------------------(25, 26, 27, 28, 29, 30)\n" +
//"[30] Six Numbers-------------------(31, 32, 33, 34, 35, 36)\n" +





//"[31] Corners-----------------------(1, 2, 4, 5)\n" +
//"[32] Corners-----------------------(2, 3, 5, 6)\n" +
//"[33] Corners-----------------------(4, 5, 7, 8)\n" +
//"[34] Corners-----------------------(5, 6, 8, 9)\n" +
//"[35] Corners-----------------------(7, 8, 10, 11)\n" +
//"[36] Corners-----------------------(8, 9, 11, 12)\n" +
//"[37] Corners-----------------------(10, 11, 13, 14)\n" +
//"[38] Corners-----------------------(11, 12, 14, 15)\n" +
//"[39] Corners-----------------------(13, 14, 16, 17)\n" +
//"[40] Corners-----------------------(14, 15, 17, 18)\n" +
//"[41] Corners-----------------------(16, 17, 19, 20)\n" +
//"[42] Corners-----------------------(17, 18, 20, 21)\n" +
//"[43] Corners-----------------------(19, 20, 22, 23)\n" +
//"[44] Corners-----------------------(20, 21, 23, 24)\n" +
//"[45] Corners-----------------------(22, 23, 25, 26)\n" +
//"[46] Corners-----------------------(23, 24, 26, 27)\n" +
//"[47] Corners-----------------------(25, 26, 28, 29)\n" +
//"[48] Corners-----------------------(26, 27, 29, 30)\n" +
//"[49] Corners-----------------------(28, 29, 31, 32)\n" +
//"[50] Corners-----------------------(29, 30, 32, 33)\n" +
//"[51] Corners-----------------------(31, 32, 34, 35)\n" +
//"[52] Corners-----------------------(32, 33, 35, 36)\n");

//Console.Write("  ___________________________________________________________________________________________________________________ ");
//Console.Write(" /       |       |       |       |       |       |       |       |       |       |       |       |       |           |");
//Console.Write("|        |   3   |   6   |   9   |   12  |   15  |   18  |   21  |   24  |   27  |   30  |   33  |   36  |   Row 1   |");
//Console.Write("|   00   |_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|___________|");
//Console.Write("|        |       |       |       |       |       |       |       |       |       |       |       |       |           |");
//Console.Write("|________|   2   |   5   |   8   |   11  |   14  |   17  |   20  |   23  |   26  |   29  |   32  |   35  |   Row 2   |");
//Console.Write("|        |_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|___________|");
//Console.Write("|        |       |       |       |       |       |       |       |       |       |       |       |       |           |");
//Console.Write("|   0    |   1   |   4   |   7   |   10  |   13  |   16  |   19  |   22  |   25  |   28  |   31  |   34  |   Row 3   |");
//Console.Write("|        |_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|___________|");
//Console.Write(" \\_______|                               |                               |                               |");
//Console.Write("         |          DOZEN 1-12           |         DOZEN 13-24           |         DOZEN 25-36           | ");
//Console.Write("         |_______________________________|_______________________________|_______________________________|");
//Console.Write("         |                               |                               |                               |");
//Console.Write("         |      1-18     |     EVEN      |      RED      |     BLACK     |      ODD      |     19-36     |");
//Console.Write("         |_______________|_______________|_______________|_______________|_______________|_______________|");
