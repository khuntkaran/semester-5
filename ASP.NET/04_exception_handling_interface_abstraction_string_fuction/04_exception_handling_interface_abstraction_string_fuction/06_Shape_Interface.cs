using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception_handling_interface_abstraction_string_fuction
{
    interface Shape
    {
        void Circle();
        void Triangle();
        void Square();
    }

    class Area : Shape
    {
        public void Circle()
        {
            Console.WriteLine("Enter Circle Radius : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area of circle : " + (3.14 * r * r));
        }

        public void Square()
        {
            Console.WriteLine("Enter Square Lenght : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Square Width : ");
            int w= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area of square : "+(l*w));
        }

        public void Triangle()
        {
            Console.WriteLine("Enter Triangle Base : ");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Triangle Hight : ");
            int h= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area of triangle : " + (0.5 * b * h));

        }
    }
}
