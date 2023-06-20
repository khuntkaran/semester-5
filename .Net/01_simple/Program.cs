using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. odd-even");
        Console.WriteLine("2. Positive Negative Zero");
        Console.WriteLine("3. Large Of Two");
        Console.WriteLine("4. Swap Two Number");
        Console.WriteLine("5. Divisible By Two");
        Console.WriteLine("6. Sum Of Digit Of Number");
        Console.WriteLine("7. Temperatue Conveter");
        Console.WriteLine("8. Large Of Three");
        Console.WriteLine("9. Prime Number");

        Console.Write("Enter choice : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------");
        switch (n)
        {
            case 1:
                OddEven();
                break;
            case 2:
                PNZ();
                break;
            case 3:
                LargeOfTwo();
                break;
            case 4:
                SwapTwoNumber();
                break;
            case 5:
                DivisibleByTwo();
                break;
            case 6:
                SumOfDigitOfNumber();
                break;
            case 7:
                TemperatueConveter();
                break;
            case 8:
                LargeOfThree();
                break;
            case 9:
                PrimeNumber();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static void OddEven(){
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }

    static void PNZ(){
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (a < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }

    static void LargeOfTwo(){
        Console.Write("Enter No1 : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter No2 : ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("Large No1 : " + a);
        }
        else if (b > a)
        {
            Console.WriteLine("Large No2 : " + b);
        }
        else
        {
            Console.WriteLine("Both are same");
        }
    }

    static void SwapTwoNumber(){
        Console.Write("Enter No1 : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter No2 : ");
        int b = Convert.ToInt32(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("No1 : " + a);
        Console.WriteLine("No2 : " + b);
    }

    static void DivisibleByTwo(){
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a / 2 == 0)
        {
            Console.WriteLine("Number is Divisible By Two");
        }
        else
        {
            Console.WriteLine("Number is not Divisible By Two");
        }
    }

    static void SumOfDigitOfNumber(){
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 0;

        while (a > 0)
        {
            int temp = a % 10;
            b = b + temp;
            a = a / 10;
        }

        Console.WriteLine("Sum of digit : " + b);
    }

    static void TemperatueConveter(){
        Console.Write("Enter Farenheit : ");
        int f = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter  Celsius : ");
        int c = Convert.ToInt32(Console.ReadLine());

        int f2 = (9 / 5) * c + 32;
        int c2 = (f - 32) * 5 / 9;

        Console.WriteLine("F to C : " + c2);
        Console.WriteLine("C to F : " + f2);
    }

    static void LargeOfThree(){
        Console.Write("Enter No1 : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter No2 : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter No3 : ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Large No1 : " + a);
            }
            else
            {
                Console.WriteLine("Large No3 : " + c);
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("Large No2 : " + b);
            }
            else
            {
                Console.WriteLine("Large No3 : " + c);
            }
        }
    }

    static void PrimeNumber(){
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int flag = 0;

        for (int i = 2; i < a / 2; i++)
        {
            if (a % i == 0)
            {
                flag = 1;
                break;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("Number is Prime");
        }
        else
        {
            Console.WriteLine("Number is not Prime");
        }
    }

     static void OddEven2()
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Even : ");
            for (int i = 1; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Odd : ");
            for (int i = 1; i < a; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static void Reverse()
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int a2 = 0;
            while (a > 0)
            {
                int temp = a % 10;
                a2 = (a2 * 10) + temp;
                a = a / 10;
            }
            Console.WriteLine("Reverse Number : " + a2);
            
        }
        static void Circle()
        {
            Console.Write("Enter Rediysh : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Circle Area : " + (3.14 * a * a));
            Console.WriteLine("Circle Diameter : " + (2 * a));
        }
        static void MultiplicationTable()
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(a + " x " + i + " = " + (a * i));
            }
        }
        static void Power()
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Power : ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ans : " + Math.Pow(a, p));
        }
        static void Armstrong()
        {
            Console.Write("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = a;
            int a2 = 0;
            int newno=0;
            while (a > 0)
            {
                a2++;
                a = a / 10;
            }
            a = n;
            while (a > 0)
            {
                int temp = a % 10;
                newno = newno + Convert.ToInt32(Math.Pow(temp,a2));
                a = a / 10;
            }
            if (newno == n)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong");
            }
        }


}
