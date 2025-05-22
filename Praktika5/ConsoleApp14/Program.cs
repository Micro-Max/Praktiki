namespace ConsoleApp14
{
    internal class Program
    {
        static double Avg()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите оценку по предмету {i}: ");
                sum += int.Parse(Console.ReadLine());
            }
            return sum / 10.0;
        }
        static void Main(string[] args)
        {
            Avg();
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
