class BankData
{
    public int AC_No, AC_Balance;
    public String Name, Email, AC_Type;

    public void setData()
    {
        Console.Write("Enter Name : ");
        Name = Console.ReadLine();
        Console.Write("Enter AC_No : ");
        AC_No = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Email : ");
        Email = Console.ReadLine();
        Console.Write("Enter AC_Type : ");
        AC_Type = Console.ReadLine();
        Console.Write("Enter AC_Balance : ");
        AC_Balance = Convert.ToInt32(Console.ReadLine());
    }

    public void getData()
    {
        Console.WriteLine(AC_No + " " + " " + Name + " " + Email + " " + AC_Type + " " + AC_Balance);
    }
}