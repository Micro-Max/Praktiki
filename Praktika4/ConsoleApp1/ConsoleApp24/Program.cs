namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;
            int odd = 1;
            for (int num = 1; num <= 10; num++)
            {
                totalSum += odd;
                odd += 2 * num + 1; 
            }
            Console.WriteLine($"Сумма квадратов от 1 до 10: {totalSum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
