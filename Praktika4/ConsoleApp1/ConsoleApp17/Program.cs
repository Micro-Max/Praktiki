namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1, j = 1; i <= n; i += 2, j++)
            {
                sum += Math.Pow(x, i) / (2 * j - 1);
            }
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
