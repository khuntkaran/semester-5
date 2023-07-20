using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    public class Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("HospitalDetails");
        }
    }

    public class Apollo : Hospital { 
        public void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital Detail");
        }
    }
    public class Wockhardt : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital Detail");
        }
    }
    public class Gokul_Superspeciality : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality Hospital Detail");
        }
    }
}
