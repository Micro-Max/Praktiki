namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 6];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            int[] rowSums = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = 0; j < 6; j++)
                {
                    sum += matrix[i, j];
                }
                rowSums[i] = sum;
            }
            Console.WriteLine("Суммы строк:");
            int maxSum = rowSums[0];
            foreach (int sum in rowSums)
            {
                Console.Write(sum + " ");
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            Console.WriteLine($"Максимальная сумма: {maxSum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}