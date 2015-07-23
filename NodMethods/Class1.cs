using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodMethods
{
    public static class Nod
    {
        public static int Evclidean(int firstNum, int secondNum)
        {
            checkArguments(firstNum, secondNum);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int remainder = 1;
            while (firstNum % secondNum != 0)
            {
                remainder = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = remainder;
            }
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return remainder;
        }

        public static int Evclidean(params int[] numbers)
        {
            
            checkArguments(numbers);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int remainder = 1;
            int firstNum=numbers[0];
            int secondNum = numbers[1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                while (firstNum % secondNum != 0)
                {
                    remainder = firstNum % secondNum;
                    firstNum = secondNum;
                    secondNum = remainder;
                }
                firstNum = secondNum;
                secondNum = remainder;
            }
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return remainder;
        }

        private static void swap(int number1, int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        private static void checkArguments(int firstNum, int secondNum)
        {
            if (firstNum == 0 && secondNum == 0 || firstNum < 0 || secondNum < 0)
            {
                throw new ArgumentException();
            }
            if (firstNum < secondNum)
            {
                swap(firstNum, secondNum);
            }
        }
        private static void checkArguments(int[] numbers)
        {
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    throw new ArgumentException();
                }
            }
            if (numbers[0] == 0 && numbers[numbers.Length] == 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
