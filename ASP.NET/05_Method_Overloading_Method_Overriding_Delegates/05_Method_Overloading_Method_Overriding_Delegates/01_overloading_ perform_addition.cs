using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    internal class _01_overloading__perform_addition
    {
        public void sum(int a,int b)
        {
            Console.WriteLine("Sum : "+(a+b));
        }

        public void sum(float a,float b)
        {
            Console.WriteLine("Sum : "+(a+b));
        }
    }
}
