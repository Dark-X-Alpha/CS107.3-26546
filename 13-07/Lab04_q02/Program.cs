using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            double r = double.Parse(Console.ReadLine());

            FindValues fvalues = new FindValues();
            double A = fvalues.area(r);
            Console.WriteLine("Area is " + A);

            double C = fvalues.circumference(r);
            Console.WriteLine("Circumference is " + C);

            Console.ReadKey();
        }
    }
}
