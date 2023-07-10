using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception
{
    class _03_throw_an_exception
    {
        public void checkEven()
        {
            try
            {
                Console.Write("Enter Number : ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 != 0)
                {
                    throw new Exception("Number is Not an Even");
                }
                else
                {
                    Console.WriteLine("Number is an Even");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
            
        }
    }
}
