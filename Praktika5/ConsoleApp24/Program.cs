namespace ConsoleApp24
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,6));
            Console.WriteLine(Add(5, 6, 7));
            Console.WriteLine(Add(5, 6, 7, 8));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
