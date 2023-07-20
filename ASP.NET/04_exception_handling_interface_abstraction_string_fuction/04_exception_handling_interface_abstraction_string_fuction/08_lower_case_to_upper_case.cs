using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_exception_handling_interface_abstraction_string_fuction
{
    public class _08_lower_case_to_upper_case
    {
        public void changeCase()
        {
            Console.WriteLine("Enter String : ");
            String st = Console.ReadLine();
            String st2 = "";

            for(int i=0;i<st.Length;i++)
            {
                char c = st[i];
                if (char.IsLower(c))
                {
                    st2 += char.ToUpper(c);
                }
                else
                {
                    st2 += char.ToLower(c);
                }
            }

            Console.WriteLine("New String : "+st2 );
        }
    }
}
