namespace ConsoleApp10
{
    internal class Program
    {
        static string Convert(int number, int baseNum)
        {
            if (baseNum < 2 || baseNum > 10)
                Console.WriteLine("Система счисления должна быть в пределах от 2 до 10");
                

            if (number == 0) return "0";

            string res = "";
            bool negative = number < 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int rem = number % baseNum;
                res = rem + res;
                number /= baseNum;
            }

            return negative ? "-" + res : res;
        }
        static void Main(string[] args)
        {
            Convert(101,2);
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
