namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение С (true/false): ");
            bool C = bool.Parse(Console.ReadLine());
            bool D = !(A || !B && C);
            bool E = A && !(B && A || !C);
            bool F = !(!A || B && C);
            bool G = !(A || !B && C) || C;
            bool H = !(A && !B || C) && B;
            bool Y = !(!A || B && C) || A;
            Console.WriteLine($"{D},{E},{F},{G},{H},{Y}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
