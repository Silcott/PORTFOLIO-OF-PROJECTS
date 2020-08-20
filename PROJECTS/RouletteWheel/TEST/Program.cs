using System;

namespace RouletteWheel
{
	class MainClass
	{
		// ----------- Methods -------------
		static void Write(string str)
		{
			Console.Write(str);
		}
		static void Write(char chr)
		{
			Console.Write(chr);
		}
		static void Write(int intr)
		{
			Console.Write(intr);
		}

		static string Conv()
		{
			string temp = Console.ReadLine();
			return temp;
		}

		static void SkipLines(int howMany)
		{
			do
			{
				Console.WriteLine();
				howMany--;

			} while (howMany > 0);
		}

		static int GetRandomNumber(Random rnd)
		{
			int randNumb = rnd.Next(1, 1);
			// Random number between 1 & 36

			return randNumb;
		}

		static int IntWin(int gamble, int randNumb)
		{
			if (gamble == randNumb)
			{
				Console.WriteLine("The roulette is rolling... \nIt stops on the " + randNumb + ".\nYou win, bet multiply by 5 !");
				return 5;
			}

			Console.WriteLine("The roulette is rolling... \nIt stops on the " + randNumb + ".\nYou lost, bet equals to 0 !");
			return 0;
		}

		static int ColorWin(int randNumb, int[] array)
		{
			foreach (int num in array)
			{
				if (num == randNumb)
				{
					Console.WriteLine("The roulette is rolling so fast !\nIt stops right on your color.\nCongrats, you win : bet multiply by 2");
					return 2;
				}
			}
			Console.WriteLine("You lost, it isn't the right color.\nToo bad : bet equals to 0.");
			return 0;
		}

		// ------------ Variables -------------
		static int[] red_nums = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };

		static int[] black_nums = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };

		static Random rand = new Random();
		static int gamble;

		// --------------- Class ---------------
		public class Sold
		{
			private int sold;

			public Sold()
			{
				sold = 100;
			}

			public void ShowSold()
			{
				Console.WriteLine("Sold : " + sold + "$");
			}

			public void Add(int bet)
			{
				sold += bet;
			}

			public void Sub(ref int bet)
			{
				if ((sold - bet) < 0)
				{
					bet = sold;
					Console.WriteLine("Bet set to " + bet + ".");
				}
				sold -= bet;
			}
			public bool CheckForGameOver()
			{
				if (sold <= 0)
				{
					return true;
				}
				return false;
			}
		}

		public static void Main(string[] args)
		{
			Sold player = new Sold();

			Write("Hello and welcome to my roulette game.\nHope you enjoy it :)");

			SkipLines(3);

			Write("You start the game with 100$.\nYou can bet on a number or on a color.\nBet on color will multiply your bet by 2 where a number bet will multiply it by 5.\nTo bet, just write a number between 1 & 36 or red or black.\nGood luck and have fun :)\n");

			SkipLines(2);

			while (true)
			{
				try
				{
					SkipLines(1);
					player.ShowSold();

					Write("Bet ? ");
					gamble = Convert.ToInt32(Conv());

				}
				catch (Exception)
				{
					Write("You have to gamble so your bet is 10.\n");
					gamble = 10;

				}

				player.Sub(ref gamble);
				int randomNumber = GetRandomNumber(rand);
				int mult = 0;

				Write("On what ? ");
				string write = Conv().ToLower();

				if (write.Equals("red"))
				{
					mult = ColorWin(randomNumber, red_nums);

				}
				else if (write.Equals("black"))
				{
					mult = ColorWin(randomNumber, black_nums);

				}
				else
				{
					try
					{
						int bet = Convert.ToInt32(write);
						mult = IntWin(bet, randomNumber);

					}
					catch (Exception)
					{
						Write("Wrong input, lost your bet.");

					}
				}

				player.Add(gamble * mult);

				if (player.CheckForGameOver()) goto defeat;
			}

		defeat:
			SkipLines(2);
			Write("You lost, try again an other time :D");
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