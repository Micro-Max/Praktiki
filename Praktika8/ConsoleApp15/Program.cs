namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("book.txt");
            int charCount = content.Length;
            int wordCount = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int lineCount = content.Split('\n').Length;
            Console.WriteLine($"Символов: {charCount}");
            Console.WriteLine($"Слов: {wordCount}");
            Console.WriteLine($"Строк: {lineCount}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}