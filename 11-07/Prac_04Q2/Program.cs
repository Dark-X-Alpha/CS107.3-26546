using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_04Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number 01 ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number 02 ");
            double num2 = double.Parse(Console.ReadLine());

            Calculation calObj = new Calculation();

            calObj.setValues(num1, num2);

            Console.WriteLine("Sum is :" + calObj.getSum());
            Console.WriteLine("Subtraction is :" + calObj.getSub());
            Console.WriteLine("Multiplication is :" + calObj.getMultip());
            Console.WriteLine("Division :" + calObj.getDiv());
        }
    }
}
