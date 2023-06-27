class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("1. Staff Array_Of_Object");
        Console.WriteLine("2. Distance Constractor");
        Console.WriteLine("3. Furniture Inhereturn");
        Console.WriteLine("4. Furniture Interface");

        Console.Write("Enter choice : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------");

        switch (n)
        {
            case 1:
                Staff[] emp = new Staff[5];

                for (int i = 0; i < emp.Length; i++)
                {
                    emp[i] = new Staff();
                    Console.Write("Enter " + (i + 1) + " Name : ");
                    emp[i].Name = Console.ReadLine();
                    Console.Write("Enter " + (i + 1) + " Post : ");
                    emp[i].Post = Console.ReadLine();
                }

                for (int i = 0; i < emp.Length; i++)
                {
                    emp[i].Display();
                }
                break;
            case 2:
                Console.Write("Enter Distance 1 : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Distance 2 : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Distance c1 = new Distance(a, b);
                c1.Calculate();
                break;
            case 3:
                Table t1 = new Table();
                t1.setData();
                t1.getData();
                break;
            case 4:
                Table2 t2 = new Table2();
                t2.setData();
                t2.getData();
                t2.Calculate();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}