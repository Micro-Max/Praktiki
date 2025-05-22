namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку с цифрами: ");
            string input = Console.ReadLine();
            string result = new string(input.Where(c => !char.IsDigit(c)).ToArray());
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}