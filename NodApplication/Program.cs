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
            Console.WriteLine(Nod.Evclidean(12,16));
            Console.WriteLine(Nod.Evclidean(18,6,27,36));
            Console.ReadKey();
        }
    }
}
