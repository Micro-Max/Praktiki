namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double y = double.Parse(Console.ReadLine());
            bool a = x < 2 && y < 3;
            bool b = !(x < 2);
            bool c = x < 2 || y < 2;
            bool d = !(x < 0 && x < 5);
            bool e = x < 0 && y > 0;
            bool f = 10 < x && x < 20;
            bool g = x > 3 || x < 1;
            bool h = (0 < y && y < 4) && x < 5;
            bool j = x > 3 && x < 10; 
            Console.WriteLine($"{a},{b},{c},{d},{e},{f},{g},{h},{j}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
