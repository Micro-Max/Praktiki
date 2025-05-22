namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4 , b = 5 ;
            double ArithAvg = Convert.ToDouble(a + b) / 2;
            float GeomethAvg = float.RootN((a * b),2);
            Console.WriteLine("Среднее арифметическое: " + ArithAvg);
            Console.WriteLine("Среднее геометрическое: " + GeomethAvg);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
