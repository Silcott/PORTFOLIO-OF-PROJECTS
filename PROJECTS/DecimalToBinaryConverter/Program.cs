using System;
using System.Security.Cryptography.X509Certificates;

public class ConversionExample
{
    public static void Main(string[] args)
    {
        void CallThisMethod()
        {


            string answer;
            Console.WriteLine("Press [1] or [2] for the folowing conversion:");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Binary to Decimal");
            answer = Console.ReadLine();

            if (answer == "1")
            {


                int n, i;
                int[] a = new int[10];
                Console.Write("Enter the number to convert: ");
                n = int.Parse(Console.ReadLine());
                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }
                Console.Write("Binary of the given number= ");
                for (i = i - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
            }
            else if (answer == "2")
            {


                // Binary ------> Decimal 
                int len;
                double deci = 0;

                Console.Write("Length of binary number: ");
                len = Convert.ToInt32(Console.ReadLine());

                int[] bnry = new int[len];

                for (int i = 0; i < len; i++)
                {
                    Console.Write("{0} index of binary number: ", i);
                    bnry[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Your binary number: ");
                for (int i = len - 1; 0 <= i; i--)
                {

                    Console.Write(bnry[i]);

                }

                Console.Write("\nDecimal number: ");
                for (int i = 0; i < len; i++)
                {
                    deci += (bnry[i] * Math.Pow(2, i));
                }
                Console.Write(deci);
            }
            else
            {
                Console.WriteLine("Try again");
                CallThisMethod();
            }
        }

        CallThisMethod();
        CallAnotherMethod();

        void CallAnotherMethod()
        {
            Console.WriteLine("\nDo you want to try again?");
            string tryAgain = Console.ReadLine();
            string upperTryAgain = tryAgain.ToUpper();
            if (upperTryAgain == "Y")
            {
                CallThisMethod();
            }
            else if (upperTryAgain == "N")
            {
                Console.WriteLine("Have a good day!");
            }
            else
            {
                Console.WriteLine("Try again!");
                CallAnotherMethod();
            }
        }
    }
}