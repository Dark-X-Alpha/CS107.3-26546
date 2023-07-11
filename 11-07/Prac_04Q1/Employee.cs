using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_04Q1
{
    public class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public void setEmpId(int input)
        {
            empID = input;
        }

        public void setEmpName(string input)
        {
            empName = input;
        }
        public void setEmpDesignation(string input)
        {
            empDesignation = input;
        }

        public int getEmpID() 
        {
            return empID;
        }

        public string getEmpName() 
        {
            return empName;
        }

        public string getEmpDesignation()
        {
            return empDesignation;
        }

    }
}
