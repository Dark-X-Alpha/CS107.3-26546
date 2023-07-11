using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.Write("Enter your choice : ");

            string input= Console.ReadLine();

            Console.Write("Enter a value for number 1 : ");
            double num1=double.Parse(Console.ReadLine());

            Console.Write("Enter a value for number 2 : ");
            double num2 = double.Parse(Console.ReadLine());

            Calculator obj=new Calculator();

            double answer = 0;

            if (input == "1")
            {
                answer = obj.add(num1, num2);
            }

            else if (input == "2") 
            {
                answer = obj.sub(num1, num2);
            }

            else if (input == "3")
            {
                answer = obj.multi(num1, num2);
            }

            else
            {
                answer = obj.div(num1, num2);
            }

            Console.WriteLine("The answer is " + answer);

            Console.ReadKey();
        }
    }
}
