namespace ConsoleApp8
{
    internal class Program
    {
        static double SerX(double x)
        {
            double sum = 0;
            int sign = 1;
            for (int i = 1; i <= 11; i += 2)
            {
                sum += sign * Math.Pow(x, i) / i;
                sign = -sign;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SerX(10));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
