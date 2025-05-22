namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("20 ");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
