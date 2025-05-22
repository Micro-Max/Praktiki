namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите первое число:");
            string a = Console.ReadLine();
            Console.Write("Введите второе число:");
            string b = Console.ReadLine();
            Console.WriteLine("Случайное числов в промежутке между чисел: "+rnd.Next(int.Parse(a),int.Parse(b)));
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
