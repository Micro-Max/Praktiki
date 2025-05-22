namespace ConsoleApp16
{
    internal class Program
    {
        public static double DistanceOnDay(int N)
        {
            double distance = 10;
            for (int i = 2; i <= N; i++)
            {
                distance *= 1.1;
            }
            return distance;
        }
        public static double TotalDistance(int N)
        {
            double total = 0;
            double daily = 10;
            for (int i = 1; i <= N; i++)
            {
                total += daily;
                daily *= 1.1;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DistanceOnDay(10));
            Console.WriteLine(TotalDistance(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
