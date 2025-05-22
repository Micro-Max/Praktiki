namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 11];
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            int sum = 0;
            for (int j = 0; j < 11; j++)
            {
                int max = matrix[0, j];
                for (int i = 1; i < 6; i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                sum += max;
            }
            Console.WriteLine($"Сумма максимальных элементов столбцов: {sum}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}