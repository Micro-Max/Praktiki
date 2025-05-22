namespace ConsoleApp3
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
            static int SumFac(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumFac(5));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
