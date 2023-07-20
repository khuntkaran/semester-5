using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    public class _02_overloading_by_changing_number_of_arguments
    {
        public void area(int l )
        {
            Console.WriteLine("square area : " + (l * l));
        }

        public void area(int l, int b )
        {
            Console.WriteLine("rectangle area : " + (l * b));
        }

    }
}
