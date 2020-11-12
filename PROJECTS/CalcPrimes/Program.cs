using System;

namespace CalcPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Write prime numbers between 0 and 100.
            //
            Console.WriteLine("--- Primes between 0 and 100 ---");
            for (int i = 0; i < 100; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);
                }
            }
            //
            // Write prime numbers between 10000 and 10100
            //
            Console.WriteLine("--- Primes between 10000 and 10100 ---");
            for (int i = 10000; i < 10100; i++)
            {
                if (PrimeTool.IsPrime(i))
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);
                }
            }

        }
        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                // Test whether the parameter is a prime number.
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                // Note:
                // ... This version was changed to test the square.
                // ... Original version tested against the square root.
                // ... Also we exclude 1 at the end.
                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }
                return candidate != 1;
            }
        }
    }
}
