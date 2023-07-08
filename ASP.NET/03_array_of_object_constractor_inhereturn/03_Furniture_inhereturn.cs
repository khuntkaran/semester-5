using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    class Furniture
    {
        public int Price;
        public String Material;
    }

    class Table : Furniture
    {
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
    }
    
