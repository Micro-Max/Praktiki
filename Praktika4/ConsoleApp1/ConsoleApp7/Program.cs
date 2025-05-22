namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double num;
            do
            {
                Console.Write("Введите число (0 для выхода): ");
                num = double.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
