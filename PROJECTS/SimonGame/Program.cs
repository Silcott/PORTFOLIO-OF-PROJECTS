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
                @"|             "); Colors.Yellow(); Console.Write(@";;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"                        "); Colors.Yellow(); Console.Write(@" ;;;;;;;;;;;;;;;;;;;;;;"); Colors.White(); Console.Write(@"           |" + '\n' +
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

    }
    public static class Update
    {

    }
    public static class Draw
    {
        public static void ArtArray()
        {


        }
    }
    public static class Game
    {
        enum Direction
        {
            Up = 1,
            Right = 2,
            Down = 3,
            Left = 4,
        }
        static readonly Random random = new Random();
        static readonly TimeSpan buttonPress = TimeSpan.FromMilliseconds(500);
        static readonly TimeSpan animationDelay = TimeSpan.FromMilliseconds(200);
        static int score = 0;
        static readonly List<Direction> pattern = new List<Direction>();

        public static void Main(string[] args)
        {
            bool CursorVisible = GetConsoleCursorVisible();

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
            Action[] displayArtArray = new Action[5];
            displayArtArray[0] = Content.DrawSimonPlain;
            displayArtArray[1] = Content.DrawSimonYellow;
            displayArtArray[2] = Content.DrawSimonRed;
            displayArtArray[3] = Content.DrawSimonGreen;
            displayArtArray[4] = Content.DrawSimonBlue;

            Random randomColor = new Random();
            var randomPicker = randomColor.Next(0, 4);
            var newPicker = displayArtArray[randomPicker];

            void Clear()
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine();
                Console.WriteLine("    Simon");
                Console.WriteLine();
                int left = Console.CursorLeft;
                int top = Console.CursorTop;

                Console.SetCursorPosition(left, top);
            }
            void AnimateCurrentPattern()
            {
                for (int i = 0; i < pattern.Count; i++)
                {
                    Clear();
                    newPicker();
                    Thread.Sleep(buttonPress);
                    Clear();
                    newPicker();
                    Thread.Sleep(animationDelay);
                }
                Clear();
                newPicker();
            }

            //newPicker();

            //Content.DrawSimonPlain();
            //Content.DrawSimonYellow();
            //Content.DrawSimonRed();
            //Content.DrawSimonGreen();
            //Content.DrawSimonBlue();
            try
            {
                Console.CursorVisible = false;
                Clear();
                newPicker();

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
                        newPicker();
                        Thread.Sleep(buttonPress);
                        Clear();
                        newPicker();
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

    }
}