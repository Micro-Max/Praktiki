namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            double num;
            do
            {
                Console.Write("Введите число (0 для выхода): ");
                num = double.Parse(Console.ReadLine());
                sum += num;
                if (num != 0) count++;
            } while (num != 0);
            Console.WriteLine($"Среднее арифметическое: {sum / count}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
