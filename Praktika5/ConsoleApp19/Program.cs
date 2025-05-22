namespace ConsoleApp19
{
    internal class Program
    {
        static double perimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(perimeter(10,6,4));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
