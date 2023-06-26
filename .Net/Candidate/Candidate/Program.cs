using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    class Program
    {
        static void Main(string[] args)
        {
            CandidateData c1 = new CandidateData();
            c1.setData();
            c1.getData();
            Console.ReadLine();
        }
    }

    class CandidateData
    {
        public int ID, Age, Weight, Height;
        public String Name;

        public void setData()
        {
            Console.Write("Enter Id : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name ; ");
            Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Weight : ");
            Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height : ");
            Height = Convert.ToInt32(Console.ReadLine());
        }

        public void getData()
        {
            Console.WriteLine(ID + " " + Name + " " + Age + " " + " " + Weight + " " + Height);
        }
    }
}
