namespace ConsoleApp15
{

    internal class Program
    {
        static int calc(double deposit, double percent, double target)
        {
            int months = 0;
            while (deposit < target)
            {
                deposit += deposit * (percent / 100);
                months++;
            }
            return months;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(calc(100000,11,1000000));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
