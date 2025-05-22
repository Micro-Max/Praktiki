namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.Write("Что заменить: ");
            string oldValue = Console.ReadLine();
            Console.Write("На что заменить: ");
            string newValue = Console.ReadLine();
            string result = input.Replace(oldValue, newValue);
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}