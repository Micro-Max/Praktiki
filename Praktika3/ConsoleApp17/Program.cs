namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год:");
            int year = int.Parse(Console.ReadLine());
            bool visyear = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            Console.WriteLine($"Год {year} високосный: {visyear}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
