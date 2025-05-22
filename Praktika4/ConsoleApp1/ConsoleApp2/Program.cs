namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную сумму вклада: ");
            double sum = double.Parse(Console.ReadLine());
            int months = 0;
            while (sum < 100000)
            {
                sum *= 1.02; // Увеличение на 2%
                months++;
            }
            Console.WriteLine($"Потребуется месяцев: {months}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
