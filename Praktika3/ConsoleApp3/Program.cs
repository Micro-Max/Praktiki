namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X (true/false): ");
            bool x = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Y (true/false): ");
            bool y = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Z (true/false): ");
            bool z = bool.Parse(Console.ReadLine());
            bool a = !(x || y) || (y == x);
            bool b = (x || y) == (y && x);
            bool c = (x && y) || (!y || x);
            bool d = !(x == y) || y;
            bool e = !(x || y) || (z == x);
            bool f = (x == (z || y)) || ((!x || z) && (!y || x));
            bool g = !y || (z == x);
            bool h = x == (!y || z);
            Console.WriteLine($"{x}\t{y}\t{z}\t{a}\t{b}\t{c}\t{d}\t{e}\t{f}\t{g}\t{h}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
