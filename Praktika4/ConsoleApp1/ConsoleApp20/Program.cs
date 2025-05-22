namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanceFromHome = 0;
            double totalPath = 0;
            for (int i = 1; i <= 100; i++)
            {
                totalPath += 1.0 / i;
                if (i % 2 == 1)
                    distanceFromHome += 1.0 / i;
                else
                    distanceFromHome -= 1.0 / i;
            }
            Console.WriteLine($"После 100 этапов:");
            Console.WriteLine($"Расстояние от дома: {distanceFromHome} км");
            Console.WriteLine($"Общий путь: {totalPath} км");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
