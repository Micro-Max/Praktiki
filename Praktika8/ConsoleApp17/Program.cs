namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите математическое выражение: ");
            string expression = Console.ReadLine();
            var result = new System.Data.DataTable().Compute(expression, null);
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}