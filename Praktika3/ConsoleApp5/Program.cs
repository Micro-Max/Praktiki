namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());
            bool q = A > 100 && B > 100;
            bool w = A > 0 || B > 0;
            bool e = A % 3 == 0 && B % 3 == 0 && C % 3 == 0;
            bool r = (A < 50 && B >= 50 && C >= 50) || (A >= 50 && B < 50 && C >= 50) || (A >= 50 && B >= 50 && C < 50);
            bool u = A < 0 || B < 0 || C < 0;
            bool i = X % 2 != 0 && Y % 2 != 0;
            bool o = (X < 20 && Y >= 20) || (X >= 20 && Y < 20);
            bool p = X == 0 || Y == 0;
            bool s = X < 0 && Y < 0 && Z < 0;
            bool f = (X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 == 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 != 0 && Z % 5 == 0);
            bool g = X > 100 || Y > 100 || Z > 100;
            Console.WriteLine($"{q},{w},{e},{r},{u},{i},{o},{p},{s},{f},{g}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
