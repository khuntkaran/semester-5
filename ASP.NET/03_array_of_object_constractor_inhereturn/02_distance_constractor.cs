using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
