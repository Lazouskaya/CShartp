using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingComparer;
using StringSorting;


namespace SortingTest
{ 

    [TestClass]
    public class UnitTest1
    {
        private static String[] testArray = { "success", "boss", "past" };
        ByAlphabetOrder byAlphabet = new ByAlphabetOrder();
        ByReverceAlphabetOrder byReverceAlphabet = new ByReverceAlphabetOrder();
        ByIncreaseStringLength byIncreaseStringLength = new ByIncreaseStringLength();
        ByDecreaseStringLength byDecreaseStringLength = new ByDecreaseStringLength();
        ByIncreaseSymbolEntry byIncreaseSymbolEntry = new ByIncreaseSymbolEntry { Symbol = "s" };
        ByDecreaseSymbolEntry byDecreaseSymbolEntry = new ByDecreaseSymbolEntry{ Symbol = "s" };
        [TestMethod]
        public void TestMethod1()
        {
            String[] sortedArray = Sort.BubbleSort(testArray, byAlphabet);
            Array.Sort(testArray,byAlphabet);
            AssertAreEqualsArrays(sortedArray);
            sortedArray = Sort.BubbleSort(testArray, byReverceAlphabet);
            Array.Sort(testArray,byReverceAlphabet);
            AssertAreEqualsArrays(sortedArray);
            sortedArray = Sort.BubbleSort(testArray, byIncreaseStringLength);
            Array.Sort(testArray,byIncreaseStringLength);
            AssertAreEqualsArrays(sortedArray);
            sortedArray = Sort.BubbleSort(testArray, byDecreaseStringLength);
            Array.Sort(testArray, byDecreaseStringLength);
            AssertAreEqualsArrays(sortedArray);
            sortedArray = Sort.BubbleSort(testArray, byIncreaseSymbolEntry);
            Array.Sort(testArray, byIncreaseSymbolEntry);
            AssertAreEqualsArrays(sortedArray);
            sortedArray = Sort.BubbleSort(testArray, byDecreaseSymbolEntry);
            Array.Sort(testArray, byDecreaseSymbolEntry);
            AssertAreEqualsArrays(sortedArray);
        }

        public void AssertAreEqualsArrays(String[] actual)
        {
            for (int i = 1; i < testArray.Length; i++)
            {
                Assert.AreEqual(actual[i], testArray[i]);
            }
        }
    }
    
}
