using PInvoke;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Tetris
{
    public static class WindowSize
    {
        //Make Fullscreen
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
        public static void FullScreen()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }

        public static void CustomScreen()
        {
            Console.SetWindowSize(30, 80);
           
            


        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int WriteConsoleOutputCharacterA(int hConsoleOutput, string lpCharacter, int nLength, ref COORD dwWriteCoord, ref int lpNumberOfCharsWritten);

        [DllImport("Kernel32.dll")]
        public static extern IntPtr CreateConsoleScreenBuffer(
     UInt32 dwDesiredAccess,
     UInt32 dwShareMode,
     IntPtr secutiryAttributes,
     UInt32 flags,
     IntPtr screenBufferData
     );
        public static int nScreenWidth = 30;
        public static int nScreenHeight = 80;

        public static ArrayList screen = new ArrayList(nScreenWidth * nScreenHeight);
        public static IntPtr hConsole = CreateConsoleScreenBuffer(0, 0x00000001, IntPtr.Zero, 1, IntPtr.Zero);

        
    }
    public static class Game
    {
        public static bool GameOver = false;
        public static void LoadGame()
        {
            while (!GameOver)
            {
                for (int x = 0; x < Shapes.nFieldWidth; x++)
                    for (int y = 0; y < Shapes.nFieldHeight; y++)
                        screen;




                WindowSize.WriteConsoleOutputCharacterA(255, "ABCDEFG", 80, ,  null);

            }
        }
    }

    public static class Shapes
    {
        public static ArrayList tetromino = new ArrayList();
        public static int nFieldWidth = 12;
        public static int nFieldHeight = 18;
        public static ArrayList pField = null;

        public static void LoadAssets()
        {
            //S Shape
            tetromino.Add(".X..");
            tetromino.Add(".XX.");
            tetromino.Add("..X.");
            tetromino.Add("....");

            //I shape
            tetromino.Add("..X.");
            tetromino.Add("..X.");
            tetromino.Add("..X.");
            tetromino.Add("..X.");

            //Z Shape
            tetromino.Add("..X.");
            tetromino.Add(".XX.");
            tetromino.Add(".X..");
            tetromino.Add("....");

            //O Shape
            tetromino.Add("....");
            tetromino.Add(".XX.");
            tetromino.Add(".XX.");
            tetromino.Add("....");

            //T Shape
            tetromino.Add("..X.");
            tetromino.Add(".XX.");
            tetromino.Add("..X.");
            tetromino.Add("....");

            //L Shape
            tetromino.Add("....");
            tetromino.Add(".XX.");
            tetromino.Add("..X.");
            tetromino.Add("..X.");

            //J Shape
            tetromino.Add("....");
            tetromino.Add(".XX.");
            tetromino.Add(".X..");
            tetromino.Add(".X..");
        }

        public static void LoadBoard()
        {
            ArrayList pField = new ArrayList(nFieldWidth * nFieldHeight);//Creat play field
            for (int x = 0; x < nFieldWidth; x++)//Board Boundry, set everything in the array to zero, unless it is on the side or bottom
                for (int y = 0; y < nFieldHeight; y++)
                    pField[y * nFieldWidth + x] = (
                        x == 0 || //if x boundy is 0 or
                        x == nFieldWidth - 1 || //if x is the width of playing field or
                        y == nFieldHeight - 1) //it is the height
                        ? 9 : 0;//if touching set value to 9, which represent the border, otherwise set to 0 as empty space
        }

    }

    public static class Rotation
    {
        //          Positions of blocks at x and y axis
        //           NORMAL                    ROTATE 90 Deg
        //              X                            X   
        //         0  1  2  3                   0  1  2  3 
        //        ____________                 ____________
        //    0  | 0  1  2  3|             0  |12  8  4  0|
        // y  1  | 4  5  6  7|          y  1  |13  9  5  1|
        //    2  | 8  9 10 11|             2  |14 10  6  2|
        //    3  |12 13 14 15|             3  |15 11  7  3|
        //       -------------                ------------- 
        //
        //                      ROTATION EQUATIONS
        //  0degrees) i = y * w + x               90degrees) i = 12 + y - (x * 4)
        //180degrees) i = 15 - (y * 4) - x       270degrees) i = 3 + y (x * 4)

        //p = piece, x = xaxis, y = yaxis, r = rotation degrees 1 thru 4
        public static int Rotate(int px, int py, int r) 
        {
            switch (r % 4)
            {
                case 0:
                    return py * 4 + px;         //0 degrees
                case 1:
                    return 12 + py - (py * 4);  //90 degrees
                case 2:
                    return 15 - (py * 4) - px;  //180 degrees
                case 3:
                    return 3 - py + (px * 4);   //270 degrees
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WindowSize.CustomScreen();
            Shapes.LoadAssets();
            Console.WriteLine(Shapes.tetromino[0]);

        }
    }
}
