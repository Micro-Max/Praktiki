namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = 100;
            double yield = 20;
            double totalHarvest = 0;
            for (int year = 1; year <= 8; year++)
            {
                if (year >= 2 && year <= 8)
                    Console.WriteLine($"Год {year}: Урожайность = {yield:F2} ц/га");
                if (year >= 4 && year <= 7)
                    Console.WriteLine($"Год {year}: Площадь = {area:F2} га");
                if (year <= 6)
                    totalHarvest += area * yield;

                area *= 1.05;
                yield *= 1.02;
            }
            Console.WriteLine($"Урожай за 6 лет: {totalHarvest:F2} ц");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
