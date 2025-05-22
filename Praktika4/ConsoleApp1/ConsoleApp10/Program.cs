namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int attempts = 0;
            int num;
            do
            {
                num = rnd.Next(1, 11);
                Console.WriteLine(num);
                attempts++;
            } while (num != 7);
            Console.WriteLine($"Потребовалось попыток: {attempts}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
