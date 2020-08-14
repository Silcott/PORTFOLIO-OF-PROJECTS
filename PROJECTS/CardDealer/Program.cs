using System;
using System.Text;

namespace Cards_console
{
    class Program
    {
        static void Main(string[] args)
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

        }

        private static string Solution1(int[] Cards)
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

        private static string Solution2(int[] Cards)
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

        private static int[] InitializeDeck()
        {
            int[] Cards = new int[52]; //declare array
            for (int i = 0; i < 52; i++) //initialize array
                Cards[i] = i;
            //DEBUGGING
            //for (int i = 0; i < 52; i++) Console.Write(PrintCard(i, ", "));
            return Cards;
        }

        private static string PrintHand(int deck)
        {
            string[] hand = { " ~~North~~ ", " ~~East~~ ", " ~~South~~ ", " ~~West~~ ", };
            return hand[deck % 4];
        }

        private static string PrintCard(int i, string cr = "")
        {
            string[] value = {"two","three","four","five","six","seven","eight","nine",
                "ten","Jack","Queen","King","Ace"};
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
            return $"{value[i % 13]} of {suit[i / 13]}{cr}";
        }
    }
}