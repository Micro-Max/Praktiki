namespace ConsoleApp21
{
    internal class Program
    {
        static double dist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(dist(8,4,2,10));\
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
