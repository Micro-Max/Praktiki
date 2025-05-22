namespace ConsoleApp17
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
                    matrix[i, j] = rand.Next(0, 3);
                }
            }
            int lastRow = n - 1;
            bool allZeros = true;
            for (int j = 0; j < m; j++)
            {
                if (matrix[lastRow, j] != 0)
                {
                    allZeros = false;
                    break;
                }
            }
            if (allZeros && n > 1)
            {
                lastRow = n - 2;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 0 && i != lastRow)
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[lastRow, j];
                        matrix[lastRow, j] = temp;
                    }
                }
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