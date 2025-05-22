namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 100);
            Console.WriteLine($"Вы ввели: {num}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
