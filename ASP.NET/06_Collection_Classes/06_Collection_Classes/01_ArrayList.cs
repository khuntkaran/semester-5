using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrayList
{
    class _01_ArrayList
    {
        ArrayList a1 = new ArrayList();
        public void performOperations()
        {
            
            a1.Add("karan");
            a1.Add(1);
            a1.Add("hello");
            a1.Add(false);
            a1.Add(89);
            a1.Add("how");
            a1.Add(false);
            display();

            a1.Remove(false);
            display();

            a1.RemoveRange(2, 2);
            display();

            a1.Clear();
            display();
            
           
        }

        public void display()
        {
            Console.Write("\nArrayList : ");
            foreach (var i in a1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
