namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 50;
            int c = 10;
            int d = 5;
            int option1 = (a / c) * (b / d); 
            int option2 = (a / d) * (b / c); 
            string result = option1 > option2 ?
                "Размещать длинной стороной вдоль длинной стороны стола" :
                "Размещать длинной стороной вдоль короткой стороны стола";

            Console.WriteLine($"{result} (можно разместить {Math.Max(option1, option2)} прямоугольников)");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
