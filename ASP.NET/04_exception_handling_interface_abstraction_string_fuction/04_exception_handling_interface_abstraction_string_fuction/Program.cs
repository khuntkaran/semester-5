using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_exception_handling_interface_abstraction_string_fuction;

namespace _04_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. divide_by_zero_exception");
            Console.WriteLine("2. IndexOutOfRange_Exception");
            Console.WriteLine("3. throw_an_exception");
            Console.WriteLine("4. sum abstract class");
            Console.WriteLine("5. Calculate Interface");
            Console.WriteLine("6. Shape Interface");
            Console.WriteLine("7. String Method");
            Console.WriteLine("8. lower case to upper case and Vice-versa");

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
                case 4:
                    Calculate sac = new Calculate();
                    sac.SumOfTwo(4,5);
                    sac.SumOfThree(8,4,3);
                    break;
                case 5:
                    Result result = new Result();
                    result.Addition();
                    result.Subtraction();
                    break;
                case 6:
                    Area area = new Area();
                    area.Circle();
                    area.Square();
                    area.Triangle();
                    break;
                case 7:
                    _07_String_Method sm = new _07_String_Method();
                    sm.CommonMethod();
                    break;
                case 8:
                    _08_lower_case_to_upper_case lcuc = new _08_lower_case_to_upper_case();
                    lcuc.changeCase();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
                
            }
            

        }
    }
}
