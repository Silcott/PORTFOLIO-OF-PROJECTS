using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TasksAndParallelProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("C# quiz 23");
            Console.WriteLine("Enter the highest number to find primes");
            string input = Console.ReadLine();
            Console.WriteLine("Press 1 for no Parallel Processing");
            Console.WriteLine("Press 2 for Parallel Processing");
            Console.WriteLine("Press 3 to exit");
            string answer = Console.ReadLine();
            long findTo = long.Parse(input);
            List<long> primes = new List<long>();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (answer == "1")
            {
                for (int i = 1; i < findTo; i++)
                {
                    bool foundP = isPrime(i);
                    Console.Write($"from foundP: i is {i}");
                    if (foundP)
                    {
                        primes.Add(i);
                    }
                }
            }
            else if (answer == "2")
            {
                Parallel.For(0, findTo + 1, x =>
                {
                    bool foundP = isPrime(x);
                    if (foundP)
                    {
                        primes.Add(x);
                    }
                });
            }
            else if (answer == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect Response, Try Again");
                goto Start;
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            //output
            Console.WriteLine("PRINTING PRIMES");
            foreach (int element in primes)
                Console.WriteLine($"{element}");
            Console.WriteLine($"\n\nfound primes in time: {ts}");
            goto Start;
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
            }
            return isP;
        }
        
    }
}
