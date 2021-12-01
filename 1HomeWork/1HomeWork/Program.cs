using System;

namespace HomeWork
{
    class Program
    {
        static void Task1()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = (5 * a + b * b) / (b - a);

            Console.WriteLine(c);
        }

        static void Task2()
        {
            Console.Write("a: ");
            string a = Console.ReadLine();
            Console.Write("b: ");
            string b = Console.ReadLine();

            string c = "";
            c = a;
            a = b;

            Console.WriteLine();
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + c);
        }

        static void Task3()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result1 = (int)(a / b);
            double result2 = a % b;
            Console.WriteLine("a / b = " + result1);
            Console.WriteLine("a % b = " + result2);
        }

        static void Task4()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double x = Math.Round((c - b) / a, 2);
            Console.WriteLine($"x = {x}");
        }

        static void Task5()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double k = (y2 - y1) / (x2 - x1);
            double b = -(x1 * y2 - x2 * y1) / (x2 - x1);
            Console.WriteLine($"y  = {k}x + {b}");
        }
        static void Main()
        {

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
        }
    }
}