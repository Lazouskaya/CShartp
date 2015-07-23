using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparer
{
    public class ByAlphabetOrder : IComparer<String>
    {
        public int Compare(String word1, String word2)
        {
            return word1.Substring(0, 1).CompareTo(word2.Substring(0, 1));
        }
    }
     public class ByReverceAlphabetOrder : IComparer<String>
    {
        public int Compare(String word1, String word2)
        {
            return -word1.Substring(0, 1).CompareTo(word2.Substring(0, 1));
        }
     }
     public class ByIncreaseStringLength : IComparer<String>
     {
         public int Compare(String word1, String word2)
         {
             return word1.Length.CompareTo(word2.Length);
         }
     }
     public class ByDecreaseStringLength : IComparer<String>
     {
         public int Compare(String word1, String word2)
         {
             return -word1.Length.CompareTo(word2.Length);
         }
     }
     public class ByIncreaseSymbolEntry : IComparer<String>
     {
         public string Symbol { get; set; }
         public int Compare(String word1, String word2)
         {
             int symbolEntries1 = word1.Split(new string[] { Symbol }, StringSplitOptions.None).Count() - 1;
             int symbolEntries2 = word2.Split(new string[] { Symbol }, StringSplitOptions.None).Count() - 1;
             return symbolEntries1.CompareTo(symbolEntries2);
         }
     }
     public class ByDecreaseSymbolEntry : IComparer<String>
     {
         public string Symbol { get; set; }
         public int Compare(String word1, String word2)
         {
             int symbolEntries1 = word1.Split(new string[] { Symbol }, StringSplitOptions.None).Count() - 1;
             int symbolEntries2 = word2.Split(new string[] { Symbol }, StringSplitOptions.None).Count() - 1;
             return -symbolEntries1.CompareTo(symbolEntries2);
         }
     }
}
