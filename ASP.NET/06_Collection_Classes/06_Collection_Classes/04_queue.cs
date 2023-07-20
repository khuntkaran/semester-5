using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrayList
{
    class _04_queue
    {
        Queue q1 = new Queue();
        public void performOperations()
        {
            
            q1.Enqueue("karan");
            q1.Enqueue(4);
            q1.Enqueue(true);
            q1.Enqueue("hello");
            q1.Enqueue(false);
            q1.Enqueue(5);
            display();

            q1.Dequeue();
            display();

            Console.Write("\nPeek : "+q1.Peek());
            display();

            Console.Write("\nContaines : " + q1.Contains("hello"));
            display();

            q1.Clear();
            display();
        }
        public void display()
        {
            Console.Write("\nQueue : ");
            foreach (var i in q1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
