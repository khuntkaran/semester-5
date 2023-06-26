using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_class_app
{
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

    class StaffData
    {
        static void Main(String[] args)
        {
            Staff Emp1 = new Staff();
            Staff Emp2 = new Staff();
            Staff Emp3 = new Staff();
            Staff Emp4 = new Staff();
            Staff Emp5 = new Staff();

            Emp1.Name = "karan";
            Emp1.Post = "HOD";
            Emp1.Display();
            Emp2.Name = "RAj";
            Emp2.Post = "pune";
            Emp2.Display();
            Emp3.Name = "Divyesh";
            Emp3.Post = "Prof";
            Emp3.Display();
            Emp4.Name = "Kishan";
            Emp4.Post = "Deen";
            Emp4.Display();
            Emp5.Name = "Utam";
            Emp5.Post = "HOD";
            Emp5.Display();
            
            Console.ReadLine();
        }

    }
}
