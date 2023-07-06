class StaffData
{
    public String Name;
    public String Post;
    public void Display()
    {
        if (Post == "HOD")
        {
            Console.WriteLine(Name + " => " + Post);
            Console.WriteLine("==================");
        }
    }
}