namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 35; i++) // (а) от 20 до 35
            {
                Console.WriteLine(i);
            }
            Console.Write("Введите b (b > 10): "); // (б) квадраты от 10 до b
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.Write("Введите a (a < 50): ");// (в) кубы от a до 50
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(i * i * i);
            }
            Console.Write("Введите a: "); // (г) числа от a до b (b < a)
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите b (b < a): ");
            int d = int.Parse(Console.ReadLine());
            for (int i = c; i >= d; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
