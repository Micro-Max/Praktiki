namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 5];
            Random rand = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(20, 41);
                }
            }
            int resultRow = -1;
            for (int i = 0; i < 8; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                if (evenCount <= 3)
                {
                    resultRow = i + 1;
                    break;
                }
            }
            Console.WriteLine($"Номер строки с не более 3-мя чётными числами: {resultRow}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}