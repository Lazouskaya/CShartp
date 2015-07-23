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
            checkArguments(firstNum,secondNum);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int remainder = 1;
            while (firstNum % secondNum != 0)
            {
                remainder=firstNum%secondNum;
                firstNum = secondNum;
                secondNum = remainder;
            }
            getExecutionTime(stopWatch);
            return remainder;
        }

        public static int Evclidean(params int[] numbers)
        {
            checkArguments(numbers);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int remainder = 1;
            while (firstNum % secondNum != 0)
            {
                remainder = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = remainder;
            }
            getExecutionTime(stopWatch);
            return remainder;
        }

        private static void getExecutionTime(Stopwatch stopWatch)
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
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
    }
}
