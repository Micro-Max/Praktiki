using System;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());
            int square = 0;
            for (int i = 1, odd = 1; i <= n; i++, odd += 2)
            {
                square += odd;
            }
            Console.WriteLine($"{n}² = {square}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
