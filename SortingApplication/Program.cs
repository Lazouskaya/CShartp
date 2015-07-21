using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringSorting;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Array = { "key", "monkey", "apple" };
            Console.WriteLine("Source Array:");
            WriteArray(Array);
            String[] SortedArray = Sort.ByAlphabetOrder(Array);
            Console.WriteLine("By alphabet order:");
            WriteArray(SortedArray);
            SortedArray = Sort.ByReverceAlphabetOrder(Array);
            Console.WriteLine("By reverce alphabet order:");
            WriteArray(SortedArray);
            SortedArray = Sort.ByIncreaseStringLength(Array);
            Console.WriteLine("By increase string length:");
            WriteArray(SortedArray);
            SortedArray = Sort.ByDecreaseStringLength(Array);
            Console.WriteLine("By decrease string length:");
            WriteArray(SortedArray);
            SortedArray = Sort.ByIncreaseSymbolEntry(Array, "o");
            Console.WriteLine("By increase symbol entry:");
            WriteArray(SortedArray);
            SortedArray = Sort.ByDecreaseSymbolEntry(Array, "o");
            Console.WriteLine("By decrease symbol entry:");
            WriteArray(SortedArray);
            Console.ReadKey(); 
        }

        public static void WriteArray(String[] Array)
        {
            foreach (String word in Array)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }
    }
}
