using System;

namespace TrashAppDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration that chars and ints are the SAME THING!!!");
            if (('A' == (char) 65))
                Console.WriteLine("A is 65");
            else 
                Console.WriteLine("A is not 65");
            if (65 == (int) 'A')
                Console.WriteLine("65 is A");
            else
                Console.WriteLine("65 is not A");
            for (int i = 65; i < 71; i++)
                Console.WriteLine($" {(char) i}");
            for (char c = 'A'; c < 'G'; c++)
                Console.WriteLine($" {(int) c}");
        }
    }
}
