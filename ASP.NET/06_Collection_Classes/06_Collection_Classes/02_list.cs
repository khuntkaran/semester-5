using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrayList
{
    public class _02_list
    {
       List<object> l1 = new List<object>();
        public void performOperations()
        {

            l1.Add("karan");
            l1.Add(1);
            l1.Add("hello");
            l1.Add(false);
            l1.Add(89);
            l1.Add("how");
            l1.Add(false);
            display();

            l1.Remove(false);
            display();

            l1.RemoveRange(2, 2);
            display();

            l1.Clear();
            display();


        }

        public void display()
        {
            Console.Write("\nList : ");
            foreach (var i in l1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
