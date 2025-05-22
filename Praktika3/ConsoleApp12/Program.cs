namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость в км/ч:");
            double kmh = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость в м/с:");
            double ms = double.Parse(Console.ReadLine());
            double kmhToMs = kmh * 1000 / 3600;
            string result = kmhToMs > ms ? "Скорость в км/ч больше" : "Скорость в м/с больше";
            Console.WriteLine(result);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
