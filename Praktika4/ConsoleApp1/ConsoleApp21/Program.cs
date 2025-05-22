namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10;
            double total = 0;
            for (int day = 1; day <= 10; day++)
            {
                Console.WriteLine($"День {day}: {distance:F2} км");
                if (day <= 7) total += distance;
                distance *= 1.1;
            }
            Console.WriteLine($"Суммарный путь за 7 дней: {total:F2} км");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
