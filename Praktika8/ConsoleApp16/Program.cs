namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data.txt");
            string[] filtered = lines.Where(line => line.Length >= 5).ToArray();
            File.WriteAllLines("filtered.txt", filtered);
            Console.WriteLine($"Удалено {lines.Length - filtered.Length} строк");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}