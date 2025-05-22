namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[15, 9];
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            for (int i = 0; i < 15; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < 9; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                Console.WriteLine($"Минимальный элемент строки {i}: {min}");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}