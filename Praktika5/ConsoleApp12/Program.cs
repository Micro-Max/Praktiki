namespace ConsoleApp12
{
    internal class Program
    {
        static int numran()
        {
            int number;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100);

            Console.WriteLine("Введенное число: " + number);
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(numran());
            Console.WriteLine("Нажмите любую клвашишу дял завершения...");
            Console.ReadKey();
        }
    }
}
