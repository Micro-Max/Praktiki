namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            c = Convert.ToDouble(a) + Convert.ToDouble(b) + c;
            Console.WriteLine("Сумма трёх чисел равна: " + c);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
