namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y = x > 0 ? Math.Sin(x) : Math.Cos(x);
            Console.WriteLine($"Значение y = {y}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
