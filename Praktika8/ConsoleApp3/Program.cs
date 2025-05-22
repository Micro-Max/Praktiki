namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nКод символа: {(int)c}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}