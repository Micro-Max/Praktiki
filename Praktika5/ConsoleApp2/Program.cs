using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static int Factorial(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
