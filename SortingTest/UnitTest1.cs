using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingComparer;
using StringSorting;
using System.Collections.Generic;
using NUnit.Framework;




namespace SortingTest
{ 

    [TestClass]
    public class SortTest
    {
        private static string SUBSTRING = "s";
        private static String[] testArray = { "success", "boss", "past" };
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(new ByAlphabetOrder());
                yield return new TestCaseData(new ByReverceAlphabetOrder());
                yield return new TestCaseData(new ByIncreaseStringLength());
                yield return new TestCaseData(new ByDecreaseStringLength());
                yield return new TestCaseData(new ByIncreaseSymbolEntry { Symbol = SUBSTRING });
                yield return new TestCaseData(new ByDecreaseSymbolEntry { Symbol = SUBSTRING });
            }
        }
       
        [TestMethod, TestCaseSource("TestCases")]
        
        public void BubleSortTest(IComparer<string> comparer)
        {
            
            String[] sortedArray = Sort.BubbleSort(testArray, comparer);
            Array.Sort(testArray, comparer);
            NUnit.Framework.Assert.That(testArray, Is.EqualTo(sortedArray));
        }
    }

    
}
