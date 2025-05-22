namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine("\tНажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}