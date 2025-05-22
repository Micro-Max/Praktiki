namespace ConsoleApp2
{
    internal class Program
    {
        static void Print(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] oneDArray = { 1, 2, 3, 4, 5 };
            int[,] twoDArray = { { 1, 2 }, { 3, 4 } };
            Print(oneDArray);
            Print(twoDArray);
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}