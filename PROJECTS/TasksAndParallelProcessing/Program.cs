using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TasksAndParallelProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# quiz 23");
            Console.WriteLine("Enter the highest number to find primes");
            string input = Console.ReadLine();
            long findTo = long.Parse(input);
            List<long> primes = new List<long>();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 1; i < findTo; i++)
            {
                bool foundP = isPrime(i);
                //Console.WriteLine($"from foundP: i is {i}");
                if (foundP)
                {
                    primes.Add(i);
                }


            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            //output
            Console.WriteLine("PRINTING PRIMES");
            foreach (int element in primes)
                Console.WriteLine($"{element}");
            Console.WriteLine($"\n\nfound primes in time: {ts}");
        }

        private static bool isPrime(long n)
        {
            bool isP = true;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    isP = false;
                    break;
                }

                return isP;
            }
        }
    }
}
