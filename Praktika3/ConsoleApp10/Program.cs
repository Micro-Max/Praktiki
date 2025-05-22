namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четыре различных числа:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double max = Math.Max(Math.Max(a, b), Math.Max(c, d));
            double min = Math.Min(Math.Min(a, b), Math.Min(c, d));
            Console.WriteLine($"Наибольшее число: {max}");
            Console.WriteLine($"Наименьшее число: {min}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
