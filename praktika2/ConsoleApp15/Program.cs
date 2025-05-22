namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a:");
            string a = Console.ReadLine();
            Console.Write("Введите число b:");
            string b = Console.ReadLine();
            float x = -float.Parse(b) / float.Parse(a);
            Console.WriteLine("Число x в уравнении ax+b=0, равно:" + x);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
