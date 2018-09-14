﻿using System;

namespace arry_inversion
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (new Random()).Next(1000) - 500;
            }

            //var str = string.Join("\n ", arr);
            //Console.WriteLine($"Random array:\n [{str}]");
            Console.WriteLine("Random array:\n");
            printArray(arr);

            Console.WriteLine("\nInverted array with built in function: \n ");
            Array.Reverse(arr);
            printArray(arr);

            //foreach (int value in arr)    {Console.WriteLine(value);}

            Console.WriteLine("\nInverted array with function: \n ");

            printArray(reverse(arr));
           
            //foreach (int value in reverse(arr))  { Console.WriteLine(value); }

        }

        static int[] reverse(int[] array) 
        {
            var res = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--) { res[i] = array[array.Length - 1 - i]; }
            return res;
        }

        static void printArray(int[] massive)
        {
            foreach (int value in massive) {
                Console.WriteLine(value);
            }
        }
    }
}