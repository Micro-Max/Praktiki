namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 5];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                }
            }
            int minRow = 0, minCol = 0;
            int minAbs = Math.Abs(matrix[0, 0]);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int currentAbs = Math.Abs(matrix[i, j]);
                    if (currentAbs < minAbs)
                    {
                        minAbs = currentAbs;
                        minRow = i;
                        minCol = j;
                    }
                }
            }
            Console.WriteLine($"Наименьший по модулю элемент: {matrix[minRow, minCol]} в строке {minRow}, столбце {minCol}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}