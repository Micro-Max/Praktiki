namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите время в минутах:");
            double t = double.Parse(Console.ReadLine());
            int cycle = (int)t % 5;
            string color = cycle < 3 ? "зеленый" : "красный";
            Console.WriteLine($"В {t} минут горит {color} сигнал");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
