namespace ConsoleApp16
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
            double threshold = 5.0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
                double average = sum / m;
                if (average < threshold)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество строк со средним арифметическим меньше {threshold}: {count}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}