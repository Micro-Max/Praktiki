namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число:");
            int number = int.Parse(Console.ReadLine());
            bool endEven = number % 10 % 2 == 0;
            bool endOdd = !endEven;
            Console.WriteLine($"Число оканчивается четной цифрой: {endEven}");
            Console.WriteLine($"Число оканчивается нечетной цифрой: {endOdd}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
