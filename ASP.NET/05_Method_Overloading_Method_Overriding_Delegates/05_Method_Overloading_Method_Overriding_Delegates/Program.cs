using static _05_Method_Overloading_Method_Overriding_Delegates.TrafficSignal;

namespace _05_Method_Overloading_Method_Overriding_Delegates
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("1. overloading perform addition");
            Console.WriteLine("2. overloading by changing number of arguments");
            Console.WriteLine("3. Area of Square Rectangle and Circle using method overloading");
            Console.WriteLine("4. overrides calculateInterest");
            Console.WriteLine("5. overriding HospitalDetails");
            Console.WriteLine("6. factorial using delegate");
            Console.WriteLine("7. TrafficSignal delegate");
            Console.WriteLine("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    _01_overloading__perform_addition opa = new _01_overloading__perform_addition();
                    opa.sum(5, 6);
                    opa.sum(5.5f, 6.5f);
                    break;
                case 2:
                    _02_overloading_by_changing_number_of_arguments ocna = new _02_overloading_by_changing_number_of_arguments();
                    ocna.area(5);
                    ocna.area(5, 6);
                    break;
                case 3:
                    _03_Area_of_Square_Rectangle_and_Circle_using_method_overloading src = new _03_Area_of_Square_Rectangle_and_Circle_using_method_overloading();
                    src.area(5);
                    src.area(5.0f);
                    src.area(5, 6);
                    break;
                case 4:
                    HDFC hDFC = new HDFC();
                    SBI sbi = new SBI();
                    ICICI icici = new ICICI();
                    hDFC.calculateInterest();
                    sbi.calculateInterest();
                    icici.calculateInterest();
                    break;
                case 5:
                    Apollo ap = new Apollo();
                    Wockhardt wc = new Wockhardt();
                    Gokul_Superspeciality gs = new Gokul_Superspeciality();
                    ap.HospitalDetails();
                    wc.HospitalDetails();
                    gs.HospitalDetails();
                    break;
                case 6:
                    _06__factorial_using_delegate fud = new _06__factorial_using_delegate();
                    mydele md = new mydele(fud.factorial);
                    Console.WriteLine(md(5));
                    break;
                case 7:
                    TrafficSignal ts = new TrafficSignal();
                    TrafficDel ty = new TrafficDel(Yellow);
                    TrafficDel tg = new TrafficDel(Green);
                    TrafficDel tr = new TrafficDel(Red);
                    ty();
                    tg();
                    tr();
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
        }
    }
}