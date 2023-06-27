using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff[] emp = new Staff[5];

            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Staff();
                Console.Write("Enter "+(i+1)+" Name : ");
                emp[i].Name = Console.ReadLine();
                Console.Write("Enter " + (i + 1) + " Post : ");
                emp[i].Post = Console.ReadLine();
            }

            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].Display();
            }

                Console.ReadLine();
        }
    }

    class Staff
    {
        public String Name;
        public String Post;
        public void Display()
        {
            if (Post == "HOD")
            {
                Console.WriteLine(Name + " => " + Post);
                Console.WriteLine("==================");
            }
        }
    }
}
