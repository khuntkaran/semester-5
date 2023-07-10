using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception
{
    class _01_divide_by_zero_exception
    {
        public void check()
        {
            try
            {
                Console.Write("Enter NO : ");
                int i = Convert.ToInt32(Console.ReadLine());
                float a = 20 / i;
                Console.WriteLine("Ans : " + a);
            }
            catch (Exception e)
            {
               Console.WriteLine("Exception : "+e.Message);
            }
        }
    }
}
