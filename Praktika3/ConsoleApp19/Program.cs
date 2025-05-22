namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день года (1-365):");
            int k = int.Parse(Console.ReadLine());
            int dayOfWeek = (k - 1) % 7;
            bool isWeekend = dayOfWeek == 5 || dayOfWeek == 6;
            string day = dayOfWeek == 5 || dayOfWeek == 6 ? "суббота" : "воскресенье";
            Console.WriteLine($"День {k} является выходным: {isWeekend}");
            Console.WriteLine($"День конкретно {day}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
