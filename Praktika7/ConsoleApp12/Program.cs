namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4, m = 5;
            int[,] matrix = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = matrix[i, 0];
                matrix[i, 0] = matrix[i, minIndex];
                matrix[i, minIndex] = temp;
            }
            Console.WriteLine("Матрица после обмена:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}