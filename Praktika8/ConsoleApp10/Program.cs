namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("input.txt");
            Console.WriteLine(content);
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}