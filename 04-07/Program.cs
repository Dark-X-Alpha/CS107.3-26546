using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array :");
            int size = Convert.ToInt32(Console.ReadLine());

            Prac3 prac3 = new Prac3();
            int[] array = prac3.CreateArray(size * 2);

            Console.WriteLine("Enter the values for array");

            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i]+"");
            }

            Console.ReadLine();
        }
    }
}
