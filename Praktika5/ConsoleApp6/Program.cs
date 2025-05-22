namespace ConsoleApp6
{
    internal class Program
    {
        static int Square(int n)
        {
            int sum = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                sum += i;
            }
            return sum;
        }

        static int SumOfSq(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Square(i);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSq(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
