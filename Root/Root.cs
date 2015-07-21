using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root
{ 
    public static class NewtonsMethod
    {
        public static double RootOfNthDegreeByNewton(double number, double power, double accuracy)
        {
            if (number < 0 || power < 0 || accuracy < 0 || accuracy > 1)
            {
                Console.WriteLine("Incorrect input parameters");
                return 0;
            }
            double root;
            double newroot = number;
            do
            {
                root = newroot;
                newroot = ((power - 1) * root + number / Math.Pow(root, (power - 1))) / power;
            } while (newroot / root < accuracy);
            return newroot;
        }
    }
}
