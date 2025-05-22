namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 8];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                }
            }

            Console.WriteLine("Номера столбцов с отрицательными элементами:");
            for (int j = 0; j < 8; j++)
            {
                bool hasNegative = false;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }
                if (hasNegative)
                {
                    Console.Write($"{j + 1} ");
                }
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}