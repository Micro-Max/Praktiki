namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 25; i++) // (а) 10 10.4, 11 11.4, ..., 25 25.4
            {
                Console.WriteLine($"{i} {i + 0.4}");
            }
            for (int i = 25; i <= 35; i++) // (б) 25 25.5 24.8, ..., 35 35.5 34.8
            {
                Console.WriteLine($"{i} {i + 0.5} {i - 0.2}");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
