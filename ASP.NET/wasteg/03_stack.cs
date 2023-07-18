using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrayList
{
    class _03_stack
    {
        Stack s1 = new Stack();
        public void performOperations()
        {
            s1.Push("karan");
            s1.Push(4);
            s1.Push(true);
            s1.Push(48);
            s1.Push(false);
            display();

            s1.Pop();
            display();

            Console.Write("\nPeek : "+s1.Peek());
            display();

            Console.Write("\nContaines : " + s1.Contains("hello"));
            display();

            s1.Clear();
            display();

        }
        public void display()
        {
            Console.Write("\nQueue : ");
            foreach (var i in s1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
