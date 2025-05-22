namespace ConsoleApp4
{
    internal class Program
    {
        static int Factorial(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= i;
            }
            return result;
        }
        static double SumInFac(int n)
        {
            double sum = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumInFac(5));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
