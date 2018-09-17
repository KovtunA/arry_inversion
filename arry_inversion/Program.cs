using System;

namespace arry_inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            fillArrayWithRandomNumbers(arr);

            Console.WriteLine("Random array:\n");
            printArray(arr);

            Console.WriteLine("\nInverted array with built in function: \n ");
            Array.Reverse(arr);
            printArray(arr);

            Console.WriteLine("\nInverted array with function: \n ");
            printArray(reverse(arr));
        }

        static int[] reverse(int[] array)
        {
            var res = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--) { res[i] = array[array.Length - 1 - i]; }
            return res;
        }

        static void fillArrayWithRandomNumbers(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1000) - 500;
            }
        }

        static void printArray(int[] massive)
        {
            foreach (int value in massive) { Console.WriteLine(value); }
        }
    }
}