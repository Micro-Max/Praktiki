namespace ConsoleApp7
{
    internal class Program
    {
        static double Alt(int n)
        {
            double sum = 0;
            int sign = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / i);
                sign = -sign;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Alt(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
