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
            Console.WriteLine(Nod.Evclidean(4,12));
            Console.WriteLine(Nod.Evclidean(18,4,27,36));
            Console.ReadKey();
        }
    }
}
