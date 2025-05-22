namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = Math.E;
            int n = 1;
            Console.WriteLine("Число с точностью до десятой: " + Math.Round(c, n));
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
