using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            reverseWord();
        }

        // You’re given: Write a method to reverse a string
        //first I would write the question
        // make sure you understand what they want. ask qualifying questions.
        // Someone tells me to reverse a string, my question would be 'reverse the words in the string or the letters' as an example:
        //example: Hello World!
        // output: World! Hello
        // or 
        // output: !dlroW olleH



        static void reverseWord()
        {
            // here i'm prompting the user to enter a string that they want me to reverse
            Console.WriteLine("Enter a string and I will reverse it.");

            // here i'm storing that input in the variable 'input'
            string input = Console.ReadLine();

            //here i'm creating an empty string called 'reverse
            string reverse = string.Empty;

            // now with my for loop, my i variable is starting at the end of the input they gave me.
            //and i'm saying while i is greater than or = to 0, decrement (i--)
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // so now i'm iterating through my string backwards and its storing each element in my new variable.
                reverse += input[i];
            }

            //and lastly i'm printing the new reverse variable.
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}


