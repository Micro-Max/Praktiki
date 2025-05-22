namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вывода с точностью до сотой: ");
            string c = Console.ReadLine();
            int n = 2;
            Console.WriteLine("Число с точностью до сотой: " + Math.Round(float.Parse(c),n));
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
