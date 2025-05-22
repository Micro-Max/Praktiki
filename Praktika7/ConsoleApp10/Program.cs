namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[,] matrix = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            int maxSum = 0, maxRow = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                }
            }
            int[] result = new int[n];
            for (int j = 0; j < n; j++)
            {
                result[j] = matrix[maxRow, j];
            }
            Console.WriteLine("Строка с максимальной суммой:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}