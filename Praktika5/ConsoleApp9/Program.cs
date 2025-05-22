namespace ConsoleApp9
{
    internal class Program
    {
        static void Digi(int N)
        {
            if (N < 0) N = -N;
            if (N == 0)
            {
                Console.WriteLine("0 ");
                return;
            }
            int divisor = 1;
            while (N / divisor >= 10)
            {
                divisor *= 10;
            }
            while (divisor != 0)
            {
                int digit = N / divisor;
                Console.Write(digit + " ");
                N %= divisor;
                divisor /= 10;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Digi(123987);
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}