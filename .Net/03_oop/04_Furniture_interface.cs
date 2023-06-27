using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    interface Furniture2
    {
        int Price { get; set; }
       
        void Calculate();
    }

    class Table2 : Furniture2
    {
        public int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
      
        String Material;
        public int Hight, SurfacArea;


        public void setData()
        {
            Console.WriteLine("Enter Price : ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Material : ");
            Material = Console.ReadLine();
            Console.WriteLine("Enter Hight : ");
            Hight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SurfacArea : ");
            SurfacArea = Convert.ToInt32(Console.ReadLine());
        }
        public void getData()
        {
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Material : " + Material);
            Console.WriteLine("Hight : " + Hight);
            Console.WriteLine("SurfacArea : " + SurfacArea);
        }

        public void Calculate()
        {
            Console.WriteLine("Cost : " + (Hight * Price));
        }
    }
    
