namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(c))
                Console.WriteLine("Это цифра");
            else if (char.IsLetter(c))
                Console.WriteLine("Это буква");
            else
                Console.WriteLine("Это спецсимвол");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}