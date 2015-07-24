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
        private static int EvclideanNod(int greater, int less)
        {
            while (less != 0)
                less = greater % (greater = less);
            return greater;
        }
        private static int EvclideanNod(params int[] numbers)
        {
            int firstNum;
            int secondNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                firstNum = numbers[i];
                secondNum = EvclideanNod(firstNum, secondNum);
            }
            return secondNum;
        }
        //стоит ли оставлять перегруженный(для проверки скорости вычисления)? 
        //public static int Evclidean(int firstNum, int secondNum)
        //{
        //    int[] numbers = {firstNum, secondNum};
        //    checkArguments(numbers);
        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();
        //    int nod = EvclideanNod(firstNum,secondNum);
        //    Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
        //    return nod;
        //}
        public static int Evclidean(params int[] numbers)
        {
            checkArguments(numbers);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int nod = EvclideanNod(numbers);
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return nod;
        }

        private static int StainNod(int firstNum, int secondNum)
        {
            //НОД(0, n) = n; НОД(m, 0) = m.
            if (firstNum == 0 || secondNum == 0)
            { return firstNum | secondNum;}
            //НОД(m, m) = m;
            else if (firstNum == secondNum)
            {return firstNum;}
            //НОД(1, n) = 1; НОД(m, 1) = 1;
            else if (firstNum == 1 && secondNum == 1)
            { return 1;}
            //Если m, n чётные, то НОД(m, n) = 2*НОД(m/2, n/2);
            else if (firstNum%2 == 0 && secondNum%2 == 0)
            {return 2*EvclideanNod(firstNum/2, secondNum/2);}
            //Если m чётное, n нечётное, то НОД(m, n) = НОД(m/2, n);
            else if (firstNum%2 == 0 && secondNum%2 != 0)
            { return EvclideanNod(firstNum/2, secondNum);}
            //Если n чётное, m нечётное, то НОД(m, n) = НОД(m, n/2);
            else if (firstNum%2 != 0 && secondNum%2 == 0)
            {
                return EvclideanNod(firstNum, secondNum/2);
            }
            //Если m, n нечётные и n < m, то НОД(m, n) = НОД((m-n)/2, n);
            else
            {
                return EvclideanNod(firstNum - secondNum/2, secondNum);}
        }

        private static int StainNod(int[] numbers)
        {
            int firstNum;
            int secondNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                firstNum = numbers[i];
                secondNum = StainNod(firstNum, secondNum);
            }
            return secondNum;
        }

        public static int Stain(params int[] numbers)
        {
            checkArguments(numbers);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int nod = StainNod(numbers);
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
            return nod;
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
            if (numbers[0] == 0 && numbers[numbers.Length-1] == 0)
            {
                throw new ArgumentException();
            }
            return numbers;
        }
    }
}
