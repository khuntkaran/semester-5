using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception_handling_interface_abstraction_string_fuction
{
     class _07_String_Method
    {
        public string st = "Darshan University";

        public void CommonMethod()
        {
            Console.WriteLine("String : " + st);
            Console.WriteLine("Upper case : "+st.ToUpper());
            Console.WriteLine("Lower case : "+st.ToLower());
            Console.WriteLine("Concat string : " + String.Concat(st," hello"));
            Console.WriteLine("Contains : " + st.Contains("University"));
            Console.WriteLine("IndexOf r : " + st.IndexOf('r'));
            Console.WriteLine("Insert hello : " + st.Insert(5, "__hello__"));
            Console.WriteLine("Replace : " + st.Replace("University", "School"));
            Console.WriteLine("SubString : " + st.Substring(5));
            Console.WriteLine("Trim : " + st.Trim());
            Console.WriteLine("String : "+st);
        }
    }
}
