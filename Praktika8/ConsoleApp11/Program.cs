namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово для поиска: ");
            string word = Console.ReadLine();
            string text = File.ReadAllText("text.txt");
            int count = text.Split(new[] { word }, StringSplitOptions.None).Length - 1;
            Console.WriteLine($"Количество вхождений: {count}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}