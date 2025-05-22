using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырёхзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int digit1 = number / 1000;        
        int digit2 = (number / 100) % 10;  
        int digit3 = (number / 10) % 10;   
        int digit4 = number % 10;          

        int sum = digit1 + digit2 + digit3 + digit4;
        int product = digit1 * digit2 * digit3 * digit4;

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
        Console.WriteLine("Нажмите на любую клавишу для выхода");
        Console.ReadKey();
    }
}