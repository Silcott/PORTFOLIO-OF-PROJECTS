using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;


namespace VectorDistanceCalculation
{
    public class VectorVar
    {
        public static Random random = new Random();
        public static int x1 = random.Next(1, 100);
        public static int y1 = random.Next(1, 100);
        public static int x2 = random.Next(1, 100);
        public static int y2 = random.Next(1, 100);
        public static int z1 = random.Next(1, 100);
        public static int z2 = random.Next(1, 100);
        public static int a1 = random.Next(1, 1000);
        public static int a2 = random.Next(1, 1000);
        //Distance Formula and Pythagorean Theorem
        public static int originA = Convert.ToInt32(Math.Sqrt(x1 * x1 + y1 * y1));
        public static int originB = Convert.ToInt32(Math.Sqrt(x2 * x2 + y2 * y2));
        public static int originC = Convert.ToInt32(Math.Sqrt(z2 * z2 + x2 * x1));//random point to use to compare against for closest origin - Two Element
        public static int originD = Convert.ToInt32(Math.Sqrt(z2 * z2 + x2 * x1));//random point to use to compare against for closest origin - Three Element
    }
    public class Points
    {
        public int ID { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int z1 { get; set; }
        public int z2 { get; set; }
        public int a1 { get; set; }
        public int a2 { get; set; }
        public int originA { get; set; }
        public int originB { get; set; }
        public int originC { get; set; }
        public int originD { get; set; }
    }
    struct Datum2
    {
        public static int numberOfPoints = 101;
        public static List<Points> points = new List<Points>(numberOfPoints);

        public void CalcDist()
        {
            for (int i = 0; i < Datum2.numberOfPoints; ++i)
            {
                VectorVar.x1 = VectorVar.random.Next(1, 100);
                VectorVar.y1 = VectorVar.random.Next(1, 100);
                VectorVar.x2 = VectorVar.random.Next(1, 100);
                VectorVar.y2 = VectorVar.random.Next(1, 100);
                VectorVar.z1 = VectorVar.random.Next(1, 100);
                VectorVar.z2 = VectorVar.random.Next(1, 100);
                //Distance Formula and Pythagorean Theorem
                VectorVar.originA = Convert.ToInt32(Math.Sqrt(VectorVar.x1 * VectorVar.x1 + VectorVar.y1 * VectorVar.y1));
                VectorVar.originB = Convert.ToInt32(Math.Sqrt(VectorVar.x2 * VectorVar.x2 + VectorVar.y2 * VectorVar.y2));
                VectorVar.originC = Convert.ToInt32(Math.Sqrt(VectorVar.z2 * VectorVar.z2 + VectorVar.x2 * VectorVar.x1));
                //Ensure only positive numbers for X Vectors
                double distanceX = VectorVar.x2 - VectorVar.x1;
                if (distanceX < 0)
                {
                    VectorVar.x2 = VectorVar.random.Next(VectorVar.x1, 100);
                    distanceX = VectorVar.x2 - VectorVar.x1;
                }
                //Ensure only positive numbers for Y Vectors
                double distanceY = VectorVar.y2 - VectorVar.y1;
                if (distanceY < 0)
                {
                    VectorVar.y2 = VectorVar.random.Next(VectorVar.y1, 100);
                    distanceY = VectorVar.y2 - VectorVar.y1;
                }
                //Ensure only positive numbers for Y Vectors
                double distanceZ = VectorVar.z2 - VectorVar.z1;
                if (distanceZ < 0)
                {
                    VectorVar.z2 = VectorVar.random.Next(VectorVar.z1, 100);
                    distanceZ = VectorVar.z2 - VectorVar.z1;
                }
                //Insert Points and Values into list
                points.Insert(i, new Points()
                {
                    ID = i,
                    x1 = VectorVar.x1,
                    y1 = VectorVar.y1,
                    x2 = VectorVar.x2,
                    y2 = VectorVar.y2,
                    z1 = VectorVar.z1,
                    z2 = VectorVar.z2,
                    originA = VectorVar.originA,
                    originB = VectorVar.originB,
                    originC = VectorVar.originC,
                });
            }
            foreach (var point in Datum2.points)
            {
                string x = ((point.x2 - point.x1) * (point.x2 - point.x1)).ToString();
                string y = ((point.y2 - point.y1) * (point.y2 - point.y1)).ToString();
                string z = ((point.z2 - point.z1) * (point.x2 - point.x1)).ToString();
                //Distance Formula and Pythagorean Theorem
                double lXY = Math.Sqrt(Convert.ToInt32(x) + Convert.ToInt32(y));
                double lXZ = Math.Sqrt(Convert.ToInt32(x) + Convert.ToInt32(z));
                double lYZ = Math.Sqrt(Convert.ToInt32(y) + Convert.ToInt32(z));

                Console.Write(String.Join(
                    " ",
                    $"Element: {point.ID} |",
                    $"Vectors: " +
                    $"X:[{point.x1},{point.y1}] " +
                    $"Y:[{point.x2},{point.y2}] " +
                    $"Z:[{point.z1},{point.z2}]" +
                    $"\nDistances: x => y: {lXY} | x => z: {lXZ} | y => z: {lYZ}"));
                Console.WriteLine();
                if (lXZ >= lYZ)
                    Console.Write($"Closest Vector to Z is: Y:[{point.x2},{point.y2}]");
                else
                    Console.Write($"Closest Vector to Z is: X:[{point.x1},{point.y1}]");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
    public struct Datum3
    {
        public static int numberOfPoints = 1001;
        public static List<Points> points = new List<Points>(numberOfPoints);

        public void CalcDist()
        {
            for (int i = 0; i < Datum3.numberOfPoints; ++i)
            {
                VectorVar.x1 = VectorVar.random.Next(1, 1000);
                VectorVar.y1 = VectorVar.random.Next(1, 1000);
                VectorVar.x2 = VectorVar.random.Next(1, 1000);
                VectorVar.y2 = VectorVar.random.Next(1, 1000);
                VectorVar.z1 = VectorVar.random.Next(1, 1000);
                VectorVar.z2 = VectorVar.random.Next(1, 1000);
                VectorVar.a1 = VectorVar.random.Next(1, 1000);
                VectorVar.a2 = VectorVar.random.Next(1, 1000);

                //Ensure only positive numbers for X Vectors
                double distanceX = VectorVar.y1 - VectorVar.x1;
                if (distanceX < 0)
                {
                    VectorVar.x2 = VectorVar.random.Next(VectorVar.x1, 1000);
                    distanceX = VectorVar.y1 - VectorVar.x1;
                }
                //Ensure only positive numbers for Y Vectors
                double distanceY = VectorVar.y2 - VectorVar.x2;
                if (distanceY < 0)
                {
                    VectorVar.y2 = VectorVar.random.Next(VectorVar.y1, 1000);
                    distanceY = VectorVar.y2 - VectorVar.x2;
                }
                //Ensure only positive numbers for Z Vectors
                double distanceZ = VectorVar.z2 - VectorVar.z1;
                if (distanceZ < 0)
                {
                    VectorVar.z2 = VectorVar.random.Next(VectorVar.z1, 1000);
                    distanceZ = VectorVar.z2 - VectorVar.z1;
                }
                //Ensure only positive numbers for A Vectors
                double distanceA = VectorVar.a2 - VectorVar.a1;
                if (distanceA < 0)
                {
                    VectorVar.a2 = VectorVar.random.Next(VectorVar.a1, 1000);
                    distanceA = VectorVar.a2 - VectorVar.a1;
                }
                //Insert Points and Values into list
                points.Insert(i, new Points()
                {
                    ID = i,
                    x1 = VectorVar.x1,
                    y1 = VectorVar.y1,
                    x2 = VectorVar.x2,
                    y2 = VectorVar.y2,
                    z1 = VectorVar.z1,
                    z2 = VectorVar.z2,
                    a1 = VectorVar.a1,
                    a2 = VectorVar.a2,
                });
            }

            foreach (var point in Datum3.points)
            {
                Console.Clear();
                Graphics g;
                using (g = Graphics.FromHwnd(IntPtr.Zero))
                {
                    g.Clear(Color.Black);
                }

                //Distance Formula and Pythagorean Theorem
                double lXY = Math.Sqrt(((point.x2 - point.x1)*(point.x2 - point.x1))  + ((point.y2 - point.y1)*(point.y2 - point.y1)));//x => y
                double lXZ = Math.Sqrt(((point.z1 - point.x1)*(point.z1 - point.x1))  + ((point.z2 - point.y1)*(point.z2 - point.y1)));//x => z
                double lYZ = Math.Sqrt(((point.z1 - point.x2)*(point.z1 - point.x2))  + ((point.z2 - point.y2)*(point.z2 - point.y2)));//y => z
                double lXA = Math.Sqrt(((point.a1 - point.x1)*(point.a1 - point.x1))  + ((point.a2 - point.y1)*(point.a2 - point.y1)));//x => a
                double lYA = Math.Sqrt(((point.a1 - point.x2)*(point.a1 - point.x2))  + ((point.a2 - point.y2)*(point.a2 - point.y2)));//y => a
                double lZA = Math.Sqrt(((point.a1 - point.z1)*(point.a1 - point.z1))  + ((point.a2 - point.z2)*(point.a2 - point.z2)));//z => a

                //double lXY = Math.Sqrt(Convert.ToInt32(xSquared) + Convert.ToInt32(ySquared));
                //double lXZ = Math.Sqrt(Convert.ToInt32(xSquared) + Convert.ToInt32(zSquared));
                //double lYZ = Math.Sqrt(Convert.ToInt32(ySquared) + Convert.ToInt32(zSquared));
                //double lXA = Math.Sqrt(Convert.ToInt32(xSquared) + Convert.ToInt32(aSquared));
                //double lYA = Math.Sqrt(Convert.ToInt32(ySquared) + Convert.ToInt32(aSquared));
                //double lZA = Math.Sqrt(Convert.ToInt32(zSquared) + Convert.ToInt32(aSquared));

                //USE FOR CONSOLE TEXT
                //Console.Write(String.Join(
                //    " ",
                //    $"Element: {point.ID}\n",
                //    $"  Vectors: \n" +
                //    $"      X:[{point.x1},{point.y1}]\n" +
                //    $"      Y:[{point.x2},{point.y2}]\n" +
                //    $"      Z:[{point.z1},{point.z2}]\n" +
                //    $"      A:[{point.a1},{point.a2}] -- Target Point\n" +
                //    $"    Distances: " +
                //    $"\n        x => y: {lXY}" +
                //    $"\n        x => z: {lXZ}" +
                //    $"\n        y => z: {lYZ}" +
                //    $"\n        x => a: {lXA}" +
                //    $"\n        y => a: {lYA}" +
                //    $"\n        z => a: {lZA}"));

                //USE FOR GRAPHIC TEXT
                Console.WriteLine();
                Draw.DrawFont(1100, 50, $"Element: {point.ID}\n" +
                    $"  Vectors: \n" +
                    $"      X:[{point.x1},{point.y1}]\n" +
                    $"      Y:[{point.x2},{point.y2}]\n" +
                    $"      Z:[{point.z1},{point.z2}]\n" +
                    $"      A:[{point.a1},{point.a2}] -- Target Point\n" +
                    $"    Distances: " +
                    $"\n        x => y: {lXY}" +
                    $"\n        x => z: {lXZ}" +
                    $"\n        y => z: {lYZ}" +
                    $"\n        x => a: {lXA}" +
                    $"\n        y => a: {lYA}" +
                    $"\n        z => a: {lZA}", Brushes.GhostWhite);
                Draw.DrawFont(point.x1, point.y1 + 20, $"X", Brushes.LawnGreen);
                Draw.DrawFont(point.x2, point.y2 + 20, $"Y", Brushes.LawnGreen);
                Draw.DrawFont(point.z1, point.z2 + 20, $"Z", Brushes.LawnGreen);
                Draw.DrawFont(point.a1, point.a2 + 40, $"A", Brushes.LawnGreen);

                List<double> lowestNum = new List<double>();
                lowestNum.Add(lXA);
                lowestNum.Add(lYA);
                lowestNum.Add(lZA);
                double lowestDistance = lowestNum.Min();
                int time = 1500;//900+ normal, 100 fast
                if (lowestDistance == lXA)
                {
                    //Console.Write($"    Closest Vector to A is: X:[{point.x1},{point.y1}]");
                    Draw.DrawCircle(Pens.Red, point.x1 - 10, point.y1 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.x2 - 10, point.y2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.z1 - 10, point.z2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.a1 - 10, point.a2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawLine(Color.Red, point.x1, point.y1, point.x2, point.y2);//x => y
                    Draw.DrawLine(Color.Red, point.x2, point.y2, point.z1, point.z2);//y => z
                    Draw.DrawLine(Color.Red, point.z1, point.z2, point.x1, point.y1);//z => x
                    Draw.DrawLine(Color.Red, point.z1, point.z2, point.x2, point.y2);//z => y
                    Draw.DrawLine(Color.White, point.z1, point.z2, point.a1, point.a2);//z => a
                    Draw.DrawLine(Color.White, point.a1, point.a2, point.x1, point.y1);//a => x
                    Draw.DrawLine(Color.White, point.a1, point.a2, point.x2, point.y2);//a => y
                    Draw.DrawLine(Color.YellowGreen, point.x1, point.y1, point.a1, point.a2);
                    Draw.DrawCircle(Pens.Red, point.a1 - 10, point.a2 - 10, 30, 30, "#ffff00");
                    Draw.DrawFont(point.x1 + 20, point.y1 + 20, $"Distance: {lXA}", Brushes.OrangeRed);
                    Draw.DrawFont(1100, 600, $"Closest Vector to A is: X:[{point.x1},{point.y1}]", Brushes.YellowGreen);
                    Thread.Sleep(time);
                }
                else if (lowestDistance == lYA)
                {
                    //Console.Write($"    Closest Vector to A is: Y:[{point.x2},{point.y2}]");
                    Draw.DrawCircle(Pens.Red, point.x1 - 10, point.y1 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.x2 - 10, point.y2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.z1 - 10, point.z2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.a1 - 10, point.a2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawLine(Color.Red, point.x1, point.y1, point.x2, point.y2);//x => y
                    Draw.DrawLine(Color.Red, point.x2, point.y2, point.z1, point.z2);//y => z
                    Draw.DrawLine(Color.Red, point.z1, point.z2, point.x1, point.y1);//z => x
                    Draw.DrawLine(Color.Red, point.z1, point.z2, point.x2, point.y2);//z => y
                    Draw.DrawLine(Color.White, point.z1, point.z2, point.a1, point.a2);//z => a
                    Draw.DrawLine(Color.White, point.a1, point.a2, point.x1, point.y1);//a => x
                    Draw.DrawLine(Color.White, point.a1, point.a2, point.x2, point.y2);//a => y
                    Draw.DrawLine(Color.YellowGreen, point.x2, point.y2, point.a1, point.a2);
                    Draw.DrawCircle(Pens.Red, point.a1 - 10, point.a2 - 10, 30, 30, "#ffff00");
                    Draw.DrawFont(point.x2 + 20, point.y2 + 20, $"Distance: {lYA}", Brushes.OrangeRed);
                    Draw.DrawFont(1100, 600, $"Closest Vector to A is: Y:[{point.x2},{point.y2}]", Brushes.YellowGreen);
                    Thread.Sleep(time);
                }
                else if (lowestDistance == lZA)
                {
                    //Console.Write($"    Closest Vector to A is: Z:[{point.z1},{point.z2}]");
                    Draw.DrawCircle(Pens.Red, point.x1 - 10, point.y1 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.x2 - 10, point.y2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.z1 - 10, point.z2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawCircle(Pens.Red, point.a1 - 10, point.a2 - 10, 20, 20, "#FFF0FFFF");
                    Draw.DrawLine(Color.Red, point.x1, point.y1, point.x2, point.y2);//x => y
                    Draw.DrawLine(Color.Red, point.x2, point.y2, point.z1, point.z2);//y => z
                    Draw.DrawLine(Color.Red, point.z1, point.z2, point.x1, point.y1);//z => x
                    Draw.DrawLine(Color.Red, point.z1, point.z2, point.x2, point.y2);//z => y
                    Draw.DrawLine(Color.White, point.z1, point.z2, point.a1, point.a2);//z => a
                    Draw.DrawLine(Color.White, point.a1, point.a2, point.x1, point.y1);//a => x
                    Draw.DrawLine(Color.White, point.a1, point.a2, point.x2, point.y2);//a => y
                    Draw.DrawLine(Color.YellowGreen, point.z1, point.z2, point.a1, point.a2);
                    Draw.DrawCircle(Pens.Red, point.a1 - 10, point.a2 - 10, 30, 30, "#ffff00");
                    Draw.DrawFont(point.z1 + 20, point.z2 + 20, $"Distance: {lZA}", Brushes.OrangeRed);
                    Draw.DrawFont(1100, 600, $"Closest Vector to A is: Z:[{point.z1},{point.z2}]", Brushes.YellowGreen);
                    Thread.Sleep(time);

                }
                Console.WriteLine();
                //Console.WriteLine("#####################################################");
                //Draw.DrawRectangleWhite(0, 0, 1920, 1080);
                Draw.DrawFont(1100, 650, $" -Press Enter to Continue-", Brushes.DeepSkyBlue);
                Console.ReadLine();
            }
        }
    }

    public static class Draw
    {
        public static void DrawCircle(Pen color, int x, int y, int w, int h, string hexcolor)
        {
            Graphics g;
            //Outline Circle
            using (g = Graphics.FromHwnd(IntPtr.Zero))
            {
                g.DrawEllipse(color, x, y, w, h);
                //Fill Circle
                using (Brush b = new SolidBrush(ColorTranslator.FromHtml(hexcolor)))
                {
                    g.FillEllipse(b, x, y, w, h);
                }
            }
        }
        public static void DrawRectangle(int alpha, int red, int green, int blue, int x, int y, int w, int h)
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            // draw the rectangle
            Brush b = new SolidBrush(Color.FromArgb(alpha, red, green, blue));
            g.FillRectangle(b, new Rectangle(x, y, w, h));
        }
        public static void DrawLine(Color color, int x, int y, int w, int h)
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            Pen myPen = new Pen(color);
            myPen.Width = 5;
            g.DrawLine(myPen, x, y, w, h);
        }
        public static void DrawFont(int x, int y, string text, Brush color)
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            using (Font font1 = new Font("Times New Roman", 32, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                PointF pointF1 = new PointF(x, y);
                g.DrawString(text, font1, color, pointF1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Reset color
            Console.BackgroundColor = ConsoleColor.Black;
            //Fullscreen Method
            FullScreen.WideScreenMethod();
            Program CallingTheRealMain = new Program();
            CallingTheRealMain.Main2();
        }
        public void Main2()
        {
            Console.WriteLine("This is the Vector Distance Exercise");
            bool again = true;
            while (again)
            {
                Console.Write("\nEnter 2 to calculate 2 element vector, " +
                                  "3 to calculate 3 element vector, " +
                                  "9 to quit:");
                string input = Console.ReadLine();
                if (input.Equals("2"))
                {


                    Console.WriteLine("\n two element vector");
                    Datum2 d2 = new Datum2();
                    d2.CalcDist();
                    TryAgainQuestion();
                }
                else if (input.Equals("3"))
                {
                    Console.WriteLine("\n three element vector");
                    Datum3 d3 = new Datum3();
                    d3.CalcDist();
                    TryAgainQuestion();
                }
                else if (input.Equals("9"))
                {


                    TryAgainQuestion();

                    //again = false;
                }
                else
                {
                    Console.WriteLine("Try again, incorrect response");
                    TryAgainQuestion();
                }
                Console.WriteLine("Have a great day!");
                Environment.Exit(0);
            }

        }
        public void TryAgainQuestion()
        {
            Console.Write("Want to try again? [Y] or [N]");
            var response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                Main2();
            }
            else
            {
                Console.WriteLine("Have a great day!");
                Environment.Exit(0);
            }
        }
    }
    public static class FullScreen
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
        public static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
    }
}

//Programming Exercise 11
//Vector Distance Calculation
//C# Step by Step
//1 Introduction to exercise
//A vector is a mathematical object that represents both magnitude and direction. For example, a projectile
//fired from a gun barrel can be modeled as a vector because it has both magnitude and direction. An aircraft
//in flight can be modeled as a vector because it has both magnitude and direction. A parachutist jumping
//from an airplane can be modeled as a vector because he has both magnitude and direction. The direction
//of the parachutist is (generally) down, and the magnitude is the velocity of the fall, which (hopefully) will
//become much slower at some point before he hits the ground.
//In science and technology, we frequently have need to compare vectors and compute the closest vectors.
//For example, a dating service might have a personality profile of 100 points, modeled as a vector, and need
//to compare the personality profiles of all members to determine the closest matches. A bank may have a
//customer profile of 1000 points, modeled as a vector, and need to group its customers into similar categories.
//A biologist may have a genetic profile consisting of 1,000,000 points, modeled as a vector, and need to find
//the closest match.
//How do we calculate the distance between two vectors? There a number of ways, but the simplest and
//easiest way is to use what’s called Euclidean distance, which is nothing more than the practical application
//of the Pythagorean theorem. Recall that the Pythagorean theorem allows us to compute the length of the
//hypotenuse of a right triangle, given the length of two sides, x and y, like this:
//h =
//p
//x
//2 + y
//2(1)
//Suppose we don’t have the length of two sides, but two points. What do we do then? If we consider points
//on a two dimensional grid, a point consists of an x location and a y location, like this: (0, 0).For this point,
//the x location is at 0 on the X axis, and the y location is at 0 on the Y axis. When we have two points, we
//simply subtract the second point from the first point. If we have two points, (1, 1) and (4,5), we do it like
// this:
//x = x2 − x1 =⇒ x = 4 − 1 =⇒ x = 3(2)
//y = y2 − y1 =⇒ y = 5 − 1 =⇒ y = 4(3)
//In this case, the length of x is 3, the length of y is 4, and the distance between the two points is 5. We
//calculate this by the Pythagorean formula.
//L =
//p
//x
//2 + y
//2
//L =
//p
//(x2 − x1)
//2 + (y2 − y1)
//2
//L =
//p
//(4 − 1)2 + (5 − 1)2
//L =
//p
//3
//2 + 42
//L =
//√
//9 + 16
//L =
//√
//25
//L = 5
//1
//2 FIRST PART, 70 POINTS
//Now, suppose we have three two-dimensional vectors, which we can think of as points, like this:
//1. (1, 1)
//2. (4, 5)
//3. (5, 4)
//What is the closest pair of points? See figure 1.
//Figure 1: Calculate distance between three points
//We can compare each pair of points and compute the Euclidean distance, like this:
//p
//(4 − 1)2 + (5 − 1)2 = 5
//p
//(5 − 1)2 + (4 − 1)2 = 5
//p
//(4 − 5)2 + (5 − 4)2 =
//√
//2 ≈ 1.4142
//The points (5,4) and (4,5) are much closer to each other than (1,1) is to (5,4) or (1,1) is to (4,5). This is
//obvious by looking at figure 1.
//What happens if we have vectors of more than two points, i.e., we have points in three-dimensional space,
//or higher? For example, our points might look like (423, 632, 293). We simply expand the Pythagorean
//formula. This is the formula for three-dimensional space:
//h =
//p
//x
//2 + y
//2 + z
//2 (4)
//For n-dimensional space, we can expand the formula to include all the dimensions that we have, like this:
//h =
//p
//(p1)
//2 + (p2)
//2 + . . . + (pn)
//2 (5)
//2 First part, 70 points
//In the first two parts, we will find the two closest two-dimensional vectors, modeled as points in a two dimensional space. Write a console application that creates some sort of data structure that contains two
//integers, x and y, as random numbers between 1 and 100. Do not use the built-in class Point, rather, build
//your own data structure. Please note, we will think of these objects as points, but in reality they are vectors.
//Then, create some sort of collection that contains 100 of these points.
//Page 2, Revised on October 5, 2020 by Charles Carter
//6 CODE TEMPLATE
//3 Second part, 80 points
//Write a function that takes two points and computes the Euclidean distance between them. Then, write
//a function that iterates through your collection, compares each point to every other point and reports the
//closest two points.
//4 Third part, 90 points
//In the second two parts, we will find the two closest three-dimensional vectors, modeled as points in a three dimensional space. Write a console application that creates some sort of data structure that contains three
//integers, x, y, and z, as random numbers between 1 and 1000. Do not use any built-in class but build your
//own data structure. Please note, we will think of these objects as points, but in reality they are vectors.
//Then, create some sort of collection that contains 1000 of these points.
//5 Fourth part, 100 points
//Write a function that takes two three-dimensional points and computes the Euclidean distance between
//them. Then, write a function that iterates through your collection, compares each point to every other point
//and reports the closest two points. Your output for the three point vectors might look like figure 2.
//Figure 2: Result of vector distance calculation for three points
//6 Code template
//You do not have to use the following code template. However, it may prove useful as a starting point. This is
//the Main() method of my implementation if this exercise. I created two structs named Datum2 and Datum3.
//You can create them as classes if you like. For each, I wrote a void method named CalcDist, which takes
//no parameters. You must write the code creating the structs (or classes) and the appropriate method(s).
//1 s t a t i c v oid Main ( s t r i n g [ ] a r g s )
//2 {
//    3 C on s ole . WriteLine( ” This i s the Vecto r Di s t a n c e e x e r c i s e ” );
//    4 b o ol a g ai n = true;
//    5 w hil e(a g ai n)
//6 {
//        7 C on s ole .Write( ”\nEnter 2 t o c a l c u l a t e 2 elemen t v e c t o r, ” +
//        8 ” 3 t o c a l c u l a t e 3 elemen t v e c t o r, 9 t o q ui t: ” );
//        9 s t r i n g input = C on s ole.ReadLine();
//        Page 3, Revised on October 5, 2020 by Charles Carter
//6 CODE TEMPLATE
//10 i f(input.Equals ( ”2” ) )
//11 {
//            12 C on s ole . W riteLine( ”\n two elemen t v e c t o r ” );
//            13 Datum2 d2 = new Datum2();
//            14 d2.C al cDi s t();
//            15 }
//        16 e l s e i f(input.Equals ( ”3” ) )
//17 {
//            18 C on s ole . W riteLine( ”\n t h r e e elemen t v e c t o r ” );
//            19 Datum3 d3 = new Datum3();
//            20 d3.C al cDi s t();
//            21 }
//        22 e l s e i f(input.Equals ( ”9” ) )
//23 a g ai n = f a l s e; // t o e x i t
//        24 e l s e
//25 C on s ole . W riteLine( ”\n Didn ’ t r e c o g n i z e i n p u t ” );
//        26 }
//    27 System.Environment.Exi t( 0 ) ;
//    28 }
//The document that I would turn in as an answer to this exercise would look like this, with . . . representing
//the code that you would write.
//1 using System ;
//2
//3 namespace V e c t o rDi s t a n c e
//4 {
//5 s t r u c t Datum2
//6 {
//7 // your code h e r e
//8 . . .
//9 }
//10
//11 s t r u c t Datum3
//12 {
//13 // your code h e r e
//14 . . .
//15 }
//16
//17 c l a s s Program
//18 {
//19 s t a t i c v oid Main ( s t r i n g [ ] a r g s )
//20 {
//    21 // your code h e r e
//22. . .
//23 }
//24 }
//25 }
//Page 4, 