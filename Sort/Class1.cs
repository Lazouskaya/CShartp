using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringSorting
{
    public static class Sort
    {
        public static String[] ByAlphabetOrder(String[] SourceArray)
        {
            return ByAlphabet(SourceArray, -1);
        }

        public static String[] ByReverceAlphabetOrder(String[] SourceArray)
        {
            return ByAlphabet(SourceArray, 1);
        }

        public static String[] ByDecreaseStringLength(String[] SourceArray)
        {
            return ByStringLength(SourceArray, 1);
        }

        public static String[] ByIncreaseStringLength(String[] SourceArray)
        {
            return ByStringLength(SourceArray, -1);
        }

        public static String[] ByIncreaseSymbolEntry(String[] SourceArray, String symbol)
        {
            return BySymbolEntry(SourceArray, symbol, -1);
        }

        public static String[] ByDecreaseSymbolEntry(String[] SourceArray, String symbol)
        {
            return BySymbolEntry(SourceArray, symbol, 1);
        }

        public static String[] ByAlphabet(String[] SourceArray, int Order)
        {
            for (int i = 0; i < SourceArray.Length; i++)
            {
                for (int j = i + 1; j < SourceArray.Length; j++)
                {
                    if (SourceArray[j].Substring(0, 1).CompareTo(SourceArray[i].Substring(0, 1)) == Order)
                    {
                        var temp = SourceArray[i];
                        SourceArray[i] = SourceArray[j];
                        SourceArray[j] = temp;
                    }
                }
            }
            return SourceArray;
        }

        public static String[] ByStringLength(String[] SourceArray, int Order)
        {
            for (int i = 0; i < SourceArray.Length; i++)
            {
                for (int j = i + 1; j < SourceArray.Length; j++)
                {
                    if (SourceArray[j].Length.CompareTo(SourceArray[i].Length) == Order)
                    {
                        var temp = SourceArray[i];
                        SourceArray[i] = SourceArray[j];
                        SourceArray[j] = temp;
                    }
                }
            }
            return SourceArray;
        }

        public static String[] BySymbolEntry(String[] SourceArray, string symbol, int Order)
        {
            for (int i = 0; i < SourceArray.Length; i++)
            {
                for (int j = i + 1; j < SourceArray.Length; j++)
                {
                    int Jsymbols = SourceArray[j].Split(new string[] { symbol }, StringSplitOptions.None).Count() - 1;
                    int Isymbols = SourceArray[i].Split(new string[] { symbol }, StringSplitOptions.None).Count() - 1;
                    if (Jsymbols.CompareTo(Isymbols) == Order)
                    {
                        var temp = SourceArray[i];
                        SourceArray[i] = SourceArray[j];
                        SourceArray[j] = temp;
                    }
                }
            }
            return SourceArray;
        }

    }
}
