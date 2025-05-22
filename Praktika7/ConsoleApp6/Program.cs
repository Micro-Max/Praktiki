namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 10];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rand.Next(-5, 5);
                }
            }
            Console.WriteLine("Номера строк с положительными элементами:");
            for (int i = 0; i < 5; i++)
            {
                bool allPositive = true;
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        allPositive = false;
                        break;
                    }
                }
                if (allPositive)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}