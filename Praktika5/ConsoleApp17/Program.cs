namespace ConsoleApp17
{
    internal class Program
    {
        static double distance(int N)
        {
            double distance = 0;
            int sign = 1;
            for (int i = 1; i <= N; i++)
            {
                distance += sign * (1.0 / i);
                sign = -sign;
            }
            return distance;
        }
        static double total(int N)
        {
            double total = 0;
            for (int i = 1; i <= N; i++)
            {
                total += 1.0 / i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(distance(10));
            Console.WriteLine(total(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
