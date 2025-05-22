using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a:");
            string a = Console.ReadLine();
            Console.Write("Введите число b:");
            string b = Console.ReadLine();
            Console.Write("Введите число с:");
            string с = Console.ReadLine();
            int Discr = int.Parse(b) * int.Parse(b) - 4 * int.Parse(a) * int.Parse(с);
            double x1 = (-int.Parse(b) - float.RootN((Discr), 2)) / 2 * int.Parse(a);
            double x2 = (-int.Parse(b) + float.RootN(Discr,2)) / 2 * int.Parse(a);
            Console.WriteLine("Первый корень уравнения ax^2+bx+c=0, равен:" + x1);
            Console.WriteLine("Второй корень уравнения ax^2+bx+c=0, равен:" + x2);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
