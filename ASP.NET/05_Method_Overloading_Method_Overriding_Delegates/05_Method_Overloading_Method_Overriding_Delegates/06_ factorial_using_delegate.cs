using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    public delegate int mydele(int a);
    public class _06__factorial_using_delegate
    {
        public int factorial(int a)
        {
            int result = 1;
            for(int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
