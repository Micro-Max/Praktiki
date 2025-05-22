namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            double b = 2.6;
            b = a + b;
            Console.WriteLine("Сумма двух чисел равна: " + b);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
