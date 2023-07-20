using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    public class RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("hello");
        }
    }

    public class HDFC : RBI
    {
        public void calculateInterest()
        {
            int p = 100000;
            int r = 5;
            int n = 1;
            Console.WriteLine("P : " + p + " R : " + r + " N : " + n);
            Console.WriteLine("HDFC interest : " + (p * r * n) / 100);
        }
    }

    public class SBI : RBI
    {
        public void calculateInterest()
        {
            int p = 200000;
            int r = 6;
            int n = 2;
            Console.WriteLine("P : " + p + " R : " + r + " N : " + n);
            Console.WriteLine("SBI interest : " + (p * r * n) / 100);
        }
    }

    public class ICICI : RBI
    {
        public void calculateInterest()
        {
            int p = 300000;
            int r = 7;
            int n = 3;
            Console.WriteLine("P : " + p + " R : " + r + " N : " + n);
            Console.WriteLine("ICICI interest : " + (p * r * n) / 100);
        }
    }
}
