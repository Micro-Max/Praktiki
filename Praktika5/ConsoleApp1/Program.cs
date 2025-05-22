namespace ConsoleApp1
{
    internal class Program
    {
        static void Print(int M, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(M + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Print(10,10);
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
