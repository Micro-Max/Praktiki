namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (1 < n <= 10): ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }
            Console.WriteLine($"Сумма факториалов: {sum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
