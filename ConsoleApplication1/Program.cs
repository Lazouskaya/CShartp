using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewtonsMethod.RootOfNthDegreeByNewton(144, 3, 0.95));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
