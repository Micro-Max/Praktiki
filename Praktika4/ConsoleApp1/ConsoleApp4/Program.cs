namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            string base5 = "";
            while (N > 0)
            {
                base5 = (N % 5) + base5;
                N /= 5;
            }
            Console.WriteLine($"В пятеричной системе: {base5}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
