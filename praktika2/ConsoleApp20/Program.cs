namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = -5;
            double ArithAvg = Convert.ToDouble(Math.Abs(a) + Math.Abs(b)) / 2;
            float GeomethAvg = float.RootN((Math.Abs(a) * Math.Abs(b)), 2);
            Console.WriteLine("Среднее арифметическое: " + ArithAvg);
            Console.WriteLine("Среднее геометрическое: " + GeomethAvg);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
