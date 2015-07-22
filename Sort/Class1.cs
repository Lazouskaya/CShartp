using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringSorting
{
    public static class Sort
    {
        public static String[] swap(String[] array,int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            return array;
        }

        public static String[] BubbleSort(String[] sourceArray, IComparer<String> Comparer)
        {
            for (int i = 0; i < sourceArray.Length; i++)
            {
                for (int j = i + 1; j < sourceArray.Length; j++)
                {

                    if (Comparer.Compare(sourceArray[j],sourceArray[i])==-1)
                    {
                        swap(sourceArray,i,j);
                    }
                }
            }
            return sourceArray;
        }
    }
}
