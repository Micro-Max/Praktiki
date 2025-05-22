namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину катета a:");
            string a = Console.ReadLine();
            Console.Write("Введите длину катета b:");
            string b = Console.ReadLine();
            double c = double.RootN(int.Parse(a) * int.Parse(a) + int.Parse(b) * int.Parse(b),2);
            Console.WriteLine("Длина гипотенузы равна: " + c);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
