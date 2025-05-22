namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b:");
            int b = int.Parse(Console.ReadLine());
            bool adelb = b % a == 0;
            bool bdela = a % b == 0;
            Console.WriteLine($"Число a является делителем числа b: {adelb}");
            Console.WriteLine($"Число b является делителем числа a: {bdela}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
