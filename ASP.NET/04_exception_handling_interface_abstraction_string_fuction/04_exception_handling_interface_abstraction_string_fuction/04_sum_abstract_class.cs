using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception_handling_interface_abstraction_string_fuction
{
    abstract class Sum{
        abstract public void SumOfTwo(int a,int b);
        abstract public void SumOfThree(int a, int b,int c); 
    }

    class Calculate : Sum
    {
        public override void SumOfTwo(int a, int b)
        {
            Console.WriteLine("Sum = " + (a+b));
        }

        public override void SumOfThree(int a, int b,int c)
        {
            Console.WriteLine("Sum = " + (a + b+c));
        }

    }
}
