namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float z; int a = 1, b = 2, c = 3;
            const int m = 3;
            z = (a + b + c) / m;
            Console.WriteLine(z);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
