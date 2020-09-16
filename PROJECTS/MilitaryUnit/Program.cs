using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Timers;

namespace MasterClasses
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

    //Class for Repeat Function - used for the text spaces and dividing the screen
    #region CLASS: CharExtensions - Repeat Function
    //Class was created to use the Repeat with spaces to center the text
    public static class CharExtensions
    {
        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }
    }
    #endregion
    public static class ASCII_Art
    {
        public static int consoleWidth = Console.WindowWidth;
        public static int dividedWidth = consoleWidth / 2;
        public static string spaces = ' '.Repeat(dividedWidth);
        //Text Color Red
        public static void TextColorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        //Text Color Gray
        public static void TextColorGray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        //Background Black
        public static void BackColorBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        //Background Blue
        public static void BackColorBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        //Background Red
        public static void BackColorRed()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        //Background White
        public static void BackColorWhite()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        public static void ASCIIFlagArt()
        {
            //ASCII American Flag
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            TextColorGray();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            Console.Write("|* * * * * * * * * * ");
            BackColorRed();
            TextColorRed();
            Console.Write("OOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorBlue();
            TextColorGray();
            Console.Write("| * * * * * * * * *  ");
            TextColorGray();
            BackColorWhite();
            Console.Write(":::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorWhite();
            TextColorGray();
            Console.Write("|:::::::::::::::::::::::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorWhite();
            TextColorGray();
            Console.Write("|:::::::::::::::::::::::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorWhite();
            TextColorGray();
            Console.Write("|:::::::::::::::::::::::::::::::::::::::::::::|\n");
            BackColorBlack();
            Console.Write(spaces.Remove(0, 18));
            BackColorRed();
            TextColorRed();
            Console.Write("|OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO|\n");
            Console.ResetColor();
        }

        public static void BigTankArt()
        {
            //this sets varibales so I can divide the screen in half by pixels to center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((spaces.Remove(0, 18) + "                                                     _..----.._       "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                                    ]_.--._____[      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                                  ___|'--'__..|--._      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                              __               \"\"\"    ;            :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                            ()_ \"\"\"\"---...__.'\"\"!\":  / ___       :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                               \"\"\"-- - ...__\\]..__] | /    [0]      :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                          \"\"\"!--./ / \"\"\"        :      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                   __  ...._____;\"\"'.__________..--..:_       "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                  /  !\"''''''!'''''''''' | '''' / ' ' ' ' \"--..__  __..      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                 /  /.--.    |          |  .'          \' ' '.\"\"--.{'.       "));
            Console.WriteLine((spaces.Remove(0, 18) + "             _...__            >=7 //.-.:    |          |.'             \\ ._.__  ' '\"\"'.      "));
            Console.WriteLine((spaces.Remove(0, 18) + "          .-' /    \"\"\"\"----..../ \"\">==7-.....:______    |                \\| |  \"\";.;-\" > \\       "));
            Console.WriteLine((spaces.Remove(0, 18) + "          \"\"\"\";           __..\".--\"/\"\"\"\"\"----....\"\"\"\"\"----.....H_______\\_!....'----\"\"\"\"]     "));
            Console.WriteLine((spaces.Remove(0, 18) + "        _..---|._ __..--\"\"       _!.-=_.            \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"                   ; \"\"\"       "));
            Console.WriteLine((spaces.Remove(0, 18) + "       /   .-\"; -.'--...___     .\" .-\"\"; '; \"\" - \"\" - ...^..__...-v.^ ___,  ,__v.__..--^\"--\"\"-v.^v,     "));
            Console.WriteLine((spaces.Remove(0, 18) + "      ;   ;   |'.         \"\"\" -/ ./; ; ;\\P.        ; ; \"\"\"\"____; ;.--\"\"\"\"// '\"\"<,      "));
            Console.WriteLine((spaces.Remove(0, 18) + "      ;   ;   | 1            ;  ;  '.: .'  ;<   ___.-'._.'------\"\"\"\"\"\"____'..'.--\"\"\"; ; '  o '; "));
            Console.WriteLine((spaces.Remove(0, 18) + "      '.   \\__:/__           ;  ;--\"\"()_   ;'  /___ .-\" ____-- - \"\"\"\"\"\"\" __.._ __._   '>.,  ,/;      "));
            Console.WriteLine((spaces.Remove(0, 18) + "        \\   \\    /\"\"\" < --...__; '_.-' /; \"\"; ;.'.'  \"-..'    \" -.      / \"/    `__. '.   \"-- - \";      "));
            Console.WriteLine((spaces.Remove(0, 18) + "         '.  'v ; ;     ;;    \\  \\ .'  \\ ; ////    _.-\" \"-._   ;    : ;   .-'__ '. ;   .^\".'     "));
            Console.WriteLine((spaces.Remove(0, 18) + "           '.  '; '.   .'/     '. `-.__.' /;;;   .o__.---.__o. ;    : ;   '\"\";;\"\"' ;v^\".^ "));
            Console.WriteLine((spaces.Remove(0, 18) + "             '-. '-.___.'<__v.^,v'.  '-.-' ;|:   '    :      ` ;v^v^'.'.    .;'.__/_..-'      "));
            Console.WriteLine((spaces.Remove(0, 18) + "                '-...__.___...---\"\"'-.   '-'.;\\     'WW\\     .'_____..>.\" ^ \"-\"\"\"\"\"\"\"\"     "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                      '--..__ '\"._..'  '\"-;;\"\"\"       "));
            Console.WriteLine((spaces.Remove(0, 18) + "                                             \"\"\"-- - '\"\"\"\"\"\"     "));
            Console.WriteLine();
            Console.ResetColor();

        }
    }
    public static class TimerClass
    {
        //Start up screen with a timer
        public static Timer timer = new Timer(450);
        public static int i = 16;
    }
    public static class ASCII_Art_Animated
    {
        public static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Create a list of strings
            List<string[]> TankArtShooting = new List<string[]>()
            { 
                //Expolsion 1
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "  __                                           \n",
                DivideScreen.spaces.Remove(0, 0) + "|\"\"\"\\-=                                        \n",
                DivideScreen.spaces.Remove(0, 0) + "(____)                                         \n",
                },
                //Expolsion 2
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "   _.                                          \n",
                DivideScreen.spaces.Remove(0, 0) + " |\"\"\"\\-=                                       \n",
                DivideScreen.spaces.Remove(0, 0) + " (____)                                        \n",
                },
                //Expolsion 3
                new string[]
                {
               DivideScreen.spaces.Remove(0, 0) + "                                               \n",
               DivideScreen.spaces.Remove(0, 0) + "                                               \n",
               DivideScreen.spaces.Remove(0, 0) + "    ,'                                         \n",
               DivideScreen.spaces.Remove(0, 0) + "  |\"\"\"\\-=                                      \n",
               DivideScreen.spaces.Remove(0, 0) + "  (____)                                       \n",
                },
                //Expolsion 4
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "     /_                                        \n",
                DivideScreen.spaces.Remove(0, 0) + "   |\"\"\"\\-=                                     \n",
                DivideScreen.spaces.Remove(0, 0) + "   (____)                                      \n",
                },
                //Expolsion 5
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "     |-._                                      \n",
                DivideScreen.spaces.Remove(0, 0) + "    |\"\"\"\\-=                                    \n",
                DivideScreen.spaces.Remove(0, 0) + "    (____)                                     \n",
                },
                //Expolsion 1
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "     \\;\":-                                     \n",
                DivideScreen.spaces.Remove(0, 0) + "     |\"\"\"\\-=                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "     (____)                                    \n",
                },
                //Expolsion 6
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "                                               \n",
                DivideScreen.spaces.Remove(0, 0) + "      -;\":-                                    \n",
                DivideScreen.spaces.Remove(0, 0) + "      \\| |                                     \n",
                DivideScreen.spaces.Remove(0, 0) + "      |\"\"\"\\-=                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "      (____)                                   \n",
                },
                //Expolsion 7
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         | ;-                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-=                                \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)                                 \n",
                },
                //Expolsion 8
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         |'+                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-=                                \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)                                 \n",
                },
                //Expolsion 9
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         ^-^     __,-.                         \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|    ( .`-')                        \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-= (_(_, _)                        \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)   `--'                          \n",
                },
                //Expolsion 10
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         ^-^     __,-.                         \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|    ( .`-')_.o                     \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-= (_(_, _)                        \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)   `--'                          \n",
                },
                //Expolsion 11
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         ^-^     ..,-.      _.--\"\"\"\"o          \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|    : .`-';_.-\"                    \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-=:. (.,.)                        \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)   `:-'                          \n",
                },
                //Expolsion 12
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         ^-^     .. .       _.--\"\"\"\"--.        \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|    : . : ; . \"             \"-.    \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-=:. :.,.;                    `.  \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)   `.:'                        o \n",
                },
                //Expolsion 13
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         ^-^                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\"\\-=                                \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)                                _\n",
                },
                //Expolsion 14
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         `-'                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\" -=                                 \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)                                _\n",
                },
                //Expolsion 15
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         `-'                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"\" =                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)                                _\n",
                },
                //Expolsion 16
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "        _.-._                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "         `-'                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        \\|_|                                   \n",
                DivideScreen.spaces.Remove(0, 0) + "        |\"\"o\\                                  \n",
                DivideScreen.spaces.Remove(0, 0) + "        (____)                                _\n",
                }
            };
            //This reverses the array since the timer counts down throught the indexes
            TankArtShooting.Reverse();
            //Create a list of strings
            List<string[]> TNTfinal = new List<string[]>()
            { 
            //Expolsion 1
            new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "       (  \n",
                DivideScreen.spaces.Remove(0, 0) + "       )  \n",
                DivideScreen.spaces.Remove(0, 0) + "      (   \n",
                DivideScreen.spaces.Remove(0, 0) + "      )\n",
                DivideScreen.spaces.Remove(0, 0) + "     (\n",
                DivideScreen.spaces.Remove(0, 0) + "    .-`-.\n",
                DivideScreen.spaces.Remove(0, 0) + "    :   :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :TNT:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :___:\n"
                },
            //Expolsion 1
            new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "       )  \n",
                DivideScreen.spaces.Remove(0, 0) + "      (   \n",
                DivideScreen.spaces.Remove(0, 0) + "      )\n",
                DivideScreen.spaces.Remove(0, 0) + "     (\n",
                DivideScreen.spaces.Remove(0, 0) + "    .-`-.\n",
                DivideScreen.spaces.Remove(0, 0) + "    :   :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :TNT:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :___:\n"
                },
            //Expolsion 1
            new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "      (   \n",
                DivideScreen.spaces.Remove(0, 0) + "      )\n",
                DivideScreen.spaces.Remove(0, 0) + "     (\n",
                DivideScreen.spaces.Remove(0, 0) + "    .-`-.\n",
                DivideScreen.spaces.Remove(0, 0) + "    :   :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :TNT:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :___:\n"
                },
            //Expolsion 1
            new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "      )\n",
                DivideScreen.spaces.Remove(0, 0) + "     (\n",
                DivideScreen.spaces.Remove(0, 0) + "    .-`-.\n",
                DivideScreen.spaces.Remove(0, 0) + "    :   :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :TNT:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :___:\n"
                },
            //Expolsion 1
            new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "      )\n",
                DivideScreen.spaces.Remove(0, 0) + "     (\n",
                DivideScreen.spaces.Remove(0, 0) + "    .-`-.\n",
                DivideScreen.spaces.Remove(0, 0) + "    :   :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :TNT:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :___:\n"
                },
                //Explosion 2
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "    \\|/\n",
                DivideScreen.spaces.Remove(0, 0) + "   - o -\n",
                DivideScreen.spaces.Remove(0, 0) + "    /-`-.\n",
                DivideScreen.spaces.Remove(0, 0) + "    :   :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :TNT:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :___:\n"
                },
                //Explosion 3
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "    .---.\n",
                DivideScreen.spaces.Remove(0, 0) + "    : | :\n",
                DivideScreen.spaces.Remove(0, 0) + "    :-o-:\n",
                DivideScreen.spaces.Remove(0, 0) + "    :_|_:\n"
                },
                //Explosion 4
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "    .---.\n",
                DivideScreen.spaces.Remove(0, 0) + "    (\\|/)\n",
                DivideScreen.spaces.Remove(0, 0) + "    --0--\n",
                DivideScreen.spaces.Remove(0, 0) + "    (/|\\)\n"
                },
                //Explosion 5
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "   '.\\|/.'\n",
                DivideScreen.spaces.Remove(0, 0) + "   (\\   /)\n",
                DivideScreen.spaces.Remove(0, 0) + "   - -O- -\n",
                DivideScreen.spaces.Remove(0, 0) + "   (/   \\)\n",
                DivideScreen.spaces.Remove(0, 0) + "   ,'/|\'.\n"
                },
                //Explosion 6
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "'.  \\ | /  ,'\n",
                DivideScreen.spaces.Remove(0, 0) + "  `. `.' ,'\n",
                DivideScreen.spaces.Remove(0, 0) + " ( .`.|,' .)\n",
                DivideScreen.spaces.Remove(0, 0) + " - ~ -0- ~ -\n",
                DivideScreen.spaces.Remove(0, 0) + " (\n"
                },
                //Explosion 7
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + "         \n",
                DivideScreen.spaces.Remove(0, 0) + "','|'.` )\n",
                DivideScreen.spaces.Remove(0, 0) + "  .' .'. '.\n",
                DivideScreen.spaces.Remove(0, 0) + ",'  / | \\  '.\n",
                DivideScreen.spaces.Remove(0, 0) + "    \\ '  \"\n",
                DivideScreen.spaces.Remove(0, 0) + " ` . `.' ,'\n",
                DivideScreen.spaces.Remove(0, 0) + " . `` ,'. \"\n",
                DivideScreen.spaces.Remove(0, 0) + "   ~ (   ~ -\n",
                DivideScreen.spaces.Remove(0, 0) + "'\n"
                },
                //Explosion 8
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + ". ','|` ` .\n",
                DivideScreen.spaces.Remove(0, 0) + "  .'  \"  '\n",
                DivideScreen.spaces.Remove(0, 0) + ",   ' , '  `\n",
                DivideScreen.spaces.Remove(0, 0) + "             \n",
                DivideScreen.spaces.Remove(0, 0) + "   (  ) (\n",
                DivideScreen.spaces.Remove(0, 0) + "    ) ( )\n",
                DivideScreen.spaces.Remove(0, 0) + "    (  )\n",
                DivideScreen.spaces.Remove(0, 0) + "     ) /\n",
                DivideScreen.spaces.Remove(0, 0) + "    ,---.\n"
                },
                //Explosion 9
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + ". ','|` ` .\n",
                DivideScreen.spaces.Remove(0, 0) + "  .'  \"  '\n",
                DivideScreen.spaces.Remove(0, 0) + ",   ' , '  `\n",
                DivideScreen.spaces.Remove(0, 0) + "             \n",
                DivideScreen.spaces.Remove(0, 0) + "   (  ) (\n",
                DivideScreen.spaces.Remove(0, 0) + "    ) ( )\n",
                DivideScreen.spaces.Remove(0, 0) + "    (  )\n",
                DivideScreen.spaces.Remove(0, 0) + "     ) /\n",
                DivideScreen.spaces.Remove(0, 0) + "    ,---.\n"
                },
                //Explosion 9
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + ". ','|` ` .\n",
                DivideScreen.spaces.Remove(0, 0) + "  .'  \"  '\n",
                DivideScreen.spaces.Remove(0, 0) + ",   ' , '  `\n",
                DivideScreen.spaces.Remove(0, 0) + "             \n",
                DivideScreen.spaces.Remove(0, 0) + "   (  ) (\n",
                DivideScreen.spaces.Remove(0, 0) + "    ) ( )\n",
                DivideScreen.spaces.Remove(0, 0) + "    (  )\n",
                DivideScreen.spaces.Remove(0, 0) + "     ) /\n",
                DivideScreen.spaces.Remove(0, 0) + "    ,---.\n"
                },
                //Explosion 9
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + ". ','|` ` .\n",
                DivideScreen.spaces.Remove(0, 0) + "  .'  \"  '\n",
                DivideScreen.spaces.Remove(0, 0) + ",   ' , '  `\n",
                DivideScreen.spaces.Remove(0, 0) + "             \n",
                DivideScreen.spaces.Remove(0, 0) + "   (  ) (\n",
                DivideScreen.spaces.Remove(0, 0) + "    ) ( )\n",
                DivideScreen.spaces.Remove(0, 0) + "    (  )\n",
                DivideScreen.spaces.Remove(0, 0) + "     ) /\n",
                DivideScreen.spaces.Remove(0, 0) + "    ,---.\n"
                },
                //Explosion 9
                new string[]
                {
                DivideScreen.spaces.Remove(0, 0) + ". ','|` ` .\n",
                DivideScreen.spaces.Remove(0, 0) + "  .'  \"  '\n",
                DivideScreen.spaces.Remove(0, 0) + ",   ' , '  `\n",
                DivideScreen.spaces.Remove(0, 0) + "             \n",
                DivideScreen.spaces.Remove(0, 0) + "   (  ) (\n",
                DivideScreen.spaces.Remove(0, 0) + "    ) ( )\n",
                DivideScreen.spaces.Remove(0, 0) + "    (  )\n",
                DivideScreen.spaces.Remove(0, 0) + "     ) /\n",
                DivideScreen.spaces.Remove(0, 0) + "    ,---.\n"
                }
            };
            //This reverses the array since the timer counts down throught the indexes
            TNTfinal.Reverse();

            //this starts the opening screen showing a timer
            TimerClass.i--;
            Console.ResetColor();
            Console.Clear();

            //Display Flag
            ASCII_Art.ASCIIFlagArt();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            //This loops through to print the string array list - explosion 1-16
            var indexTNT = TNTfinal[TimerClass.i];
            foreach (var array in indexTNT)
            {
                foreach (var item in array)
                {
                    //Console.WriteLine(spaces.Remove(0, 18));
                    Console.Write(item);
                }
            }
            //Display the size of window in pixels
            Console.ResetColor();
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "================================================="));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "I have changed your Console width to: " + Console.WindowWidth + " pixels"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "I have changed your Console height to: " + Console.WindowHeight + " pixels"));
            Console.ResetColor();
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
            Console.ForegroundColor = ConsoleColor.Yellow;

            //This loops through to print the string array list - explosion 1-16
            var indexTankShooting = TankArtShooting[TimerClass.i];
            foreach (var array in indexTankShooting)
            {
                foreach (var item in array)
                {
                    //Console.WriteLine(spaces.Remove(0, 18));
                    Console.Write(item);
                }
            }
            Console.ResetColor();
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "               PLEASE STAND-BY  "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "         WE'RE ROLLING IN THE TANKS "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "================================================="));

            if (TimerClass.i == 0)
            {
                Console.Clear();

                //This is to center in the screen - 7 Spaces
                Console.WriteLine("\n\n\n\n\n\n\n");

                //Display US Flag
                ASCII_Art.ASCIIFlagArt();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "  =============================================="));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                 W E L C O M E "));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                      T O "));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                JAMES SILCOTT'S"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                MILITARY UNITS"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "  =============================================="));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + ""));
                Console.ResetColor();
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "             PRESS ENTER TO ENTER"));

                TimerClass.timer.Close();
                TimerClass.timer.Dispose();
            }
            GC.Collect();

        }
    }
    public static class TankNames
    {
        //Variable names for each tank (WW1 and WW2)
        //Names of World War ONE tanks
        public static string tank1WW1 = "Marks I-V Male (Britain)";
        public static string tank2WW1 = "Medium Mark A \"Whippet\" (Britain)";
        public static string tank3WW1 = "A7V Sturmpanzerwagen (Germany)";
        public static string tank4WW1 = "Schneider M.16 CA1 (France)";
        public static string tank5WW1 = "Light Renault FT17 (France)";

        //Names of World War TWO tanks
        public static string tank1WW2 = "Comet IA 34 (Britain)";
        public static string tank2WW2 = "Tiger I (Germany)";
        public static string tank3WW2 = "IS 2 Iosif Stalin Tank (Soviet Union)";
        public static string tank4WW2 = "M26 Pershing Tank (United States)";
        public static string tank5WW2 = "Jagdpanther (Germany)";
    }
    public static class Sounds
    {
        internal static class Win32
        {
            [DllImport("winmm.dll", SetLastError = true)]
            public static extern bool PlaySound(string pszSound, UIntPtr hmod, uint fdwSound);

            [Flags]
            public enum SoundFlags
            {
                /// <summary>play synchronously (default)</summary>
                SND_SYNC = 0x0000,
                /// <summary>play asynchronously</summary>
                SND_ASYNC = 0x0001,
                /// <summary>silence (!default) if sound not found</summary>
                SND_NODEFAULT = 0x0002,
                /// <summary>pszSound points to a memory file</summary>
                SND_MEMORY = 0x0004,
                /// <summary>loop the sound until next sndPlaySound</summary>
                SND_LOOP = 0x0008,
                /// <summary>don't stop any currently playing sound</summary>
                SND_NOSTOP = 0x0010,
                /// <summary>Stop Playing Wave</summary>
                SND_PURGE = 0x40,
                /// <summary>The pszSound parameter is an application-specific alias in the registry. You can combine this flag with the SND_ALIAS or SND_ALIAS_ID flag to specify an application-defined sound alias.</summary>
                SND_APPLICATION = 0x80,
                /// <summary>don't wait if the driver is busy</summary>
                SND_NOWAIT = 0x00002000,
                /// <summary>name is a registry alias</summary>
                SND_ALIAS = 0x00010000,
                /// <summary>alias is a predefined id</summary>
                SND_ALIAS_ID = 0x00110000,
                /// <summary>name is file name</summary>
                SND_FILENAME = 0x00020000,
                /// <summary>name is resource name or atom</summary>
                SND_RESOURCE = 0x00040004
            }
        }
        //This plays a default windows sound
        public static void SoundAsterisk()
        {
            //Plays Asterik Beep
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));
        }
        public static void SoundSysHand()
        {
            //Plays Hand Beep
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));
        }
    }
    public static class Game
    {
        //Intro and menu selection method at startup
        #region INTRO METHOD
        public static void Intro()
        {
            //Call the ASCII Art Method to display the big tank
            ASCII_Art.BigTankArt();

            //Call the Sound Method to play Asterisk Sound
            Sounds.SoundAsterisk();

            //Menu for WW1 or WW2 Tanks
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "WELCOME TO MILITARY UNITS - WORLD WAR TANKS"));
            Console.WriteLine();
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Choose a World War: [1] or [2]"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "1. World War I - 1914 to 1918"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "2. World War II - 1939 to 1945"));
            string response = Console.ReadLine();
            int number;

            //convert string response to integer
            if (int.TryParse(response, out number))
            {
                // string interpolation expression
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected: {number}"));

                //if number is equal to 1, show WW1 tanks
                if (number == 1)
                {
                    Console.Clear();

                    //This is to center in the screen - 7 Spaces
                    Console.WriteLine("\n\n\n\n\n\n\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Here are the Top 5 Tanks from WORLD WAR 1 ERA"));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank1WW1));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank2WW1));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank3WW1));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank4WW1));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank5WW1));
                    Console.ResetColor();
                    Console.WriteLine();

                    //Call the WW1 Tank Method
                    TankSelection.TankSelectionWW1();
                }
                //if number is equal to 2, show WW2 tanks
                else if (number == 2)
                {
                    Console.Clear();

                    //This is to center in the screen - 7 Spaces
                    Console.WriteLine("\n\n\n\n\n\n\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Here are the Top 5 Tanks from WORLD WAR 2 ERA"));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank1WW2));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank2WW2));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank3WW2));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank4WW2));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "- " + TankNames.tank5WW2));
                    Console.ResetColor();
                    Console.WriteLine();

                    //Call the WW2 Tank Method
                    TankSelection.TankSelectionWW2();
                }
                //if anything other than a 1 or 2 is entered clear the screen and returnt to intro
                else
                {
                    Console.Clear();
                    Intro();
                }
            }
            //if the response is anything other than a number
            else
            {

                //This is to center in the screen - 7 Spaces
                Console.WriteLine("\n\n\n\n\n\n\n");

                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "You typed: {0}", response));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Incorrect Response Format, Try Again:"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press Enter"));
                Console.ReadLine();
                Console.Clear();
                Intro();
            }
        }
        #endregion
    }
    public static class DivideScreen
    {
        public static int consoleWidth = Console.WindowWidth;
        public static int dividedWidth = consoleWidth / 2;
        public static string spaces = ' '.Repeat(dividedWidth);
    }
    public static class TankSelection
    {

        public static void SelectionCategories()
        {

            //This is to center in the screen
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Choose what to Learn: [1], [2], [3], [4] or [5]"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "1. Firepower"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "2. Speed"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "3. Distance"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "4. Armour"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "5. Crew Size"));
        }
        public static void TankSelectionWW1()
        {
            int number;
            SelectionCategories();
            string response = Console.ReadLine();
            Console.Clear();

            //This is to center in the screen - 7 Spaces
            Console.WriteLine("\n\n\n\n\n\n\n");

            //convert string response to integer
            if (Int32.TryParse(response, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Firepower\n"));
                        TankFirepowerWW1();
                        break;
                    case 2:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Speed\n"));
                        TankSpeedWW1();
                        break;
                    case 3:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Distance\n"));
                        TankDistanceWW1();
                        break;
                    case 4:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Armour\n"));
                        TankArmourWW1();
                        break;
                    case 5:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Crew Size\n"));
                        TankCrewSizeWW1();
                        break;
                }
                //if number is greater than 5, clear and replay intro
                if (number > 5)
                {
                    Console.Clear();
                    Game.Intro();
                }
                Console.WriteLine();
            }
            //if the response is anything other than a number
            else
            {

                //This is to center in the screen - 7 Spaces
                Console.WriteLine("\n\n\n\n\n\n\n");

                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "You typed: {0}", response));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Incorrect Response Format, Try Again:"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press Enter"));
                Console.ReadLine();
                Console.Clear();
                Game.Intro();
            }
            TryAgainMessage.TryAgain();
        }
        public static void TankSelectionWW2()
        {
            int number;
            SelectionCategories();
            string response = Console.ReadLine();
            Console.Clear();

            //This is to center in the screen - 7 Spaces
            Console.WriteLine("\n\n\n\n\n\n\n");

            //convert string response to integer
            if (Int32.TryParse(response, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Firepower\n"));
                        TankFirepowerWW2();
                        break;
                    case 2:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Speed\n"));
                        TankSpeedWW2();
                        break;
                    case 3:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Distance\n"));
                        TankDistanceWW2();
                        break;
                    case 4:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Armour\n"));
                        TankArmourWW2();
                        break;
                    case 5:
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"You selected {number}: " + "Crew Size\n"));
                        TankCrewSizeWW2();
                        break;
                }
                //if number is greater than 5, clear and replay intro
                if (number > 5)
                {
                    Console.Clear();
                    Game.Intro();
                }
                Console.WriteLine();
            }
            //if the response is anything other than a number
            else
            {
                //This is to center in the screen - 7 Spaces
                Console.WriteLine("\n\n\n\n\n\n\n");

                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "You typed: {0}", response));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Incorrect Response Format, Try Again:"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press Enter"));
                Console.ReadLine();
                Console.Clear();
                Game.Intro();
            }
            TryAgainMessage.TryAgain();
        }
        //WW1 Tank Methods
        #region METHOD: WORLD WAR 1 TANKS CLASS CALLS
        public static void TankFirepowerWW1()
        {
            TankWW1 myTankWW1 = new TankWW1();
            myTankWW1.typeoftank();
            myTankWW1.firepower("a mounted large-calibre cannon called tank gun in a rotating gun turret ");
            Console.WriteLine();

            MarksIVMale myMarksIVMale = new MarksIVMale();
            myMarksIVMale.typeoftank();
            myMarksIVMale.firepower("two six pounder naval guns");
            Console.WriteLine();

            Whippet myWhippet = new Whippet();
            myWhippet.typeoftank();
            myWhippet.firepower("four 0.303-inch Hotchkiss Mk 1 machine guns, one covering each direction");
            Console.WriteLine();

            Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
            mySturmpanzerwagen.typeoftank();
            mySturmpanzerwagen.firepower("six 7.92 mm MG08 machine guns and a 5.7 cm Maxim-Nordenfelt cannon");
            Console.WriteLine();

            Schneider mySchneider = new Schneider();
            mySchneider.typeoftank();
            mySchneider.firepower("a short 75 mm cannon, in a sponson on the right side");
            Console.WriteLine();

            Renault myRenault = new Renault();
            myRenault.typeoftank();
            myRenault.firepower("a fully rotating turret, a Hotchkiss 8mm machine gun and 37mm Puteaux gun.");
        }
        public static void TankSpeedWW1()
        {
            TankWW1 myTankWW1 = new TankWW1();
            myTankWW1.typeoftank();
            myTankWW1.speed("30 mph");
            Console.WriteLine();

            MarksIVMale myMarksIVMale = new MarksIVMale();
            myMarksIVMale.typeoftank();
            myTankWW1.speed("4 mph");
            Console.WriteLine();

            Whippet myWhippet = new Whippet();
            myWhippet.typeoftank();
            myTankWW1.speed("30 mph");
            Console.WriteLine();

            Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
            mySturmpanzerwagen.typeoftank();
            myTankWW1.speed("9.3 mph");
            Console.WriteLine();

            Schneider mySchneider = new Schneider();
            mySchneider.typeoftank();
            myTankWW1.speed("5 mph");
            Console.WriteLine();

            Renault myRenault = new Renault();
            myRenault.typeoftank();
            myTankWW1.speed("4.5 mph");
        }
        public static void TankDistanceWW1()
        {
            TankWW1 myTankWW1 = new TankWW1();
            myTankWW1.typeoftank();
            myTankWW1.distance("80 miles");
            Console.WriteLine();

            MarksIVMale myMarksIVMale = new MarksIVMale();
            myMarksIVMale.typeoftank();
            myTankWW1.distance("35 miles");
            Console.WriteLine();

            Whippet myWhippet = new Whippet();
            myWhippet.typeoftank();
            myTankWW1.distance("23.6 miles");
            Console.WriteLine();

            Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
            mySturmpanzerwagen.typeoftank();
            myTankWW1.distance("50 miles");
            Console.WriteLine();

            Schneider mySchneider = new Schneider();
            mySchneider.typeoftank();
            myTankWW1.distance("49.7 miles");
            Console.WriteLine();

            Renault myRenault = new Renault();
            myRenault.typeoftank();
            myTankWW1.distance("30 miles");
        }
        public static void TankArmourWW1()
        {
            TankWW1 myTankWW1 = new TankWW1();
            myTankWW1.typeoftank();
            myTankWW1.armour("30 mm");
            Console.WriteLine();

            MarksIVMale myMarksIVMale = new MarksIVMale();
            myMarksIVMale.typeoftank();
            myTankWW1.armour("12 mm");
            Console.WriteLine();

            Whippet myWhippet = new Whippet();
            myWhippet.typeoftank();
            myTankWW1.armour("14 mm");
            Console.WriteLine();

            Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
            mySturmpanzerwagen.typeoftank();
            myTankWW1.armour("30 mm front 20 mm sides");
            Console.WriteLine();

            Schneider mySchneider = new Schneider();
            mySchneider.typeoftank();
            myTankWW1.armour("22.8 mm");
            Console.WriteLine();

            Renault myRenault = new Renault();
            myRenault.typeoftank();
            myTankWW1.armour("22 mm");
        }
        public static void TankCrewSizeWW1()
        {
            TankWW1 myTankWW1 = new TankWW1();
            myTankWW1.typeoftank();
            myTankWW1.crewSize("(commander/brakesman, driver, two gearsmen and four gunners)");
            Console.WriteLine();

            MarksIVMale myMarksIVMale = new MarksIVMale();
            myMarksIVMale.typeoftank();
            myTankWW1.crewSize("8");
            Console.WriteLine();

            Whippet myWhippet = new Whippet();
            myWhippet.typeoftank();
            myTankWW1.crewSize("3");
            Console.WriteLine();

            Sturmpanzerwagen mySturmpanzerwagen = new Sturmpanzerwagen();
            mySturmpanzerwagen.typeoftank();
            myTankWW1.crewSize("A minimum of 18");
            Console.WriteLine();

            Schneider mySchneider = new Schneider();
            mySchneider.typeoftank();
            myTankWW1.crewSize("4");
            Console.WriteLine();

            Renault myRenault = new Renault();
            myRenault.typeoftank();
            myTankWW1.crewSize("2 (commander, driver)");
        }
        #endregion

        //WW2 Tank Methods
        #region METHOD: WORLD WAR 2 TANKS CLASS CALLS
        public static void TankFirepowerWW2()
        {
            TankWW2 myTankWW2 = new TankWW2();
            myTankWW2.typeoftank();
            myTankWW2.firepower("88-mm guns");
            Console.WriteLine();

            Comet myComet = new Comet();
            myComet.typeoftank();
            myComet.firepower("mounted the new 17 pdr High Velocity (HV) (3 inch; 76.2 mm) gun, ");
            Console.WriteLine();

            Tiger myTiger = new Tiger();
            myTiger.typeoftank();
            myTiger.firepower("mounted the 8.8 cm KwK 36 gun (derived from the 8.8 cm Flak 36)");
            Console.WriteLine();

            Stalin myStalin = new Stalin();
            myStalin.typeoftank();
            myStalin.firepower("long-barrelled 85 mm cannon (D-5T-85-BM)");
            Console.WriteLine();

            Pershing myPershing = new Pershing();
            myPershing.typeoftank();
            myPershing.firepower("90 mm Gun M3 70 rounds");
            Console.WriteLine();

            Jagdpanther myJagdpanther = new Jagdpanther();
            myJagdpanther.typeoftank();
            myJagdpanther.firepower("7.5 cm Pak 39 L/48 gun");
        }
        public static void TankSpeedWW2()
        {
            TankWW2 myTankWW2 = new TankWW2();
            myTankWW2.typeoftank();
            myTankWW2.speed("45 mph");
            Console.WriteLine();

            Comet myComet = new Comet();
            myComet.typeoftank();
            myTankWW2.speed("32 mph");
            Console.WriteLine();

            Tiger myTiger = new Tiger();
            myTiger.typeoftank();
            myTankWW2.speed("28.2 mph");
            Console.WriteLine();

            Stalin myStalin = new Stalin();
            myStalin.typeoftank();
            myTankWW2.speed("23 mph");
            Console.WriteLine();

            Pershing myPershing = new Pershing();
            myPershing.typeoftank();
            myTankWW2.speed("25 mph");
            Console.WriteLine();

            Jagdpanther myJagdpanther = new Jagdpanther();
            myJagdpanther.typeoftank();
            myTankWW2.speed("28.6 mph");
        }
        public static void TankDistanceWW2()
        {
            TankWW2 myTankWW2 = new TankWW2();
            myTankWW2.typeoftank();
            myTankWW2.distance("150 miles");
            Console.WriteLine();

            Comet myComet = new Comet();
            myComet.typeoftank();
            myTankWW2.distance("170 miles");
            Console.WriteLine();

            Tiger myTiger = new Tiger();
            myTiger.typeoftank();
            myTankWW2.distance("121 miles");
            Console.WriteLine();

            Stalin myStalin = new Stalin();
            myStalin.typeoftank();
            myTankWW2.distance("150 miles");
            Console.WriteLine();

            Pershing myPershing = new Pershing();
            myPershing.typeoftank();
            myTankWW2.distance("100 miles");
            Console.WriteLine();

            Jagdpanther myJagdpanther = new Jagdpanther();
            myJagdpanther.typeoftank();
            myTankWW2.distance("99 miles");
        }
        public static void TankArmourWW2()
        {
            TankWW1 myTankWW2 = new TankWW1();
            myTankWW2.typeoftank();
            myTankWW2.armour("120 mm");
            Console.WriteLine();

            Comet myComet = new Comet();
            myComet.typeoftank();
            myTankWW2.armour("102 mm");
            Console.WriteLine();

            Tiger myTiger = new Tiger();
            myTiger.typeoftank();
            myTankWW2.armour("120 mm");
            Console.WriteLine();

            Stalin myStalin = new Stalin();
            myStalin.typeoftank();
            myTankWW2.armour("120 mm");
            Console.WriteLine();

            Pershing myPershing = new Pershing();
            myPershing.typeoftank();
            myTankWW2.armour("102 mm");
            Console.WriteLine();

            Jagdpanther myJagdpanther = new Jagdpanther();
            myJagdpanther.typeoftank();
            myTankWW2.armour("100 mm");
        }
        public static void TankCrewSizeWW2()
        {
            TankWW1 myTankWW2 = new TankWW1();
            myTankWW2.typeoftank();
            myTankWW2.crewSize("5 crew members (commander, gunner, loader, driver and co-driver)");
            Console.WriteLine();

            Comet myComet = new Comet();
            myComet.typeoftank();
            myTankWW2.crewSize("5");
            Console.WriteLine();

            Tiger myTiger = new Tiger();
            myTiger.typeoftank();
            myTankWW2.crewSize("5");
            Console.WriteLine();

            Stalin myStalin = new Stalin();
            myStalin.typeoftank();
            myTankWW2.crewSize("4");
            Console.WriteLine();

            Pershing myPershing = new Pershing();
            myPershing.typeoftank();
            myTankWW2.crewSize("5");
            Console.WriteLine();

            Jagdpanther myJagdpanther = new Jagdpanther();
            myJagdpanther.typeoftank();
            myTankWW2.crewSize("5");
        }
        #endregion

    }
    //Class for WW1 Tanks
    #region CLASS: WW1 - (TankWW1, MarksIVMale, Whippet, Sturmpanzerwagen, Schneider, Renault) 
    class TankWW1
    {
        public virtual void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + $"I am a World War 1 Tank"));
        }
        public void firepower(string action)
        {
            Console.Write($" and armed with: {action}\n");
        }
        public void speed(string speed)
        {
            Console.Write($" and has a max speed of: {speed}\n");
        }
        public void distance(string distance)
        {
            Console.Write($" and a range of: {distance}\n");
        }
        public void armour(string action)
        {
            Console.Write($" and armour thickness of: {action}\n");
        }
        public void crewSize(string action)
        {
            Console.Write($" and a crew size of: {action}\n");
        }
    }
    class MarksIVMale : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a British Marks I-V Male"));
        }
    }
    class Whippet : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a British Medium Mark A “Whippet"));
        }
    }
    class Sturmpanzerwagen : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a German A7V Sturmpanzerwagen"));
        }
    }
    class Schneider : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a French Schneider M.16 CA1"));
        }
    }
    class Renault : TankWW1
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a French Light Renault FT17"));
        }
    }
    #endregion

    //Class for WW2 Tanks
    #region CLASS: WW2 - (TankWW2, Comet, Tiger, Stalin, Pershing, Jagdpanther)
    class TankWW2
    {
        public virtual void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + $"I am a World War 2 Tank"));
        }
        public void firepower(string action)
        {
            Console.Write($" and armed with: {action}\n");
        }
        public void speed(string speed)
        {
            Console.Write($" and have a max speed of: {speed}\n");
        }
        public void distance(string distance)
        {
            Console.Write($" and a range of: {distance}\n");
        }
        public void armour(string action)
        {
            Console.Write($" and armour thickness of: {action}\n");
        }
        public void crewSize(string action)
        {
            Console.Write($" and a crew size of: {action}\n");
        }
    }
    class Comet : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a Comet IA 34 (Britain)"));
        }
    }
    class Tiger : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a Tiger I (Germany)"));
        }
    }
    class Stalin : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a IS 2 Iosif Stalin Tank (Soviet Union)"));
        }
    }
    class Pershing : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a M26 Pershing Tank (United States)"));
        }
    }
    class Jagdpanther : TankWW2
    {
        public override void typeoftank()
        {
            //This is to find the pixels in the screen divid by two and center the text using spaces
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.Write((spaces.Remove(0, 45) + "I am a Jagdpanther (Germany)"));
        }
    }
    #endregion

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
    public static class TryAgainMessage
    {
        //Try Again Method - Option to play the application again
        #region METHOD: TRY AGAIN 
        //Set the loop condition
        public static string tryAgainResponse = "Y";
        public static void TryAgain()
        {
            //This is to center in the screen - 7 Spaces
            Console.WriteLine("\n\n\n\n\n\n\n");

            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Want to play again? [Y] or [N]"));
            Console.WriteLine();
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "[B]attle"));
            var response = Console.ReadLine();
            var responseUpper = response.ToUpper();
            //If Yes
            if (responseUpper == "Y")
            {
                Console.Clear();
                Game.Intro();
            }
            //If No
            else if (responseUpper == "N")
            {
                Console.Clear();
                tryAgainResponse = "N";

                //Display US Flag Art
                ASCII_Art.ASCIIFlagArt();

                //Display Thank You Art
                ThankYouMessage.ThankYouEnding();
                Sounds.SoundSysHand();
            }

            #region EGG
            //EASTER EGG - Mini Tank Battle Game 
            else if (responseUpper == "B")
            {
                //Message
                Console.Clear();

                //This is to center in the screen - 7 Spaces
                Console.WriteLine("\n\n\n\n\n\n\n");

                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "YOU'VE FOUND AN EASTER EGG!"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "By James Silcott"));
                Console.WriteLine();
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "This is a mini game that simulates a battle with WW1 and WW2 tanks"));

                //Change Color
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Add Art
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "    .--._____,           ,_____.--."));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + " .-='=='==-, \"    vs     \"  .-='=='==-, "));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "(O_o_o_o_o_O)              (O_o_o_o_o_O) "));

                //Rest Color
                Console.ResetColor();

                //Continue Message
                Console.WriteLine();
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "First a tank from WW1 ERA and a tank from the WW2 ERA is choosen to fight!"));
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Then those two tanks battle -- See if you can guess the winner"));
                Console.WriteLine();
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "--Press Enter--"));
                Console.WriteLine();
                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "And Good Luck!"));
                Console.ReadLine();

                //This sets the max number to randomly pick from
                const int maxTanksWW1 = 5;
                const int maxTanksWW2 = 5;

                //This creates a dictionary of the tanks
                var tankNamesWW1 = new Dictionary<int, string>
                        {
                            {0, TankNames.tank1WW1},
                            {1, TankNames.tank2WW1},
                            {2, TankNames.tank3WW1},
                            {3, TankNames.tank4WW1},
                            {4, TankNames.tank5WW1},
                        };
                var tankNamesWW2 = new Dictionary<int, string>
                        {
                            {0, TankNames.tank1WW2},
                            {1, TankNames.tank2WW2},
                            {2, TankNames.tank3WW2},
                            {3, TankNames.tank4WW2},
                            {4, TankNames.tank5WW2}
                        };
                //Random funtcion assigned
                var random = new Random();
                //Set a condiontal statement
                bool conditionModifer = true;
                //Create a loop
                while (conditionModifer == true)
                {
                    Console.Clear();
                    //Use the random function and next object to generate random tank
                    var tankSelectedWW1 = random.Next(maxTanksWW1);
                    var tankSelectedWW2 = random.Next(maxTanksWW2);

                    //This assign whateve tank is picked to the new variable Final
                    var tankSelectedFinalWW1 = tankNamesWW1[tankSelectedWW1];
                    var tankSelectedFinalWW2 = tankNamesWW2[tankSelectedWW2];

                    //Change Color
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    //This is to center in the screen - 7 Spaces
                    Console.WriteLine("\n\n\n\n\n\n\n");

                    //Add Art
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "    .--._____,           ,_____.--."));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + " .-='=='==-, \"    vs     \"  .-='=='==-, "));
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "(O_o_o_o_o_O)              (O_o_o_o_o_O) "));

                    //Rest Color
                    Console.ResetColor();

                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"World War 1 Tank: {tankSelectedFinalWW1}"));
                    Console.WriteLine();
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "             VERSUS "));
                    Console.WriteLine();
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"World War 2 Tank: {tankSelectedFinalWW2}"));
                    Console.WriteLine();
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Who Will Conquer?"));
                    Console.WriteLine();
                    Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press Enter to Battle"));
                    Console.ReadLine();

                    //Variable to indicate which decision wins
                    int decision;

                    //Create a Random Object
                    Random randFinal = new Random();

                    //Get a Random integer in range of 0 through 1
                    //0 means WW1 tank, 1 means WW2 tank
                    decision = randFinal.Next(2);

                    //Display on console the winner
                    if (decision == 0)
                    {
                        Console.Clear();

                        //This is to center in the screen - 7 Spaces
                        Console.WriteLine("\n\n\n\n\n\n\n");

                        //Change Color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "   [ O ]     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "     \\ \\      p     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "      \\ \\  \\o/     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "       \\ \\--'---_     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "       /\\ \\   / ~~\\_     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + " ./---/__|=/_/------//~~~\\     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "/___________________/O   O \\     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "(===(\\_________(===(Oo o o O)       "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + " \\~~~\\____/     \\---\\Oo__o--     "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "   ~~~~~~~       ~~~~~~~~~~     "));

                        //Reset Color
                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"The Winner is World War-1: {tankSelectedFinalWW1}"));
                        Console.WriteLine();
                        Sounds.SoundAsterisk();
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press 'Enter' for a different battle"));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                 OR"));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press a different key to exit out"));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();

                        //This is to center in the screen - 7 Spaces
                        Console.WriteLine("\n\n\n\n\n\n\n");

                        //Change Color
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "            __.---.___         "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "        ___/__\\_O_/___\\___         "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "       /___ __________ ___\\         "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "       |===|\\________/|===|         "));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "_______|===|__________|===|______         "));

                        //Reset Color
                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + $"The Winner is World War-2: {tankSelectedFinalWW2}"));
                        Console.WriteLine();
                        Sounds.SoundSysHand();
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press 'Enter' for a different battle"));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                 OR"));
                        Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Press a different key to exit out"));
                        Console.WriteLine();
                    }
                    //set the condional to not run forever, if any key pressed doesn't equal enter than set to false fort eh start of the tank battle to stop
                    //conditionModifer = false;
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        conditionModifer = false;
                    }
                    Console.Clear();
                    ASCII_Art.BigTankArt();
                }
                //Rerun the method
                TryAgain();
            }
            #endregion
            //Catch all other keys
            else
            {
                //This is to center in the screen - 7 Spaces
                Console.WriteLine("\n\n\n\n\n\n\n");

                Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "Wrong input, Try Again"));
                Console.Clear();
                TryAgain();
            }
        }
    }
    #endregion
    public static class Program
    {
        public static void Main(string[] args)
        {
            FullScreen.WideScreenMethod();
            Console.WriteLine("Hello World!");
            //start the timer method and set the timer to add itself then read console 
            TimerClass.timer.Elapsed += ASCII_Art_Animated.timer_Elapsed;
            TimerClass.timer.Start();
            Console.ReadLine();
            Console.Clear();

            while (TryAgainMessage.tryAgainResponse == "Y")
            {
                //Call the Intro Method
                Game.Intro();
            }
        }
    }
}
















