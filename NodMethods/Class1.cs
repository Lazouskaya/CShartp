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
            int[] numbers = {firstNum, secondNum};
            checkArguments(numbers);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            while (numbers[1] != 0)
                numbers[1] = numbers[0] % (numbers[0] = numbers[1]);
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return numbers[0];
        }

        public static int Evclidean(params int[] numbers)
        {
            
            checkArguments(numbers);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int firstNum;
            int secondNum=numbers[1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                firstNum = numbers[i];
                while (secondNum != 0)
                    secondNum = firstNum % (firstNum = secondNum);
            }
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return secondNum;
        }

        public static int Stain(int firstNum, int secondNum)
        {
            //checkArguments(firstNum, secondNum);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int remainder = 1;
            //firstNum == 0 || secondNum == 0 ? remainder = firstNum | secondNum:;
            while (firstNum % secondNum != 0)
            {
                remainder = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = remainder;
            }
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return remainder;
        }



        private static int[] checkArguments(int[] numbers)
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
            return numbers;
        }
    }
}
