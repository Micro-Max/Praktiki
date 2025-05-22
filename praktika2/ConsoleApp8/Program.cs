namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            string a = Console.ReadLine();
            Console.WriteLine("Вы ввели число " + int.Parse(a));
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
