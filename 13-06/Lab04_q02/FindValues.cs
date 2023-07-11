using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_q02
{
    internal class FindValues
    {
        public double area(double r) 
        {
            double pi = 3.14;
            double A = pi * r * r;
            return A;
        }

        public double circumference(double r) 
        {
            double pi = 3.14;
            double C = 2 * pi * r;
            return C;
        }
    }
}
