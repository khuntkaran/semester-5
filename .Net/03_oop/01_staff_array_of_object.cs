using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
