using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception_handling_interface_abstraction_string_fuction
{
    interface Calculate2
    {
        void Addition();
        void Subtraction();
    }

    class Result : Calculate2
    {
        public void Addition()
        {
            Console.WriteLine("Enter no1 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no1 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition : " + (a + b));
        }

        public void Subtraction()
        {
            Console.WriteLine("Enter no1 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no1 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition : " + (a - b));
        }
    }
}
