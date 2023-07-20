using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    public class _03_Area_of_Square_Rectangle_and_Circle_using_method_overloading
    {
        public void area(int l)
        {
            Console.WriteLine("square area : " + (l * l));
        }

        public void area(float l)
        {
            Console.WriteLine("Circle area : " + (l * l*3.14));
        }

        public void area(int l, int b)
        {
            Console.WriteLine("rectangle area : " + (l * b));
        }
    }
}
