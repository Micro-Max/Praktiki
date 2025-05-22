namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content1 = File.ReadAllText("file1.txt");
            string content2 = File.ReadAllText("file2.txt");
            File.WriteAllText("result.txt", content1 + content2);
            Console.WriteLine("Файлы объединены");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}