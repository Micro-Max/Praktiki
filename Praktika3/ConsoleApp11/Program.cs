namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние в километрах:");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах:");
            double feet = double.Parse(Console.ReadLine());
            double kmToMeters = km * 1000;
            double feetToMeters = feet * 0.305;
            string result = kmToMeters < feetToMeters ? "Километровое расстояние меньше" : "Расстояние в футах меньше";
            Console.WriteLine(result);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
