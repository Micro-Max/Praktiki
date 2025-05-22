namespace ConsoleApp22
{
    internal class Program
    {
        static int min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(min(10,8,5));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
