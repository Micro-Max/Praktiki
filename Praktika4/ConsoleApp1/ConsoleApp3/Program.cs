namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            string binary = "";
            while (N > 0)
            {
                binary = (N % 2) + binary;
                N /= 2;
            }
            Console.WriteLine($"В двоичной системе: {binary}");
            Console.WriteLine("Нажмите на любую клавишук для выхода...");
            Console.ReadKey();
        }
    }
}
