using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodMethods;

namespace NodApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Nod.Evclidean(9,12));
            Console.WriteLine(Nod.Evclidean(18,27,84,36));
            Console.ReadKey();
        }
    }
}
