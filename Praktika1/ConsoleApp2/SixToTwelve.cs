namespace ConsoleApp2
{
    internal class SixToTwelve
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1 Проект 2."; // задать название окна
            Console.WindowWidth = 60; // задать ширину окна
            Console.WindowHeight = 13; //  задать длину окна
            Console.BackgroundColor = ConsoleColor.Blue; // задать цвет фона у окна
            Console.Clear(); //очистить консоль
            Console.SetCursorPosition(15, 6); // установить курсор на позицию

            //Console.Write("Введите своё имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Здравствуйте, " + name + "!");
            //Console.Write("Для заврешения нажмите на любую клавишу... ");   
            //Console.ReadKey();

            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {1} {0}!", surname, name);
            Console.Write("Для заврешения нажмите на любую клавишу... ");
            Console.ReadKey();

        }
    }
}
