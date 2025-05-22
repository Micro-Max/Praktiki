namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Цифры числа: ");
            while (N != 0)
            {
                int digit = N % 10;
                Console.Write(digit + " ");
                N /= 10;
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
