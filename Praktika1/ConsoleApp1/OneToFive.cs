namespace ConsoleApp1
{
    internal class OneToFive
    {
        static void Main(string[] args)
        {
            Console.Title = "Какой-то заголовок";
            /*Console.WriteLine(" C# — это современный, с открытым исходным кодом, объектно-ориентированный язык программирования.");
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();*/

            /*Console.WriteLine("C# — это современный,\n\t с открытым исходным кодом,\n\t\t объектно-ориентированный\n\t\t\t язык программирования.");
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();*/

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("C# — это современный, с открытым исходным кодом, объектно-ориентированный язык программирования.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
