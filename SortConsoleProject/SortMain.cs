using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsoleProject
{
    class SortMain
    {
        static void Main(string[] args)
        {
            int[] intArray = { 4, 2, 7, 1, 9, 5 };
            int[] intArrays = { 5, 2, 7, 1, 9, 5 };
            int[] test = { 5, 2, 7, 1, 9, 5 };

            Console.WriteLine("Original integer array:");
            PrintIntArray(intArray);
            SortableArray.SortIntArray(intArray);
            Console.WriteLine("\nSorted integer array:");
            PrintIntArray(intArray);
            Console.WriteLine();

            string[] stringArray = { "banana", "apple", "orange", "grape", "kiwi" };

            Console.WriteLine("\nOriginal string array:");
            PrintStringArray(stringArray);
            SortableArray.SortStringArray(stringArray);
            Console.WriteLine("\nSorted string array:");
            PrintStringArray(stringArray);
            Console.WriteLine();
        }

        static void PrintIntArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        static void PrintStringArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }

    public class SortableArray
    {
        public static void SortIntArray(int[] array)
        {
            Array.Sort(array);
        }

        public static void SortStringArray(string[] array)
        {
            Array.Sort(array);
        }
    }
}
