namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            string a = Console.ReadLine();
            Console.WriteLine(int.Parse(a) + " - вот такое число Вы ввели");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
