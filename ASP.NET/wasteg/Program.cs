using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. ArrayList");
            Console.WriteLine("3. Stack");
            Console.WriteLine("4. Queue");
            Console.WriteLine("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    _01_ArrayList a1 = new _01_ArrayList();
                    a1.performOperations();
                    break;
                case 3:
                    _03_stack s1 = new _03_stack();
                    s1.performOperations();
                    break;
                case 4:
                    _04_queue q1 = new _04_queue();
                    q1.performOperations();
                    break;
                default:
                    Console.WriteLine("Input not valid");
                    break;
            }
            Console.ReadLine();

        }
    }
}
