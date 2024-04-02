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

            Console.WriteLine("Original integer array:");
            PrintIntArray(intArray);

            SortableArray.SortIntArray(intArray);

            Console.WriteLine("\nSorted integer array:");
            PrintIntArray(intArray);
        }
        static void PrintIntArray(int[] array)
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
    }
}
