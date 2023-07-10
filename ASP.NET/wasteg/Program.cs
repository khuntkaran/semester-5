using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. divide_by_zero_exception");
            Console.WriteLine("2. IndexOutOfRange_Exception");
            Console.WriteLine("3. throw_an_exception");

            Console.Write("Enter Choice : ");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    _01_divide_by_zero_exception dz = new _01_divide_by_zero_exception();
                    dz.check();
                    break;
                case 2:
                    IndexOutOfRange_Exception IE = new IndexOutOfRange_Exception();
                    IE.readArray();
                    break;
                case 3:
                    _03_throw_an_exception te = new _03_throw_an_exception();
                    te.checkEven();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
                
            }
            Console.ReadLine();

        }
    }
}
