namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в двоичной системе (N2): ");
            string binary = Console.ReadLine();
            int decimalNumber = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                char digitChar = binary[i];
                if (digitChar != '0' && digitChar != '1')
                {
                    Console.WriteLine("Ошибка: число должно содержать только 0 и 1!");
                    return;
                }
                int digit = digitChar - '0';
                decimalNumber = decimalNumber * 2 + digit;
            }
            Console.WriteLine($"В десятичной системе: {decimalNumber}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
