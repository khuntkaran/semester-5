using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Array
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter Distance 1 : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Distance 2 : ");
            int b=Convert.ToInt32(Console.ReadLine());

            Distance c1 = new Distance(a, b);
            c1.Calculate();


                Console.ReadLine();
        }
    }

    class Distance
    {
        public int dis1, dis2;

        public Distance(int a, int b)
        {
            this.dis1 = a;
            this.dis2 = b;
        }

        public void Calculate()
        {
            Console.WriteLine("Distance = " + (dis1 + dis2));
        }
    }
}
