using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception
{
    class IndexOutOfRange_Exception
    {
        public void readArray()
        {
            int[] a = new int[4];
            try
            {
                for (int i = 0; i <= a.Length; i++)
                {
                    Console.Write("Enter " + (i + 1) + " Element : ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
                
        }
    }
}
