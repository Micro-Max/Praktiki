namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            bool c = A % 2 == 0 || A % 3 == 0;
            bool d = A % 3 != 0 && A % 10 == 0;
            bool e = N % 5 == 0 || N % 7 == 0;
            bool r = N % 4 == 0 && N % 10 != 0;
            Console.WriteLine($"{c},{d},{e},{r}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
