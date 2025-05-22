namespace ConsoleApp5
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
        static void Main(string[] args)
        {
            Console.WriteLine(Square(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
