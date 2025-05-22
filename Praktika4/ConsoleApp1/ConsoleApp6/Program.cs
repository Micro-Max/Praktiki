using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в семеричной системе (N7): ");
            string n7 = Console.ReadLine();
            int decimalNumber = 0;
            for (int i = 0; i < n7.Length; i++)
            {
                char digitChar = n7[i];
                int digit = digitChar - '0';
                if (digit < 0 || digit > 6)
                {
                    Console.WriteLine("Ошибка: число должно содержать только цифры 0-6");
                    return;
                }
                decimalNumber = decimalNumber * 7 + digit;
            }
            Console.WriteLine($"В десятичной системе: {decimalNumber}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
