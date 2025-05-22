namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга:");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата:");
            double a = double.Parse(Console.ReadLine());
            double circle = Math.PI * r * r;
            double square = a * a;
            string result = circle > square ? "Площадь круга больше" : "Площадь квадрата больше";
            Console.WriteLine(result);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
