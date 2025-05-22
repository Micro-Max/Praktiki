namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (1 < n <= 10): ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;
            }
            Console.WriteLine($"Сумма ряда: {sum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
