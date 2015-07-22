using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingComparer;
using StringSorting;

namespace SortingApplication
{
   
    class Program
    {
        static ByAlphabetOrder byAlphabet = new ByAlphabetOrder();
        static ByReverceAlphabetOrder byReverceAlphabet = new ByReverceAlphabetOrder();
        static ByIncreaseStringLength byIncreaseStringLength = new ByIncreaseStringLength();
        static ByDecreaseStringLength byDecreaseStringLength = new ByDecreaseStringLength();
        static ByIncreaseSymbolEntry byIncreaseSymbolEntry = new ByIncreaseSymbolEntry();
        static ByDecreaseSymbolEntry byDecreaseSymbolEntry = new ByDecreaseSymbolEntry();
        static void Main(string[] args)
        {
            String[] array = { "success", "boss", "pasta" };
            Console.WriteLine("Source Array:");
            WriteArray(array);
            String[] sortedArray = Sort.BubbleSort(array, byAlphabet);
            Console.WriteLine("By alphabet order:");
            WriteArray(sortedArray);
            sortedArray = Sort.BubbleSort(array,byReverceAlphabet);
            Console.WriteLine("By reverce alphabet order:");
            WriteArray(sortedArray);
            sortedArray = Sort.BubbleSort(array,byIncreaseStringLength);
            Console.WriteLine("By increase string length:");
            WriteArray(sortedArray);
            sortedArray = Sort.BubbleSort(array,byDecreaseStringLength);
            Console.WriteLine("By decrease string length:");
            WriteArray(sortedArray);
            sortedArray = Sort.BubbleSort(array,byIncreaseSymbolEntry);
            Console.WriteLine("By increase symbol entry:");
            WriteArray(sortedArray);
            sortedArray = Sort.BubbleSort(array,byDecreaseSymbolEntry);
            Console.WriteLine("By decrease symbol entry:");
            WriteArray(sortedArray);
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
