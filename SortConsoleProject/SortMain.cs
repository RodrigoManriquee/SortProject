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
            string[] stringArray = { "banana", "apple", "orange", "grape", "kiwi" };

            Console.WriteLine("Sorted integer array:");
            foreach (var item in intArray.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nSorted string array:");
            foreach (var item in stringArray.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
