﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root
{ 
    public static class NewtonsMethod
    {
        public static double RootOfNthDegreeByNewton(double number, int power, double accuracy)
        {
            if (number < 0)
            {
               throw new System.ArgumentException("Invalid value of number. It must be greater than 0");
            }
            if (power < 0)
            {
                throw new System.ArgumentException("Invalid value of power. It must be greater than 0");
            }
            if (accuracy < 0 || accuracy > 1)
            {
                throw new System.ArgumentException("Invalid value of power. It must be in [0;1] interval");
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
