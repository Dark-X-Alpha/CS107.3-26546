using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_04Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee ID");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter the employee's designation");
            string empDesignation = Console.ReadLine();

            Employee empObj = new Employee();

            empObj.setEmpId(empID);
            empObj.setEmpName(empName);
            Employee empObj2 = new Employee();

            Console.WriteLine("Hello " + empObj.getEmpName() + "Your Employee ID is " + empObj.getEmpID() + "Your designation is " + empObj.getEmpDesignation());

        }
    }
}
