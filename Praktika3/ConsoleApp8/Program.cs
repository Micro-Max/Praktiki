namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());
            double max = num1 > num2 ? num1 : num2;
            double min = num1 < num2 ? num1 : num2;
            Console.WriteLine($"Максимальное число: {max}");
            Console.WriteLine($"Минимальное число: {min}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
