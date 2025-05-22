namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            bool C = !(!A && !B) && A;
            bool D = !(!A || !B) || !A;
            bool E = !(!A || !B) && B;
            Console.WriteLine($"не (не {A} и не {B}) и {A} = {C}");
            Console.WriteLine($"не (не {A} или не {B}) или не {A} = {D}");
            Console.WriteLine($"не (не {A} и не {B}) и {B} = {E}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
