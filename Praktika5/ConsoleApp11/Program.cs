namespace ConsoleApp11
{
    internal class Program
    {
        static int Convert(int number, int originalBase)
        {
            if (originalBase < 2 || originalBase > 10)
                Console.WriteLine("Система счисления должна быть в пределах от 2 до 10");
            bool isNegative = number < 0;
            number = Math.Abs(number);
            int result = 0;
            int power = 1;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit >= originalBase)
                    Console.WriteLine($"Некорректная цифра {digit} для основания {originalBase}");

                result += digit * power;
                power *= originalBase;
                number /= 10;
            }
            return isNegative ? -result : result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Convert(101011, 2));
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
