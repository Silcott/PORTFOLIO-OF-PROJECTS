using System;
using System.Diagnostics;

namespace CalculatePi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Pi");
            //4/1 - 4/3  + 4/5 - 4/7 + 4/9 - 4/11 etc.
            long LENGTH = 10000000;
            double NUM = 4.0;
            double Pi = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 1; i < LENGTH;)
            {
                Pi += NUM / i;
                i += 2;
                Pi -= NUM / i;
                i += 2;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(Pi);
        }
    }
}

