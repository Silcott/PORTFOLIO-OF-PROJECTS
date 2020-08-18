//Name: James Silcott
//File: progex04.txt
//Date: July 30, 2020

using System;
using System.Runtime.InteropServices;
using System.Timers;

namespace progex04
{

    internal class Pig
    {
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



        public string name;

        public Pig(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -SPEAKING-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                Hi, my name is               |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                 {this.name}                |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                 and I am a                  |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                {this.GetType()}                 |"));


        }
        public void Eat()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                   -EAT-                     |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|        This {this.GetType()} eats swill         |"));
        }
        public void Produce()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                 -PRODUCES-                  |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|    This {this.GetType()} produces pork chops    |"));
        }
        public void Move()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -MOVE-                   |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|     This {this.GetType()} wallows in the mud    |"));
            Console.ResetColor();
            Console.WriteLine((spaces.Remove(0, 18) + "                                               "));
            Console.ResetColor();

        }
    }

    internal class Horse
    {
        public string name;

        public Horse(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -SPEAKING-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                Hi, my name is               |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                 {this.name}                |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                 and I am a                  |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                {this.GetType()}               |"));


        }
        public void Eat()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -EAT-                    |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|        This {this.GetType()} eats oats        |"));
        }
        public void Produce()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -PRODUCES-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|    This {this.GetType()} produces leather     |"));
        }
        public void Move()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -MOVE-                   |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|    This {this.GetType()} trots and canters    |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.ResetColor();
            Console.WriteLine((spaces.Remove(0, 18) + "                                               "));
            Console.ResetColor();
        }
    }

    internal class Cow
    {
        public string name;

        public Cow(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -SPEAKING-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                Hi, my name is               |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                 {this.name}                |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                 and I am a                  |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                {this.GetType()}                 |"));


        }
        public void Eat()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -EAT-                    |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|        This {this.GetType()} eats grass         |"));
        }
        public void Produce()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -PRODUCES-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|       This {this.GetType()} produces steak      |"));
        }
        public void Move()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -MOVE-                   |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|     This {this.GetType()} grazes and walks      |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.ResetColor();
            Console.WriteLine((spaces.Remove(0, 18) + "                                               "));
            Console.ResetColor();
        }
    }

    internal class Chicken
    {
        public string name;

        public Chicken(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -SPEAKING-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                Hi, my name is               |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                 {this.name}                |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                 and I am a                  |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|                {this.GetType()}             |"));


        }
        public void Eat()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -EAT-                    |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|        This {this.GetType()} eats corn      |"));
        }
        public void Produce()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                  -PRODUCES-                 |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|  This {this.GetType()} produces drumsticks  |"));
        }
        public void Move()
        {
            //this gets the pixels of the fullscreen divides it by two and turns that into empty string space, so I can center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                    -MOVE-                   |"));
            Console.WriteLine((spaces.Remove(0, 18) + $"|    This {this.GetType()} pecks and squawks  |"));
            Console.WriteLine((spaces.Remove(0, 18) + "|                                             |"));
            Console.ResetColor();
            Console.WriteLine((spaces.Remove(0, 18) + "                                               "));
            Console.ResetColor();
        }
    }

    //This is for the sounds to be active from the win Dynamic-link library...I copied this off the web
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
    //This is used to count the spaces in the string 
    1



    class Program
    {
        static Timer timer = new Timer(1000);
        static int i = 6;

        private static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //This will set the console window to full screen
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            //this sets varibales so I can divide the screen in half by pixels to center the text
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);

            //this startst the opening screen showing a timer
            i--;

            Console.Clear();
            Console.WriteLine((spaces.Remove(0, 18) + "================================================="));
            Console.WriteLine((spaces.Remove(0, 18) + "I have changed your Console width to: " + Console.WindowWidth + " pixels"));
            Console.WriteLine((spaces.Remove(0, 18) + "I have changed your Console height to: " + Console.WindowHeight + " pixels"));
            Console.WriteLine((spaces.Remove(0, 18) + ""));
            Console.WriteLine((spaces.Remove(0, 18) + "        This program will begin in:  " + i.ToString()));
            Console.WriteLine((spaces.Remove(0, 18) + ""));
            Console.WriteLine((spaces.Remove(0, 18) + "               PLEASE STAND-BY  "));
            Console.WriteLine((spaces.Remove(0, 18) + ""));
            Console.WriteLine((spaces.Remove(0, 18) + "         We Are Corralling the Animals "));
            Console.WriteLine((spaces.Remove(0, 18) + "================================================="));

            if (i == 0)
            {
                Console.Clear();
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "  =============================================="));
                Console.WriteLine((spaces.Remove(0, 18) + "                 W E L C O M E "));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "                      T O "));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "                JAMES SILCOTT'S"));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "                  ANIMAL FARM"));
                Console.WriteLine((spaces.Remove(0, 18) + "  =============================================="));
                Console.WriteLine((spaces.Remove(0, 18) + ""));
                Console.WriteLine((spaces.Remove(0, 18) + "             PRESS A ENTER TO ENTER"));

                timer.Close();
                timer.Dispose();
            }
            GC.Collect();
        }

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

        static void Main(string[] args)
        {


            //to set to fullscreen in case it is missed by the opening screen
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            //start the timer method and set the timer to add itself then read console 
            timer.Elapsed += timer_Elapsed;
            timer.Start();
            Console.Read();

            //Console.SetWindowSize(200, 60);//I used this at first but decided to make the screen automatically go fullscreen
            var consoleWidth = Console.WindowWidth;
            var dividedWidth = consoleWidth / 2;
            string spaces = ' '.Repeat(dividedWidth);


            static void PigDrawing()
            {
                //this gets the pixels of teh fullscreen divides it by two and turns that into empty string space, so I can center the text
                var consoleWidth = Console.WindowWidth;
                var dividedWidth = consoleWidth / 2;
                string spaces = ' '.Repeat(dividedWidth);

                Console.WriteLine(spaces + "      ,.");
                Console.WriteLine(spaces + "     (_|,.");
                Console.WriteLine(spaces + "    ,' /, )_______   _");
                Console.WriteLine(spaces + " __j o``-'        `.'-)'");
                Console.WriteLine(spaces + @"(""\"")                \""\");
                Console.WriteLine(spaces + " `-j                |");
                Console.WriteLine(spaces + "   `-._(           /");
                Console.WriteLine(spaces + "      |_\\  |--^.  /");
                Console.WriteLine(spaces + "     /_]'|_| /_)_/");
                Console.WriteLine(spaces + "        /_]'  /_]'");
                Console.WriteLine(spaces + "");


            }

            static void HorseDrawing()
            {
                //this gets the pixels of teh fullscreen divides it by two and turns that into empty string space, so I can center the text
                var consoleWidth = Console.WindowWidth;
                var dividedWidth = consoleWidth / 2;
                string spaces = ' '.Repeat(dividedWidth);

                Console.WriteLine(spaces + "           ,--,");
                Console.WriteLine(spaces + "    _ ___/ /\\| ");
                Console.WriteLine(spaces + "  ;( )__, ) ");
                Console.WriteLine(spaces + "; //   '--; ");
                Console.WriteLine(spaces + "  \\     | ");
                Console.WriteLine(spaces + "   ^    ^ ");
            }

            static void CowDrawing()
            {
                //this gets the pixels of teh fullscreen divides it by two and turns that into empty string space, so I can center the text
                var consoleWidth = Console.WindowWidth;
                var dividedWidth = consoleWidth / 2;
                string spaces = ' '.Repeat(dividedWidth);

                Console.WriteLine(spaces + "         __n__n__ ");
                Console.WriteLine(spaces + "  .------`-\00/- ");
                Console.WriteLine(spaces + " /  ##  ## (oo) ");
                Console.WriteLine(spaces + "/ \\## __   ./ ");
                Console.WriteLine(spaces + "   |//YY \\|/ ");
                Console.WriteLine(spaces + "   |||   |||");
            }

            static void ChickenDrawing()
            {
                //this gets the pixels of teh fullscreen divides it by two and turns that into empty string space, so I can center the text
                var consoleWidth = Console.WindowWidth;
                var dividedWidth = consoleWidth / 2;
                string spaces = ' '.Repeat(dividedWidth);

                Console.WriteLine(spaces + "      __// ");
                Console.WriteLine(spaces + "    /.__.\\ ");
                Console.WriteLine(spaces + "    \\ \\/ / ");
                Console.WriteLine(spaces + " '__/    \\ ");
                Console.WriteLine(spaces + " \\-      ) ");
                Console.WriteLine(spaces + "  \\_____/ ");
                Console.WriteLine(spaces + "_____|_|____ ");
                Console.WriteLine(spaces + "    \" \" ");

            }


            //Miss Piggy
            Console.ForegroundColor = ConsoleColor.Red;
            PigDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Pig missPiggy = new Pig(" Miss Piggy ");
            missPiggy.Speak();
            missPiggy.Eat();
            missPiggy.Produce();
            missPiggy.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Porky
            Console.ForegroundColor = ConsoleColor.Red;
            PigDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Pig porky = new Pig("    Porky   ");
            porky.Speak();
            porky.Eat();
            porky.Produce();
            porky.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Wilber
            Console.ForegroundColor = ConsoleColor.Red;
            PigDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Pig wilber = new Pig("   Wilber   ");
            wilber.Speak();
            wilber.Eat();
            wilber.Produce();
            wilber.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Mr. Ed
            Console.ForegroundColor = ConsoleColor.Cyan;
            HorseDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Horse mrEd = new Horse("   Mr. Ed   ");
            mrEd.Speak();
            mrEd.Eat();
            mrEd.Produce();
            mrEd.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Seabiscuit
            Console.ForegroundColor = ConsoleColor.Cyan;
            HorseDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Horse seabiscuit = new Horse("  Seabiscuit");
            seabiscuit.Speak();
            seabiscuit.Eat();
            seabiscuit.Produce();
            seabiscuit.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Pegasus
            Console.ForegroundColor = ConsoleColor.Cyan;
            HorseDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Horse pegasus = new Horse("  Pegasus   ");
            pegasus.Speak();
            pegasus.Eat();
            pegasus.Produce();
            pegasus.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Clarabelle
            Console.ForegroundColor = ConsoleColor.White;
            CowDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Cow clarabelle = new Cow(" Clarabelle ");
            clarabelle.Speak();
            clarabelle.Eat();
            clarabelle.Produce();
            clarabelle.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Ferdinand
            Console.ForegroundColor = ConsoleColor.White;
            CowDrawing();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Cow ferdinand = new Cow("  Ferdinand ");
            ferdinand.Speak();
            ferdinand.Eat();
            ferdinand.Produce();
            ferdinand.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Elsie
            Console.ForegroundColor = ConsoleColor.White;
            CowDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Cow elsie = new Cow("   Elsie    ");
            elsie.Speak();
            elsie.Eat();
            elsie.Produce();
            elsie.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Chicken Little
            Console.ForegroundColor = ConsoleColor.Yellow;
            ChickenDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Chicken chikenLittle = new Chicken("Chicken Tiny");
            chikenLittle.Speak();
            chikenLittle.Eat();
            chikenLittle.Produce();
            chikenLittle.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Foghorn Lethorn
            Console.ForegroundColor = ConsoleColor.Yellow;
            ChickenDrawing();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Chicken foghornLethorn = new Chicken("Foghorn Horn");
            foghornLethorn.Speak();
            foghornLethorn.Eat();
            foghornLethorn.Produce();
            foghornLethorn.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemAsterisk", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            //Big Bird
            Console.ForegroundColor = ConsoleColor.Yellow;
            ChickenDrawing();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Chicken bigBird = new Chicken("  Big Bird  ");
            bigBird.Speak();
            bigBird.Eat();
            bigBird.Produce();
            bigBird.Move();
            Console.ResetColor();
            Win32.PlaySound("SystemHand", UIntPtr.Zero, (uint)(Win32.SoundFlags.SND_ALIAS | Win32.SoundFlags.SND_NODEFAULT));

            Console.WriteLine((spaces.Remove(0, 18) + "         Thanks for visiting my farm!               "));

            Console.WriteLine((spaces.Remove(0, 18) + " _   _                 _                           " ));
            Console.WriteLine((spaces.Remove(0, 18) + "| | | |               | |                          " ));
            Console.WriteLine((spaces.Remove(0, 18) + "| |_| |__   __ _ _ __ | | ___   _  ___  _   _      " ));
            Console.WriteLine((spaces.Remove(0, 18) + "| __| '_ \\ / _` | '_ \\| |/ / | | |/ _ \\| | | |  "));
            Console.WriteLine((spaces.Remove(0, 18) + "| |_| | | | (_| | | | |   <| |_| | (_) | |_| |     "));
            Console.WriteLine((spaces.Remove(0, 18) + "\\___|_| |_|\\__,_|_| |_|_|\\_\\__, |\\___/ \\__,__|"));
            Console.WriteLine((spaces.Remove(0, 18) + "                            __/  |                 "));
            Console.WriteLine((spaces.Remove(0, 18) + "                           |____/                  "));


            Console.ReadLine();
        }


    }
}
