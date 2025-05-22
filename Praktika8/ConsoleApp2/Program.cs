namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(c))
            {
                char opposite = char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c);
                Console.WriteLine($"Результат: {opposite}");
            }
            else
            {
                Console.WriteLine("Введен не буквенный символ");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}