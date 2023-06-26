class StudentData
{
    public int En_No, sem;
    public double cpi, spi;
    public String Name;

    public void setData()
    {
        Console.Write("Enter Enrollment No : ");
        En_No = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name : ");
        Name = Console.ReadLine();
        Console.Write("Enter Semester : ");
        sem = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter spi : ");
        spi = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter cpi : ");
        cpi = Convert.ToDouble(Console.ReadLine());
    }

    public void getData()
    {
        Console.WriteLine(En_No + " " + Name + " " + sem + " " + spi + " " + cpi);
    }
}