namespace ConsoleApp18
{
    internal class Program
    {
        static double yield(int N)
        {
            double yield = 20;
            for (int i = 1; i < N; i++)
            {
                yield *= 1.02;
            }
            return yield;
        }
        static double area(int N)
        {
            double area = 100;
            for (int i = 1; i < N; i++)
            {
                area *= 1.05;
            }
            return area;
        }
        static double total(int N)
        {
            double total = 0;
            for (int i = 1; i <= N; i++)
            {
                total += area(i) * yield(i);
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(yield(10));
            Console.WriteLine(area(10));
            Console.WriteLine(total(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
