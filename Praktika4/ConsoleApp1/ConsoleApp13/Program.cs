namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите количество повторений: ");
            int K = int.Parse(Console.ReadLine());
            for (int i = 0; i < K; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
