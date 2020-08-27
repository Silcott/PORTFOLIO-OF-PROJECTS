using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ProgEX08_Silcott
{
    class Program
    {
        //Main Program
        static void Main(string[] args)
        {
            //Make the screen size to Fullscreen
            WideScreenMethod();

            //Do/While loop so the player can play again
            do
            {
                //Call the Art display
                StartArt();

                //Computer guesses a number and the human tries to guess it
                //Set a random number
                Random randomNum = new Random();

                //Intro Text
                Console.WriteLine("Let's play James Silcott's - The Number Guessing Game!");
                Console.WriteLine();
                Console.WriteLine("First we need two numbers to guess between, like 0 and 100");

                //Find the min number of the guess
                Console.WriteLine("Give a MINIMUM number for the computer to guess:");
                int min1Number = Convert.ToInt32(Console.ReadLine());

                //Find the max number of the guess
                Console.WriteLine("Give a MAXIMUM number for the computer to guess:");
                int max1Number = Convert.ToInt32(Console.ReadLine());

                //Create a variable to store a random number from the min and max values fromt he user input
                int number = randomNum.Next(min1Number, max1Number);

                //Create a starting point by declaring variable for the guessed number
                int guessedNum = 0;

                //Start the number counter to see how many guesses it takes
                int countHuman = 0;

                //Show min and max user input results
                Console.WriteLine($"The computer has guessed a number between {min1Number} and {max1Number}");

                //While the random number doesn't equal the number the user guesses than do the following code
                while (number != guessedNum)
                {
                    //increment the count number
                    countHuman++;
                    Console.WriteLine($"Type a number between {min1Number} and {max1Number}: ");

                    //Assign the value of user input guessed number
                    guessedNum = Convert.ToInt32(Console.ReadLine());

                    //If the guess is less than the actual random number picked than dot he following code
                    if (guessedNum < number)
                    {
                        ThumbsUp();
                        Console.WriteLine("Too low, guess higher");
                    }

                    //Else if the guess is higher than the actual random number than do the folowing code
                    else if (guessedNum > number)
                    {
                        ThumbsDown();
                        Console.WriteLine("Too high, guess lower");
                    }

                    //Else the number is guessed
                    else
                    {
                        ThumbsUpMulti();
                        Console.WriteLine($"Correct, you guessed the number "
                            + $"in {countHuman} guesses");
                    }
                }

                //Break Point to start the computer guess game
                Console.WriteLine("Press any key to continu[e] . . . ");
                var readKey = Console.ReadLine().ToUpper();

                #region Easter
                if (readKey == "E")
                {
                    EasterEgg();
                }
                #endregion

                //Human guesses number and computer tries to guess it
                Console.WriteLine("Now let's have the computer try to guess!");

                //Find the min value
                Console.WriteLine("Give a MINIMUM number for the computer to guess between:");
                int min2Number = Convert.ToInt32(Console.ReadLine());

                //Find max value
                Console.WriteLine("Give a MAXIMUM number for the computer to guess between:");
                int max2Number = Convert.ToInt32(Console.ReadLine());

                //Get the actual number from the human
                Console.WriteLine($"What is the number for the computer to guess between {min2Number} and {max2Number}?");
                int numGiven = Convert.ToInt32(Console.ReadLine());

                //Intialize the counter to start the count of guess it takes for the computer
                int countComputer = 0;
                int guess = (max2Number + min2Number) / 2;
                Console.WriteLine($"Is the number: {guess}");

                //If the computer guesses the number right away show:
                if (numGiven == guess)
                {
                    ThumbsUpMulti();
                    Console.WriteLine($"Nice, the computer guessed the correct number: {numGiven} in 1 guess");
                }
                else
                {
                    //While the computer guess doesn't equal the humasns number do:
                    while (guess != numGiven)
                    {
                        //Increament the counter
                        countComputer++;

                        //If human number is more than the computer guess
                        if (numGiven > guess)
                        {
                            ThumbsUp();
                            Console.WriteLine("Too low, guess higher!");
                            min2Number = guess;
                            guess = (max2Number + min2Number) / 2;

                        }
                        //Else the human number is less than the computer guess
                        else if (numGiven < guess)
                        {
                            ThumbsDown();
                            Console.WriteLine("Too High, guess lower!");
                            max2Number = guess;
                            guess = (max2Number + min2Number) / 2;
                        }
                        //Else it equals
                        else
                        {
                            ThumbsUpMulti();
                            Console.WriteLine($"Correct, you guessed the number {numGiven}"
                                + $"in {countComputer} guesses");
                        }
                        //Show the guessed number
                        Console.WriteLine($"Is the number: {guess}");
                        //add 1 to the max value everytime the guess is wrong
                        max2Number = max2Number + 1;
                    }
                    
                    //Show the results
                    Console.WriteLine($"Nice, the computer guessed the correct number: {numGiven} in {countComputer} guesses");
                    Console.WriteLine($"You took {countHuman} and the computer took {countComputer} to guess");

                    //See if the human had less guesses
                    if (countHuman < countComputer)
                    {
                        ThumbsUpMulti();
                        Console.WriteLine("Nice, you win! You guess the number in less guesses than the computer");
                    }
                    //See if the computer had less guesses
                    else if (countHuman > countComputer)
                    {
                        Console.WriteLine("Sorry, the computer won. It guessed the number in less guesses than you");
                    }
                    //See if the human and computer guesses equal
                    else
                    {
                        ThumbsUp();
                        Console.WriteLine("TIE!  Wow, you and the computer guessed the number in the same amount of guesses");
                        ThumbsDown();
                    }
                }
            }
            //If the user says no they don't want to play again, then exit the program, else play again
            while (TryAgain() == true);
        }
        //Try again method to play again or game over
        static bool TryAgain()
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
        #region Art
        //Art - to make it bling
        static void StartArt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  __  .__            ");
            Console.WriteLine("_/  |_|  |__   ____  ");
            Console.WriteLine("\\   __\\  |  \\_/ __ \\ ");
            Console.WriteLine(" |  | |   Y  \\  ___/ ");
            Console.WriteLine(" |__| |___|  /\\___  >");
            Console.WriteLine("           \\/     \\/ ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                888                       ");
            Console.WriteLine("                                888                       ");
            Console.WriteLine("                                888                       ");
            Console.WriteLine("88888b.  888  888 88888b.d88b.  88888b.   .d88b.  888d888 ");
            Console.WriteLine("888 \"88b 888  888 888 \"888 \"88b 888 \"88b d8P  Y8b 888P\"");
            Console.WriteLine("888  888 888  888 888  888  888 888  888 88888888 888     ");
            Console.WriteLine("888  888 Y88b 888 888  888  888 888 d88P Y8b.     888     ");
            Console.WriteLine("888  888  \"Y88888 888  888  888 88888P\"   \"Y8888  888");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                             d8b                   ");
            Console.WriteLine("                                             Y8P                   ");
            Console.WriteLine("");
            Console.WriteLine(" .d88b.  888  888  .d88b.  .d8888b  .d8888b  888 88888b.   .d88b.  ");
            Console.WriteLine("d88P\"88b 888  888 d8P  Y8b 88K      88K      888 888 \"88b d88P\"88b");
            Console.WriteLine("888  888 888  888 88888888 \"Y8888b. \"Y8888b. 888 888  888 888  888 ");
            Console.WriteLine("Y88b 888 Y88b 888 Y8b.          X88      X88 888 888  888 Y88b 888 ");
            Console.WriteLine(" \"Y88888  \"Y88888  \"Y8888   88888P'  88888P' 888 888  888  \"Y88888 ");
            Console.WriteLine("     888                                                       888 ");
            Console.WriteLine("Y8b d88P                                                  Y8b d88P ");
            Console.WriteLine(" \"Y88P\"                                                    \"Y88P\"  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                       _________    _____   ____  ");
            Console.WriteLine("                      / ___\\__  \\  /     \\_/ __ \\               ");
            Console.WriteLine("                     / /_/  > __ \\|  Y Y  \\  ___/                           ");
            Console.WriteLine("                     \\___  (____  /__|_|  /\\___  >                        ");
            Console.WriteLine("                    /_____/     \\/      \\/     \\/                          ");
            Console.WriteLine("");
            //Art from http://patorjk.com/software/taag/#p=display&f=Weird&t=number%0A%0A%0A%0A 
            //and https://ascii.co.uk/art/guess
        }

        static void ThumbsUp()
        {
            Console.WriteLine("   _                 ");
            Console.WriteLine(" ( ((                ");
            Console.WriteLine("  \\ =\\             ");
            Console.WriteLine(" __\\_ `-\\          ");
            Console.WriteLine("(____))(  \\----     ");
            Console.WriteLine("(____)) _            ");
            Console.WriteLine("(____))              ");
            Console.WriteLine("(____))____/----     ");
            Console.WriteLine();
        }

        static void ThumbsDown()
        {
            Console.WriteLine("  ______");
            Console.WriteLine(" (( ____ \\-");
            Console.WriteLine(" (( _____");
            Console.WriteLine(" ((_____ ");
            Console.WriteLine(" ((____   ----");
            Console.WriteLine("      /  /");
            Console.WriteLine("     (_(( ");
            Console.WriteLine("");
        }

        static void ThumbsUpMulti()
        {
            Console.WriteLine("   _                   _                     _            ");
            Console.WriteLine(" ( ((                ( ((                  ( ((           ");
            Console.WriteLine("  \\ =\\                \\ =\\                  \\ =\\        ");
            Console.WriteLine(" __\\_ `-\\            __\\_ `-\\              __\\_ `-\\     ");
            Console.WriteLine("(____))(  \\----     (____))(  \\----       (____))(  \\----");
            Console.WriteLine("(____)) _           (____)) _             (____)) _       ");
            Console.WriteLine("(____))             (____))               (____))         ");
            Console.WriteLine("(____))____/----    (____))____/----      (____))____/----");
            Console.WriteLine();
        }

        #endregion

        #region Fullscreen
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

        #region Egg
        static void EasterEgg()
        {
            //Variables
            Random randomEgg = new Random();
            int minEggNum = randomEgg.Next(0, 999);
            int maxEggNum = randomEgg.Next(minEggNum, 1000);
            int cpuEggNum = randomEgg.Next(minEggNum, maxEggNum);

            //Used to find the middle of the random range and show this number
            int newMaxNumEgg = ((maxEggNum - minEggNum) / 2) + minEggNum;

            //Intialize the varaible and set to zero
            int counter = 0;

            //Intro and set up
            EEArt();
            Console.WriteLine("Welcome to the Easter Egg!");
            Console.WriteLine("Let's play High or Low");
            Console.WriteLine("");
            Console.WriteLine("The computer will generate two numbers, a minimum and maximum range");
            Console.WriteLine();
            Console.WriteLine($"First number is: {minEggNum}");
            Console.WriteLine($"Next number is: {maxEggNum}");

            //Rules
            Console.WriteLine("Alright here's the rules to the game:");
            Console.WriteLine("You need to use the UP or DOWN arrow keys");
            Console.WriteLine("UP Arrow means higher");
            Console.WriteLine("DOWN Arrow means lower");

            //Game of High and Low
            Console.WriteLine($"The computer has selected a number between {minEggNum} and {maxEggNum}");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadLine();
            EEArt();
            Console.WriteLine("Let's start you off in the middle");
            Console.WriteLine("Do you think it is HIGHER or LOWER than " + newMaxNumEgg);

            //While the computers guessed number is higher or lower
            while (cpuEggNum != keyResponse())
            {
                //Use a counter to show how many times it cycled through
                counter++;

                //Call the method to playt eh game
                keyResponse();

                //Use a counter to show how many times it cycled through
                counter++;

                //Change the min value to add 1 number so it constantly changes
                //minEggNum = minEggNum + 1;
                //maxEggNum = maxEggNum - 1;
            }

            //Method to play game
            int keyResponse()
            {
                //Used for debugging
                Console.WriteLine("the MIN number is: " + minEggNum);
                Console.WriteLine("the MAX number is: " + maxEggNum);
                Console.WriteLine("the middle number is: " + newMaxNumEgg);
                Console.WriteLine("the number to pick is: " + cpuEggNum);


                //Get the arrow key input 
                var key = Console.ReadKey().Key;

                //If statement on which arrow key is used
                //UP ARROW
                if (key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("You Selected: HIGHER");
                    //If the middle range number is LESS than the actual number
                    if (newMaxNumEgg < cpuEggNum)
                    {
                        ThumbsUp();
                        Console.WriteLine("Correct, it is higher!");
                        //Reset the MIN value to the middle range
                        minEggNum = newMaxNumEgg;
                        //reset the middle range to be another middle range of dividing the range again
                        newMaxNumEgg = ((maxEggNum - newMaxNumEgg) / 2) + minEggNum;
                    }
                    //If the middle range number is MORE than the actual number
                    else
                    {
                        Console.WriteLine("Wrong, it was lower");
                    }
                    Console.WriteLine("Do you think it is HIGHER or LOWER than " + newMaxNumEgg);

                    //return the new middle range number
                    return newMaxNumEgg;
                }
                //DOWN ARROW
                else
                {
                    Console.WriteLine("You Selected: LOWER");
                    //If the middle range number is MORE than the actual number
                    if (newMaxNumEgg > cpuEggNum)
                    {
                        ThumbsDown();
                        Console.WriteLine("Correct, it is lower!");
                        //Reset the MAX value to the middle range
                        maxEggNum = newMaxNumEgg;
                    }
                    else
                    {
                        Console.WriteLine("Wrong, it was higher");
                    }
                    //reset the middle range to be another middle range of dividing the range again
                    newMaxNumEgg = ((maxEggNum - minEggNum) / 2) + minEggNum;

                    Console.WriteLine("Do you think it is HIGHER or LOWER than " + newMaxNumEgg);

                    //return the new middle range number
                    return newMaxNumEgg;
                }
            }
            //If the guess is the first guess
            if (counter == 0)
            {
                Console.WriteLine($"THAT'S AMAZING! You guessed it in {counter+1} guesses!");
            }
            else
            {
                //Show how many guesses it took
                Console.WriteLine($"Congrats you guessed it in {counter+1} guesses!");
            }
            //This will allow the user to play the Easter Egg again
            Console.WriteLine("Press any key to continu[e] . . . ");
            var readKey = Console.ReadLine().ToUpper();

            if (readKey == "E")
            {
                EasterEgg();
            }
        }

        //Array of methods to chagne the color methods
        static void EEArt()
        {
            Action[] methods = new Action[5];
            methods[0] = BackColorBlack;
            methods[1] = BackColorYellow;
            methods[2] = BackColorRed;
            methods[3] = BackColorGreen;
            methods[4] = BackColorWhite;

            //Pick a random array index
            void RandomColor()
            {
                Random randomColor = new Random();
                var randomPicker = randomColor.Next(0, 4);
                var newPicker = methods[randomPicker];
                newPicker();
            }

            //Methods to change the background colors
            //Background Yellow
            void BackColorYellow()
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            //Background Black
            void BackColorBlack()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
            //Background Green
            void BackColorGreen()
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;

            }
            //Background Red
            void BackColorRed()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

            }
            //Background White
            void BackColorWhite()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

            }
            ChangeColor();

            //Egg Art
            void ChangeColor()
            {
                //Set counter to cycle through the while loop on the specified amount of times
                int counter = 0;
                //Do first
                do
                {
                    //Increment the counter
                    counter++;

                    Console.Clear();
                    BackColorBlack();
                    Console.Write(" YOU'VE FOUND A\n");
                    BackColorBlack();
                    Console.Write("    ");
                    RandomColor();
                    Console.Write(".-\" -.\n");
                    BackColorBlack();
                    Console.Write("  ");
                    RandomColor();
                    Console.Write(".'=^=^='.\n");
                    BackColorBlack();
                    Console.Write(" ");
                    RandomColor();
                    Console.Write("/=^=^=^=^=\\\n");
                    BackColorBlack();
                    RandomColor();
                    Console.Write(":^= EASTER=^;\n");
                    BackColorBlack();
                    RandomColor();
                    Console.Write("|^   EGG   ^|\n");
                    BackColorBlack();
                    RandomColor();
                    Console.Write(":^=^=^=^=^=^:\n");
                    BackColorBlack();
                    Console.Write(" ");
                    RandomColor();
                    Console.Write("\\=^=^=^=^=/\n");
                    BackColorBlack();
                    Console.Write("  ");
                    RandomColor();
                    Console.Write("`.=^=^=.'\n");
                    BackColorBlack();
                    Console.Write("    ");
                    RandomColor();
                    Console.Write("`~~~`\n");
                    BackColorBlack();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    //art from https://www.oocities.org/spunk1111/easter.htm

                    //Timer to repeat the methods
                    Thread.Sleep(20);
                } while (counter < 100);
            }
        }
        #endregion
    }
}



//Programming Exercise 08
//Guess My Number Game (Bisection Algorithm)
//C# Step by Step
//Bisection Algorithm This exercise implements three programs implementing the bisection algorithm.
//The bisection method is an efficient way of finding a particular value in a sorted list. It takes a sorted list
//and a value, and finds the value in the list. First, it checks the “middle” element in the list. There are
//three possibilities: the value could match the “middle” element, the value could be higher than the ‘middle”
//element of the list, or the value could be lower than the “middle” element. If the value matches, the function
//returns. If it’s higher, the algorithm (recursively) calls itself with the top half of the list. If it’s lower, the
//algorithm calls itself with the bottom half of the list.
//For example, here is the output of a function call, the searched value being 7 and the sorted list being
//[1 2 3 4 5 6 7 8 9 10].
//>> int value = 7;
//>> int[] list = { 1,2,3,4,5,6,7,8,9,10};
//>> bisection_search(value, list);
//<< value is higher than 5
////the ‘‘middle’’ value is 5.5, but we are doing integer division
////the list is now set to {6,7,8,9,10}
//>> bisection_search(value, list);
//<< value is lower than 8
////the middle value is 8
////the list is now set to {6,7}
//>> bisection_search(value, list);
//<< value is higher than 6
////the ‘‘middle’’ value is 6.5, but we are doing integer division
////the list is now set to {7}
//>> bisection_search(value, list);
//<< value is equal to 7
////the middle value is 7
////the list is now set to {7}
//<< the value searched for, 7, has been found
//The bisection algorithm is nice because it is guaranteed to find an answer (or return if there is no answer)
//in logaroithmic time of the size of the list. Only 10 repetitions of the function are necessary to find a result in
//a list of 1024 items, and only 20 repetitions to find a result in a list of 1,000,000 items. Mathematically, the
//time complexity of the bisection algorithm is log2
//(n), where n is the length of the sorted list to be searched.
//Implement bisection algorithm: 70 points Write a console application implementing the bisection algorithm. As the initial list, use an integer array from 1 to 10, like this: int[] list = 1,2,3,4,5,6,7,8,9,10;.
//As input, have the user select a number from 1 to 10. Have the application print each step. Use appropriate
//exception handling to guard against invalid input from the user.
//Guess my number, human plays: 80 points Implement a version of Guess My Number, where the
//computer randomly choses a number between 1 and 1000, and the human guesses the number. In this case,
//Page 1, Revised on June 14, 2018 by Charles Carter
//the program should print a hint with each repetition, either <Your guess was too high>, <Your guess
//was too low>, or <You guessed the number>. The human should then input the next guess. Run this
//multiple times and compute the average number of repetitions necessary for you to guess the number.
//What is the maximum number of guesses you need to guess a number between 1 and 1000? Recall that
//log2 1000 = 9.966 and that 210 = 1024.
//Guess my number, computer plays: 100 points Implement a version of Guess My Number, where
//the human choses a number between 1 and 100, and the computer guesses the number. The human should
//be able to tell the computer whether the computer’s guess was too high, too low, or was the correct answer.
//Run this multiple times and compute the average number of repetitions necessary for the computer to guess
//the number. Have the program print the value, the guess, and the list on each repetition.
//Is the human as good as the computer in finding the number?
