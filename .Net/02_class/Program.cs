class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Staff");
        Console.WriteLine("2. Candidate");
        Console.WriteLine("3. Bank");
        Console.WriteLine("4. Student");

        Console.Write("Enter choice : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------");

        switch (n)
        {
            case 1:
                StaffData Emp1 = new StaffData();
                StaffData Emp2 = new StaffData();
                StaffData Emp3 = new StaffData();

                Emp1.Name = "karan";
                Emp1.Post = "HOD";
                Emp1.Display();
                Emp2.Name = "Kishan";
                Emp2.Post = "Deen";
                Emp2.Display();
                Emp3.Name = "Utam";
                Emp3.Post = "HOD";
                Emp3.Display();
                break;

            case 2:
                CandidateData c1 = new CandidateData();
                c1.setData();
                c1.getData();
                break;

            case 3:
                BankData b1 = new BankData();
                b1.setData();
                b1.getData();
                break;

            case 4:
                StudentData s1 = new StudentData();
                s1.setData();
                s1.getData();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}