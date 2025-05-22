namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int M = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            Console.Write("Последовательность Фибоначчи: ");
            do
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            } while (a <= M);
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
