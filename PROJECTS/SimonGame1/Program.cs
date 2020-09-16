using System;
using System.Collections.Generic;
using System.Threading;

namespace SimonGame1
{
    public static class Colors
    {
        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Red;

        }
        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Green;

        }
        public static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
	enum Direction
	{
		Up = 1,
		Right = 2,
		Down = 3,
		Left = 4,
	}

	#region Ascii

	static class Ascii
	{
		public static readonly string[] Renders = new string[]
		{
			// 0
			@"           ╔══════╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚╗    ╔╝        " + '\n' +
			@"    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
			@"    ║   ╚═══╗╚══╝╔═══╝   ║ " + '\n' +
			@"    ║       ║    ║       ║ " + '\n' +
			@"    ║   ╔═══╝╔══╗╚═══╗   ║ " + '\n' +
			@"    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
			@"           ╔╝    ╚╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚══════╝        ",
			// 1
			@"           ╔══════╗        " + '\n' +
			@"           ║██████║        " + '\n' +
			@"           ╚╗████╔╝        " + '\n' +
			@"    ╔═══╗   ╚╗██╔╝   ╔═══╗ " + '\n' +
			@"    ║   ╚═══╗╚══╝╔═══╝   ║ " + '\n' +
			@"    ║       ║    ║       ║ " + '\n' +
			@"    ║   ╔═══╝╔══╗╚═══╗   ║ " + '\n' +
			@"    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
			@"           ╔╝    ╚╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚══════╝        ",
			// 2
			@"           ╔══════╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚╗    ╔╝        " + '\n' +
			@"    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
			@"    ║   ╚═══╗╚══╝╔═══╝███║ " + '\n' +
			@"    ║       ║    ║███████║ " + '\n' +
			@"    ║   ╔═══╝╔══╗╚═══╗███║ " + '\n' +
			@"    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
			@"           ╔╝    ╚╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚══════╝        ",
			// 3
			@"           ╔══════╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚╗    ╔╝        " + '\n' +
			@"    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
			@"    ║   ╚═══╗╚══╝╔═══╝   ║ " + '\n' +
			@"    ║       ║    ║       ║ " + '\n' +
			@"    ║   ╔═══╝╔══╗╚═══╗   ║ " + '\n' +
			@"    ╚═══╝   ╔╝██╚╗   ╚═══╝ " + '\n' +
			@"           ╔╝████╚╗        " + '\n' +
			@"           ║██████║        " + '\n' +
			@"           ╚══════╝        ",
			// 4
			@"           ╔══════╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚╗    ╔╝        " + '\n' +
			@"    ╔═══╗   ╚╗  ╔╝   ╔═══╗ " + '\n' +
			@"    ║███╚═══╗╚══╝╔═══╝   ║ " + '\n' +
			@"    ║███████║    ║       ║ " + '\n' +
			@"    ║███╔═══╝╔══╗╚═══╗   ║ " + '\n' +
			@"    ╚═══╝   ╔╝  ╚╗   ╚═══╝ " + '\n' +
			@"           ╔╝    ╚╗        " + '\n' +
			@"           ║      ║        " + '\n' +
			@"           ╚══════╝        ",


		};



	}

	#endregion

	static readonly bool CursorVisible = GetConsoleCursorVisible();
	static readonly Random random = new Random();
	static readonly TimeSpan buttonPress = TimeSpan.FromMilliseconds(500);
	static readonly TimeSpan animationDelay = TimeSpan.FromMilliseconds(200);
	static int score = 0;
	static readonly List<Direction> pattern = new List<Direction>();

	static void Main()
	{
		try
		{
			Console.CursorVisible = false;
			Clear();
			Render(Ascii.Renders[default]);
			while (true)
			{
				Thread.Sleep(buttonPress);
				pattern.Add((Direction)random.Next(1, 5));
				AnimateCurrentPattern();
				for (int i = 0; i < pattern.Count; i++)
				{
				GetInput:
					switch (Console.ReadKey(true).Key)
					{
						case ConsoleKey.UpArrow:
							if (pattern[i] != Direction.Up) goto GameOver;
							break;
						case ConsoleKey.RightArrow:
							if (pattern[i] != Direction.Right) goto GameOver;
							break;
						case ConsoleKey.DownArrow:
							if (pattern[i] != Direction.Down) goto GameOver;
							break;
						case ConsoleKey.LeftArrow:
							if (pattern[i] != Direction.Left) goto GameOver;
							break;
						case ConsoleKey.Escape:
							Console.Clear();
							Console.Write("Simon was closed.");
							return;
						default: goto GetInput;
					}
					score++;
					Clear();
					Render(Ascii.Renders[(int)pattern[i]]);
					Thread.Sleep(buttonPress);
					Clear();
					Render(Ascii.Renders[default]);
				}
			}
		GameOver:
			Console.Clear();
			Console.Write("Game Over. Score: " + score + ".");
		}
		finally
		{
			Console.CursorVisible = CursorVisible;
		}
	}

	static void Clear()
	{
		Console.SetCursorPosition(0, 0);
		Console.WriteLine();
		Console.WriteLine("    Simon");
		Console.WriteLine();
		int left = Console.CursorLeft;
		int top = Console.CursorTop;
		Render(Ascii.Renders[default]);
		Console.SetCursorPosition(left, top);
	}

	static void AnimateCurrentPattern()
	{
		for (int i = 0; i < pattern.Count; i++)
		{
			Clear();
			Render(Ascii.Renders[(int)pattern[i]]);
			Thread.Sleep(buttonPress);
			Clear();
			Render(Ascii.Renders[default]);
			Thread.Sleep(animationDelay);
		}
		Clear();
		Render(Ascii.Renders[default]);
	}

	static void Render(string @string)
	{
		int x = Console.CursorLeft;
		int y = Console.CursorTop;
		foreach (char c in @string)
		{
			if (c is '\n')
			{
				Console.SetCursorPosition(x, ++y);
			}
			else
			{
				Console.Write(c);
			}
		}
	}

	static bool GetConsoleCursorVisible()
	{
		try
		{
			return Console.CursorVisible;
		}
		catch (PlatformNotSupportedException)
		{
			// Non-Windows OS. Assume true.
			return true;
		}
	}
}
        public static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        public static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    public static class Content
    {
        public static void DrawSimonPlain()
        {
            Console.Write(
                @"+----------------------------------------------------------------------------------------------+" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                   ;;;;;;;;;;;;;;;;;;;;;;;;;;                                 |" + '\n' +
                @"|                              ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                           |" + '\n' +
                @"|                          ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                      |" + '\n' +
                @"|                    ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                 |" + '\n' +
                @"|                ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;              |" + '\n' +
                @"|             ;;;;;;;;;;;;;;;;;;;;;;;                        ;;;;;;;;;;;;;;;;;;;;;;            |" + '\n' +
                @"|           ;;;;;;;;;;;;;;;;;;;;;                               ;;;;;;;;;;;;;;;;;;;;;          |" + '\n' +
                @"|         ;;;;;;;;;;;;;;;;;;;;;                                   ;;;;;;;;;;;;;;;;;;;;         |" + '\n' +
                @"|        ooooooooooooooooooo                                        ####################       |" + '\n' +
                @"|       oooooooooooooooooo                                            ###################      |" + '\n' +
                @"|      oooooooooooooooooo                                              ###################     |" + '\n' +
                @"|      ooooooooooooooooo                                                 #################     |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██╗███╗   ███╗ ██████╗ ███╗   ██╗     #################    |" + '\n' +
                @"|     oooooooooooooooo      ██╔════╝██║████╗ ████║██╔═══██╗████╗  ██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██║██╔████╔██║██║   ██║██╔██╗ ██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ╚════██║██║██║╚██╔╝██║██║   ██║██║╚██╗██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ███████║██║██║ ╚═╝ ██║╚██████╔╝██║ ╚████║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝     #################    |" + '\n' +
                @"|      oooooooooooooooo                                                  #################     |" + '\n' +
                @"|      oooooooooooooooooo                                              ##################      |" + '\n' +
                @"|       ooooooooooooooooooo                                           ##################       |" + '\n' +
                @"|         ooooooooooooooooooo                                       ###################        |" + '\n' +
                @"|          oooooooooooooooooooo                                    ###################         |" + '\n' +
                @"|           oooooooooooooooooooooo                              #####################          |" + '\n' +
                @"|             ::::::::::::::::::::::::                      :::::::::::::::::::::::            |" + '\n' +
                @"|                :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::               |" + '\n' +
                @"|                    :::::::::::::::::::::::::::::::::::::::::::::::::::::::                   |" + '\n' +
                @"|                          :::::::::::::::::::::::::::::::::::::::::::                         |" + '\n' +
                @"|                              :::::::::::::::::::::::::::::::::::                             |" + '\n' +
                @"|                                   ::::::::::::::::::::::::::                                 |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"+----------------------------------------------------------------------------------------------+");
        }
        public static void DrawSimonYellow()
        {
            Console.Write(
                @"+----------------------------------------------------------------------------------------------+" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                   "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                                 | " + '\n' +
                @"|                              "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                           |" + '\n' +
                @"|                          "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                      |" + '\n' +
                @"|                    "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                 |" + '\n' +
                @"|                "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"              |" + '\n' +
                @"|             "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;");Colors.White();Console.Write(@"                        ");Colors.Yellow();Console.Write(@" ;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"           |" + '\n' +
                @"|           "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                               "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"          |" + '\n' +
                @"|         "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                                   "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"         |" + '\n' +
                @"|        ooooooooooooooooooo                                        ####################       |" + '\n' +
                @"|       oooooooooooooooooo                                            ###################      |" + '\n' +
                @"|      oooooooooooooooooo                                              ###################     |" + '\n' +
                @"|      ooooooooooooooooo                                                 #################     |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██╗███╗   ███╗ ██████╗ ███╗   ██╗     #################    |" + '\n' +
                @"|     oooooooooooooooo      ██╔════╝██║████╗ ████║██╔═══██╗████╗  ██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██║██╔████╔██║██║   ██║██╔██╗ ██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ╚════██║██║██║╚██╔╝██║██║   ██║██║╚██╗██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ███████║██║██║ ╚═╝ ██║╚██████╔╝██║ ╚████║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝     #################    |" + '\n' +
                @"|      oooooooooooooooo                                                  #################     |" + '\n' +
                @"|      oooooooooooooooooo                                              ##################      |" + '\n' +
                @"|       ooooooooooooooooooo                                           ##################       |" + '\n' +
                @"|         ooooooooooooooooooo                                       ###################        |" + '\n' +
                @"|          oooooooooooooooooooo                                    ###################         |" + '\n' +
                @"|           oooooooooooooooooooooo                              #####################          |" + '\n' +
                @"|             ::::::::::::::::::::::::                      :::::::::::::::::::::::            |" + '\n' +
                @"|                :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::               |" + '\n' +
                @"|                    :::::::::::::::::::::::::::::::::::::::::::::::::::::::                   |" + '\n' +
                @"|                          :::::::::::::::::::::::::::::::::::::::::::                         |" + '\n' +
                @"|                              :::::::::::::::::::::::::::::::::::                             |" + '\n' +
                @"|                                   ::::::::::::::::::::::::::                                 |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"+----------------------------------------------------------------------------------------------+");
        }
        public static void DrawSimonRed()
        {
            Console.Write(
                @"+----------------------------------------------------------------------------------------------+" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                   ;;;;;;;;;;;;;;;;;;;;;;;;;;                                 |" + '\n' +
                @"|                              ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                           |" + '\n' +
                @"|                          ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                      |" + '\n' +
                @"|                    ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                 |" + '\n' +
                @"|                ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;              |" + '\n' +
                @"|             ;;;;;;;;;;;;;;;;;;;;;;;                        ;;;;;;;;;;;;;;;;;;;;;;            |" + '\n' +
                @"|           ;;;;;;;;;;;;;;;;;;;;;                               ;;;;;;;;;;;;;;;;;;;;;          |" + '\n' +
                @"|         ;;;;;;;;;;;;;;;;;;;;;                                   ;;;;;;;;;;;;;;;;;;;;         |" + '\n' +
                @"|        "); Colors.Red(); Console.Write(@"ooooooooooooooooooo"); Colors.White(); Console.Write(@"                                        ####################       |" + '\n' +
                @"|       "); Colors.Red(); Console.Write(@"oooooooooooooooooo"); Colors.White(); Console.Write(@"                                            ###################      |" + '\n' +
                @"|      "); Colors.Red(); Console.Write(@"oooooooooooooooooo"); Colors.White(); Console.Write(@"                                              ###################     |" + '\n' +
                @"|      "); Colors.Red(); Console.Write(@"ooooooooooooooooo"); Colors.White(); Console.Write(@"                                                 #################     |" + '\n' +
                @"|     "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"      ███████╗██╗███╗   ███╗ ██████╗ ███╗   ██╗     #################    |" + '\n' +
                @"|     "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"      ██╔════╝██║████╗ ████║██╔═══██╗████╗  ██║      ################    |" + '\n' +
                @"|     "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"      ███████╗██║██╔████╔██║██║   ██║██╔██╗ ██║      ################    |" + '\n' +
                @"|     "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"      ╚════██║██║██║╚██╔╝██║██║   ██║██║╚██╗██║      ################    |" + '\n' +
                @"|     "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"      ███████║██║██║ ╚═╝ ██║╚██████╔╝██║ ╚████║      ################    |" + '\n' +
                @"|     "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"      ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝     #################    |" + '\n' +
                @"|      "); Colors.Red(); Console.Write(@"oooooooooooooooo"); Colors.White(); Console.Write(@"                                                  #################     |" + '\n' +
                @"|      "); Colors.Red(); Console.Write(@"oooooooooooooooooo"); Colors.White(); Console.Write(@"                                              ##################      |" + '\n' +
                @"|       "); Colors.Red(); Console.Write(@"ooooooooooooooooooo"); Colors.White(); Console.Write(@"                                           ##################       |" + '\n' +
                @"|         "); Colors.Red(); Console.Write(@"ooooooooooooooooooo"); Colors.White(); Console.Write(@"                                       ###################        |" + '\n' +
                @"|          "); Colors.Red(); Console.Write(@"oooooooooooooooooooo"); Colors.White(); Console.Write(@"                                    ###################         |" + '\n' +
                @"|           "); Colors.Red(); Console.Write(@"oooooooooooooooooooooo"); Colors.White(); Console.Write(@"                              #####################          |" + '\n' +
                @"|             ::::::::::::::::::::::::                      :::::::::::::::::::::::            |" + '\n' +
                @"|                :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::               |" + '\n' +
                @"|                    :::::::::::::::::::::::::::::::::::::::::::::::::::::::                   |" + '\n' +
                @"|                          :::::::::::::::::::::::::::::::::::::::::::                         |" + '\n' +
                @"|                              :::::::::::::::::::::::::::::::::::                             |" + '\n' +
                @"|                                   ::::::::::::::::::::::::::                                 |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"+----------------------------------------------------------------------------------------------+");
        }
        public static void DrawSimonGreen()
        {
            Console.Write(
                @"+----------------------------------------------------------------------------------------------+" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                   ;;;;;;;;;;;;;;;;;;;;;;;;;;                                 |" + '\n' +
                @"|                              ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                           |" + '\n' +
                @"|                          ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                      |" + '\n' +
                @"|                    ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                 |" + '\n' +
                @"|                ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;              |" + '\n' +
                @"|             ;;;;;;;;;;;;;;;;;;;;;;;                        ;;;;;;;;;;;;;;;;;;;;;;            |" + '\n' +
                @"|           ;;;;;;;;;;;;;;;;;;;;;                               ;;;;;;;;;;;;;;;;;;;;;          |" + '\n' +
                @"|         ;;;;;;;;;;;;;;;;;;;;;                                   ;;;;;;;;;;;;;;;;;;;;         |" + '\n' +
                @"|        ooooooooooooooooooo                                        ####################       |" + '\n' +
                @"|       oooooooooooooooooo                                            ###################      |" + '\n' +
                @"|      oooooooooooooooooo                                              ###################     |" + '\n' +
                @"|      ooooooooooooooooo                                                 #################     |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██╗███╗   ███╗ ██████╗ ███╗   ██╗     #################    |" + '\n' +
                @"|     oooooooooooooooo      ██╔════╝██║████╗ ████║██╔═══██╗████╗  ██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██║██╔████╔██║██║   ██║██╔██╗ ██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ╚════██║██║██║╚██╔╝██║██║   ██║██║╚██╗██║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ███████║██║██║ ╚═╝ ██║╚██████╔╝██║ ╚████║      ################    |" + '\n' +
                @"|     oooooooooooooooo      ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝     #################    |" + '\n' +
                @"|      oooooooooooooooo                                                  #################     |" + '\n' +
                @"|      oooooooooooooooooo                                              ##################      |" + '\n' +
                @"|       ooooooooooooooooooo                                           ##################       |" + '\n' +
                @"|         ooooooooooooooooooo                                       ###################        |" + '\n' +
                @"|          oooooooooooooooooooo                                    ###################         |" + '\n' +
                @"|           oooooooooooooooooooooo                              #####################          |" + '\n' +
                @"|             "); Colors.Green(); Console.Write(@"::::::::::::::::::::::::"); Colors.White(); Console.Write(@"                      "); Colors.Green(); Console.Write(@":::::::::::::::::::::::"); Colors.White(); Console.Write(@"            |" + '\n' +
                @"|                "); Colors.Green(); Console.Write(@":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::"); Colors.White(); Console.Write(@"               |" + '\n' +
                @"|                    "); Colors.Green(); Console.Write(@":::::::::::::::::::::::::::::::::::::::::::::::::::::::"); Colors.White(); Console.Write(@"                   |" + '\n' +
                @"|                          "); Colors.Green(); Console.Write(@":::::::::::::::::::::::::::::::::::::::::::"); Colors.White(); Console.Write(@"                         |" + '\n' +
                @"|                              "); Colors.Green(); Console.Write(@":::::::::::::::::::::::::::::::::::"); Colors.White(); Console.Write(@"                             |" + '\n' +
                @"|                                   "); Colors.Green(); Console.Write(@"::::::::::::::::::::::::::"); Colors.White(); Console.Write(@"                                 |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"+----------------------------------------------------------------------------------------------+");
        }
        public static void DrawSimonBlue()
        {
            Console.Write(
                @"+----------------------------------------------------------------------------------------------+" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                   ;;;;;;;;;;;;;;;;;;;;;;;;;;                                 |" + '\n' +
                @"|                              ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                           |" + '\n' +
                @"|                          ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                      |" + '\n' +
                @"|                    ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;                 |" + '\n' +
                @"|                ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;              |" + '\n' +
                @"|             ;;;;;;;;;;;;;;;;;;;;;;;                        ;;;;;;;;;;;;;;;;;;;;;;            |" + '\n' +
                @"|           ;;;;;;;;;;;;;;;;;;;;;                               ;;;;;;;;;;;;;;;;;;;;;          |" + '\n' +
                @"|         ;;;;;;;;;;;;;;;;;;;;;                                   ;;;;;;;;;;;;;;;;;;;;         |" + '\n' +
                @"|        ooooooooooooooooooo                                        "); Colors.Blue(); Console.Write(@"####################"); Colors.White(); Console.Write(@"       |" + '\n' +
                @"|       oooooooooooooooooo                                            "); Colors.Blue(); Console.Write(@"###################"); Colors.White(); Console.Write(@"      |" + '\n' +
                @"|      oooooooooooooooooo                                              "); Colors.Blue(); Console.Write(@"###################"); Colors.White(); Console.Write(@"     |" + '\n' +
                @"|      ooooooooooooooooo                                                 "); Colors.Blue(); Console.Write(@"#################"); Colors.White(); Console.Write(@"     |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██╗███╗   ███╗ ██████╗ ███╗   ██╗     "); Colors.Blue(); Console.Write(@"#################"); Colors.White(); Console.Write(@"    |" + '\n' +
                @"|     oooooooooooooooo      ██╔════╝██║████╗ ████║██╔═══██╗████╗  ██║      "); Colors.Blue(); Console.Write(@"################"); Colors.White(); Console.Write(@"    |" + '\n' +
                @"|     oooooooooooooooo      ███████╗██║██╔████╔██║██║   ██║██╔██╗ ██║      "); Colors.Blue(); Console.Write(@"################"); Colors.White(); Console.Write(@"    |" + '\n' +
                @"|     oooooooooooooooo      ╚════██║██║██║╚██╔╝██║██║   ██║██║╚██╗██║      "); Colors.Blue(); Console.Write(@"################"); Colors.White(); Console.Write(@"    |" + '\n' +
                @"|     oooooooooooooooo      ███████║██║██║ ╚═╝ ██║╚██████╔╝██║ ╚████║      "); Colors.Blue(); Console.Write(@"################"); Colors.White(); Console.Write(@"    |" + '\n' +
                @"|     oooooooooooooooo      ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝     "); Colors.Blue(); Console.Write(@"#################"); Colors.White(); Console.Write(@"    |" + '\n' +
                @"|      oooooooooooooooo                                                  "); Colors.Blue(); Console.Write(@"#################"); Colors.White(); Console.Write(@"     |" + '\n' +
                @"|      oooooooooooooooooo                                              "); Colors.Blue(); Console.Write(@"##################"); Colors.White(); Console.Write(@"      |" + '\n' +
                @"|       ooooooooooooooooooo                                           "); Colors.Blue(); Console.Write(@"##################"); Colors.White(); Console.Write(@"       |" + '\n' +
                @"|         ooooooooooooooooooo                                       "); Colors.Blue(); Console.Write(@"###################"); Colors.White(); Console.Write(@"        |" + '\n' +
                @"|          oooooooooooooooooooo                                    "); Colors.Blue(); Console.Write(@"###################"); Colors.White(); Console.Write(@"         |" + '\n' +
                @"|           oooooooooooooooooooooo                              "); Colors.Blue(); Console.Write(@"#####################"); Colors.White(); Console.Write(@"          |" + '\n' +
                @"|             ::::::::::::::::::::::::                      :::::::::::::::::::::::            |" + '\n' +
                @"|                :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::               |" + '\n' +
                @"|                    :::::::::::::::::::::::::::::::::::::::::::::::::::::::                   |" + '\n' +
                @"|                          :::::::::::::::::::::::::::::::::::::::::::                         |" + '\n' +
                @"|                              :::::::::::::::::::::::::::::::::::                             |" + '\n' +
                @"|                                   ::::::::::::::::::::::::::                                 |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"|                                                                                              |" + '\n' +
                @"+----------------------------------------------------------------------------------------------+");
        }
    }
    public static class Load
    {
        public static void ArtArray() 
        {
            Action[] displayArtArray = new Action[5];
            displayArtArray[0] = Content.DrawSimonPlain;
            displayArtArray[1] = Content.DrawSimonYellow;
            displayArtArray[2] = Content.DrawSimonRed;
            displayArtArray[3] = Content.DrawSimonGreen;
            displayArtArray[4] = Content.DrawSimonBlue;
        }
    }
    public static class Draw
    {

    }
    public static class Game
    {
        public static void Main(string[] args)
        {
            Content.DrawSimonPlain();
            Content.DrawSimonYellow();
            Content.DrawSimonRed();
            Content.DrawSimonGreen();
            Content.DrawSimonBlue();
        }

    }
}
