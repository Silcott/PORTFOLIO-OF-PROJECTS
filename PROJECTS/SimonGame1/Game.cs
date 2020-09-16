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
            displayArtArray[0]= Content.DrawSimonPlain;
            displayArtArray[1] = Content.DrawSimonYellow;
            displayArtArray[2] = Content.DrawSimonRed;
            displayArtArray[3] = Content.DrawSimonGreen;
            displayArtArray[4] = Content.DrawSimonBlue;
        }
    }
    public static class Draw
    {

    }
    class Game
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
