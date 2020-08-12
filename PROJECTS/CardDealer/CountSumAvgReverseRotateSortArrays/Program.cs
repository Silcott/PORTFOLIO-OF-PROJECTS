using System;

namespace CountSumAvgReverseRotateSortArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aarr = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] barr = new int[] { 1, 3, 5, 7, 9 };
            int[] carr = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            double avg = 0.0;

            Console.WriteLine("Part 0, print arrays.");
            printArray(aarr);
            printArray(barr);
            printArray(carr);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Part 1, count, sum, and average arrays.");
            avg = GetAvg(aarr);
            Console.WriteLine($"array A average is {avg}.");
            avg = GetAvg(barr);
            Console.WriteLine($"array B average is {avg}.");
            avg = GetAvg(carr);
            Console.WriteLine($"array C average is {avg}.");

            Console.WriteLine("\n\nPart 2, reverse arrays.");
            Console.WriteLine("Reverse array A.");
            ReverseArray(aarr);
            Console.WriteLine("Reverse array B.");
            ReverseArray(barr);
            Console.WriteLine("Reverse array C.");
            ReverseArray(carr);

            Console.WriteLine("\n\nPart 3, rotate arrays.");
            Console.WriteLine("  rotate array A two places to the left.");
            RotateArray("L", 2, aarr);
            Console.WriteLine("  rotate array B two places to the right.");
            RotateArray("R", 2, barr);
            Console.WriteLine("  rotate array C four places to the left.");
            RotateArray("L", 4, carr);

            Console.WriteLine("\n\nPart 4, sort array C.");
            SortArray(carr);
        }

        private static void printArray(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
        }

        private static void SortArray(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                //Console.WriteLine($"var i is {i}, current element is {arr[i]}");
                for (int j = i + 1; j < len; j++)
                {
                    //Console.WriteLine($"  var j is {j}, current element is {arr[j]}");
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int e in arr)
                Console.Write($"{e} ");
            Console.WriteLine();
        }

        private static void RotateArray(string direction, int places, int[] arr)
        {
            Console.WriteLine($"direction is {direction}, places = {places}");
            int len = arr.Length;
            if (direction == "R")
                places = len - places;
            for (int i = 0; i < len; i++)
                Console.Write($"{arr[(i + places) % len]} ");
        }

        private static void ReverseArray(int[] arr)
        {
            int len = arr.Length;
            int[] rev = new int[len];
            for (int i = 0, j = len - 1; i < len; i++, j--)
            {
                //Console.WriteLine($"array A index is {i} and array B index is {j}");
                rev[j] = arr[i];
            }
            Console.Write("Reversed array is ");
            foreach (int e in rev)
                Console.Write($"{e} ");
            Console.WriteLine();

        }

        private static double GetAvg(int[] arr)
        {
            int count = 0;
            int sum = 0;
            double avg = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                sum += arr[i];
            }
            avg = (double)sum / count;
            Console.WriteLine($"array count = {count}, sum = {sum}, average = ");
            return avg;
        }
    }
}
