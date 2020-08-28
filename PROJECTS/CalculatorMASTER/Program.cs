using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;

namespace CalculatorMASTER
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseNumber = Menu();
            switch (caseNumber)
            {
                case 1:
                    CalculateCircumference();
                    break;
                case 2:
                    FactorialCalc();
                    break;
                case 3:
                    AvgTenScores();
                    break;
                case 4:
                    HeronFormula();
                    break;
                case 5:
                    CountDown();
                    break;
                case 6:
                    IntegerAdding();
                    break;
                case 7:
                    Reciprocal();
                    break;
                case 8:
                    Classes();
                    break;
                case 9:
                    Arrays();
                    break;
                case 10:
                    CardsShuffle1();
                    break;
                case 11:
                    CardsShuffle2();
                    break;
                case 12:
                    Inheritance();
                    break;


                default:
                    Console.WriteLine("Thats not a selection, try again");
                    break;
            }
        }

        static int Menu()
        {
            Console.WriteLine("Welcome to the Master Calculator");
            Console.WriteLine("Choose a Option:");
            Console.WriteLine("[ 1] Circumference ------------- (Mathematical Formulas & Exception Handling)");
            Console.WriteLine("[ 2] Factorial");
            Console.WriteLine("[ 3] AvgTenScores -------------- (Recursive Methods)");
            Console.WriteLine("[ 4] Herons Formula & Quadratic Equation");
            Console.WriteLine("[ 5] Count Down ---------------- (While Loop)");
            Console.WriteLine("[ 6] Adding Ten Integers ------- (Recursion)");
            Console.WriteLine("[ 7] Reciprocal ---------------- (Exception Handling)");
            Console.WriteLine("[ 8] Classes");
            Console.WriteLine("[ 9] Arrays");
            Console.WriteLine("[10] Card Shuffle: 1");
            Console.WriteLine("[11] Card Shuffle: 2");
            Console.WriteLine("[12] Inheritance");
            Console.WriteLine("[13] ");

            int selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        }

        //=======================1.CIRCUMFERENCE=======================\\
        private static void CalculateCircumference()
        {
            double r, per_cir;
            double PI = 3.14;

            try
            {
                Console.WriteLine("Input the radius of the circle : ");
                r = Convert.ToDouble(Console.ReadLine());
                per_cir = 2 * PI * r;
                var area = PI * r * r;
                if (r < 0)
                    throw new Exception("Your number has to be a positive number");
                if (double.IsInfinity(per_cir))
                    throw new DivideByZeroException();
                Console.WriteLine($"The circumferenece is {per_cir}");
                Console.WriteLine($"The area is {area}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                CalculateCircumference();
            }
            catch (DivideByZeroException fex)
            {
                Console.WriteLine(fex.Message);
                CalculateCircumference();
            }
            catch (Exception fex)
            {
                Console.WriteLine(fex.Message);
                CalculateCircumference();
            }
        }
        //=======================2.FACTORIAL=======================\\
        private static void FactorialCalc()
        {
            Console.WriteLine("Please Enter a Number:");

            //read number from user    
            int number = Convert.ToInt32(Console.ReadLine());

            //invoke the static method    
            double factorial = Factorial(number);

            //print the factorial result    
            Console.WriteLine("factorial of " + number + " = " + factorial.ToString());

            static double Factorial(int number)
            {
                if (number == 0)
                    return 1;
                return number * Factorial(number - 1);//Recursive call    

            }
        }
        //=======================3.AVERAGE TEN NUMBERS=======================\\
        private static void AvgTenScores()
        {
            Console.WriteLine("\nPart 1 , sum 10 numbers. ");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers. ");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3 , average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");


            Console.WriteLine("\nPart 4, average non−predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");

            static char ConvertNumericToLetterGrade(double grade)
            {
                char letterGrade = ' ';
                if (grade > 89)
                    letterGrade = 'A';
                else
                    if (grade > 79)
                    letterGrade = 'B';
                else
                        if (grade > 69)
                    letterGrade = 'C';
                else
                            if (grade > 59)
                    letterGrade = 'D';
                else
                                if (grade <= 59)
                    letterGrade = 'F';
                return letterGrade;
            }
            static double AvgAnyInts(int sum, int count)
            {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return AvgAnyInts(sum, count);
                else
                    return sum / 10.0;
            }

            static double AvgUnkInts(int sum, int count, int numScores)
            {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return AvgUnkInts(sum, count, numScores);
                else
                    return sum / 10.0;
            }

            static double AvgTenInts(int sum, int count)
            {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return SumTenInts(sum, count);
                else
                    return sum / 10.0;
            }
            static int SumTenInts(int sum, int count)
            {
                Console.Write("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                count++;
                if (count < 10)
                    return SumTenInts(sum, count);
                else
                    return sum;
            }
        }
        //=======================4.HERON FORMULA=======================\\

        private static void HeronFormula()
        {

            var tryAgain = true;

            while (tryAgain == true)
            {
                // Part 1
                // Partially worked example
                Console.WriteLine("\nPart 1, circumference and area of a circle.");
                Console.Write("Enter an integer for the radius: ");
                string strradius = Console.ReadLine();
                int intradius = int.Parse(strradius);
                double circumference = 2 * Math.PI * intradius;
                double area = Math.PI * Math.Pow(intradius, 2);
                double volume = (4 / 3 * Math.PI * Math.Pow(intradius, 3)) / (2);

                Console.WriteLine($"The circumference is {circumference}");

                // Implementation for area here
                Console.WriteLine($"The area is: {area}");

                // Part 2
                Console.WriteLine("\nPart 2, volume of a hemisphere.");

                // Implementation here
                Console.WriteLine($"The volume is: {volume}");

                Console.WriteLine("\nNow let's do Heron's Formula, so I need the " +
                                  "side lengths of a triangle:");

                Console.WriteLine("What's the first length?");
                string strside1 = Console.ReadLine();
                double intside1 = double.Parse(strside1);

                Console.WriteLine("What's the second length?");
                string strside2 = Console.ReadLine();
                double intside2 = double.Parse(strside2);

                Console.WriteLine("What's the third length?");
                string strside3 = Console.ReadLine();
                double intside3 = double.Parse(strside3);

                double halfCircumference = (intside1 + intside2 + intside3) / 2;
                double triangleAreaBeforeSqRt = (halfCircumference * (halfCircumference - intside1) *
                                                 (halfCircumference - intside2) *
                                                 (halfCircumference - intside3));
                double triangleArea = Math.Sqrt(triangleAreaBeforeSqRt);
                Console.WriteLine($"Half of the triangle circumference is {halfCircumference}");

                // Part 3
                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

                // Implementation here
                Console.WriteLine($"The area is: {triangleArea}");

                // Part 4
                Console.WriteLine("\nPart 4, solving a quadratic equation.");
                Console.WriteLine("In order to solve a quadratic equation, we need to know some coefficients," +
                                  "\nsuch as the values for a, b, c");
                Console.WriteLine("First, what is the value of a:");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second, what is the value of b:");
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Finally, what is the value of c:");
                var c = Convert.ToInt32(Console.ReadLine());

                var d = b * b - 4 * a * c;
                double x1, x2;
                if (d == 0)
                {
                    Console.Write("Both roots are equal.\n");
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    Console.Write($"First  Root Root1= {x1}\n");
                    Console.Write($"Second Root Root2= {x2}\n");
                }
                else if (d > 0)
                {
                    Console.Write("Both roots are real and diff-2\n");

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Console.Write($"First  Root Root1= {x1}\n");
                    Console.Write($"Second Root root2= {x2}\n");
                }
                else
                    Console.Write("Root are imaginary;\nNo Solution. \n\n");

                Console.WriteLine("Would you like to try again? [Y] or [N]");
                var tryAgainResponse = Console.ReadLine();
                var upperCaseResponse = tryAgainResponse.ToUpper();
                if (upperCaseResponse == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for wanting to continue!");
                    tryAgain = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                }
            }
        }
        //=======================5.COUNT DOWN LOOP=======================\\
        private static void CountDown()
        {
            Console.WriteLine("Choose a number to count down from");
            int numberChosen = Convert.ToInt32(Console.ReadLine());

            int i = numberChosen;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        //=======================6. INTEGER ADDING=======================\\
        private static void IntegerAdding()
        {
            Console.Write("This is C Sharp quiz 2.");
            Console.Write("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"the sum is {sum}");
        }
        private static int GetSums(int start, int end, int sum)
        {
            Console.WriteLine($"The sum of {sum} and {start} is {sum + start}");
            if (end <= 0)
                return sum;
            else
                return GetSums(start + sum, --end, ++sum);
        }
        //=======================7. RECIPROCAL=======================\\
        private static void Reciprocal()
        {
            int number;
            Console.WriteLine("To calculate the reciprocal of an integer, enter a positive integer: ");
            string stringnumber = Console.ReadLine();
            try
            {
                number = int.Parse(stringnumber);
                if (number < 0)
                    throw new Exception("Your number has to be a positive number");
                double reciprocal = (double)1.0 / number;
                if (double.IsInfinity(reciprocal))
                    throw new DivideByZeroException();
                Console.WriteLine($"The reciprocal is {reciprocal}");
            }
            catch (FormatException fex)
            {

                Console.WriteLine(fex.Message);
                Reciprocal();
            }
            catch (DivideByZeroException fex)
            {

                Console.WriteLine(fex.Message);
                Reciprocal();
            }
            catch (Exception fex)
            {

                Console.WriteLine(fex.Message);
                Reciprocal();
            }
        }
        //=======================8. CLASSES=======================\\

        private static void Classes()
        {
            Console.WriteLine("This is C Charp quiz 4");
            Firearm shotgun = new Firearm();
            shotgun.fire("shotgun", "boom");
            Firearm rifle = new Firearm();
            rifle.fire("rifle", "Bang");
            Firearm pistol = new Firearm();
            pistol.fire("pistol", "Pop");
        }
        class Firearm
        {
            public void fire(string name, string noise)
            {
                Console.WriteLine($"I am a {name} and I go {noise}.");
            }
        }
        //=======================9. ARRAYS=======================\\
        private static void Arrays()
        {
            Console.WriteLine("This is Quiz 05");
            string quiz = "I think, therefore I am";
            Console.WriteLine($"The quiz string is [{quiz}].");
            string[] quizArray = quiz.Split(" ");
            int lengthOfArray = quizArray.Length;
            Console.WriteLine($"Length of the string array is {lengthOfArray}");

            //One way
            for (int i = 1; i < lengthOfArray; i++)
            {
                Console.WriteLine($"{i}. {quizArray[lengthOfArray - i]}");
            }

            //A different way
            for (int i = lengthOfArray - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i} {quizArray[i]}");
            }
        }

        //=======================10. CARD SHUFFLE 1=======================\\

        private static void CardsShuffle1()
        {
            Console.WriteLine("This is Cards-console");
            Console.WriteLine("\n initialize new deck=======================");
            int[] Cards = InitializeDeck();
            string Hands = "";

            Console.Write("\nEnter [1] for solution 1, [2] for solution 2: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\n deal from new deck, solution 1. =======================");
                Hands = Solution1(Cards);
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n deal from new deck, solution 2. =======================");
                Hands = Solution2(Cards);
            }
            else
                Hands = "ERROR, exiting";

            Console.WriteLine();
            Console.WriteLine(Hands);
            Console.WriteLine("all done=======================");



            static string Solution1(int[] Cards)
            {
                //SOLUTION 1    
                int newCard;
                int deck = 0;
                StringBuilder shuffled = new StringBuilder();
                Random randomCard = new Random();
                while (deck < 52)
                {
                    if (deck % 4 == 0)
                        shuffled.Append($"{deck / 4 + 1}");
                    shuffled.Append(PrintHand(deck)); //i.e., North, East, etc.
                    do //randomly choose a card from the deck
                    {
                        newCard = randomCard.Next(52);
                    } while (Cards[newCard] < 0);
                    shuffled.Append(PrintCard(newCard, "\n")); //i.e., Queen of Hearts, etc.
                    Cards[newCard] = -1; //mark card as dealt
                    deck++;
                }
                //Console.WriteLine(shuffled);
                return shuffled.ToString();
            }

            static string Solution2(int[] Cards)
            {
                //SOLUTION 2    
                //DEBUGGING
                //Console.WriteLine("Before randamization"); foreach(int c in Cards) Console.Write($"{c} ");
                StringBuilder shuffled = new StringBuilder();
                Random r = new Random();
                for (int i = 0; i < Cards.Length; i++)
                {
                    int newI = r.Next(52);
                    int temp = Cards[i];
                    Cards[i] = Cards[newI];
                    Cards[newI] = temp;
                }
                //DEBUGGING
                //Console.WriteLine("After randamization"); foreach(int c in Cards) Console.Write($"{c} ");
                for (int i = 0; i < 52; i++)
                {
                    if (i % 4 == 0) shuffled.Append($"{(i / 4) + 1}");
                    shuffled.Append(PrintHand(i)); //i.e., North, East, etc.
                    shuffled.Append(PrintCard(Cards[i], "\n")); //i.e., Queen of Hearts, etc.
                }
                return shuffled.ToString();
            }

            static int[] InitializeDeck()
            {
                int[] Cards = new int[52]; //declare array
                for (int i = 0; i < 52; i++) //initialize array
                    Cards[i] = i;
                //DEBUGGING
                //for (int i = 0; i < 52; i++) Console.Write(PrintCard(i, ", "));
                return Cards;
            }

            static string PrintHand(int deck)
            {
                string[] hand = { " ~~North~~ ", " ~~East~~ ", " ~~South~~ ", " ~~West~~ ", };
                return hand[deck % 4];
            }

            static string PrintCard(int i, string cr = "")
            {
                string[] value = {"two","three","four","five","six","seven","eight","nine",
                "ten","Jack","Queen","King","Ace"};
                string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
                return $"{value[i % 13]} of {suit[i / 13]}{cr}";
            }
        }
        //=======================11. CARD SHUFFLE 2=======================\\
        private static void CardsShuffle2()
        {
            string[] deck = {
                "two of Clubs", "three of Clubs", "four of Clubs", "five of Clubs",
                "six of Clubs", "seven of Clubs", "eight of Clubs", "nine of Clubs",
                "ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
                "Ace of Clubs", "two of Diamonds", "three of Diamonds",
                "four of Diamonds", "five of Diamonds", "six of Diamonds",
                "seven of Diamonds", "eight of Diamonds", "nine of Diamonds",
                "ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds",
                "King of Diamonds", "Ace of Diamonds", "two of Hearts", "three of Hearts",
                "four of Hearts", "five of Hearts", "six of Hearts", "seven of Hearts",
                "eight of Hearts", "nine of Hearts", "ten of Hearts", "Jack of Hearts",
                "Queen of Hearts", "King of Hearts", "Ace of Hearts", "two of Spades",
                "three of Spades", "four of Spades", "five of Spades", "six of Spades",
                "seven of Spades", "eight of Spades", "nine of Spades", "ten of Spades",
                "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Spades"
            };

            string[] playerDirection = {
                "North",
                "East",
                "South",
                "West"
            };
            void Shuffle()
            {
                var random = new Random();
                for (int i = 0; i < deck.Length; i++)
                {
                    int r = random.Next(i, deck.Length);
                    var temp = deck[i];
                    deck[i] = deck[r];
                    deck[r] = temp;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Shuffle();
                Console.WriteLine(playerDirection[i] + " was dealt:");
                Console.WriteLine(string.Join(", \n", deck.Skip(i % 13).Take(12)));
                Console.WriteLine(deck[i], ", \n");
                Console.WriteLine();
            }
            Console.WriteLine("All Done!");
            Console.ReadLine();
        }
        //=======================12. INHERITANCE=======================\\
        private static void Inheritance()
        {
            static void doWork()
            {
                Firearm2 myFirearm = new Firearm2();
                myFirearm.typeOfFirearm();
                myFirearm.actionOfFirearm("shoot things");

                Shotgun myShotgun = new Shotgun();
                myShotgun.typeOfFirearm();
                myShotgun.actionOfFirearm("go Boom");

                Rifle myRifle = new Rifle();
                myRifle.typeOfFirearm();
                myRifle.actionOfFirearm("go Bang");

                Pistol myPistol = new Pistol();
                myPistol.typeOfFirearm();
                myPistol.actionOfFirearm("go Pop");
            }
            Console.WriteLine("This is Quiz 6");
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            Console.ReadLine();
        }
        class Firearm2
        {
            public virtual void typeOfFirearm()
            {
                Console.Write($"I am a firearm ");
            }
            public void actionOfFirearm(string action)
            {
                Console.Write($"and I {action}\n");
            }
        }
        class Shotgun : Firearm2
        {
            public override void typeOfFirearm()
            {
                Console.Write("I am a Shotgun ");
            }
        }
        class Rifle : Firearm2
        {
            public override void typeOfFirearm()
            {
                Console.Write("I am a Rifle ");
            }
        }
        class Pistol : Firearm2
        {
            public override void typeOfFirearm()
            {
                Console.Write("I am a Pistol ");
            }
        }
        //=======================13. =======================\\

        //=======================13. =======================\\

        //=======================13. =======================\\

        //=======================13. =======================\\




















    }


}






