using System;

class Program
{
    static void Main()
    {
        double a;
        // а) a^4 за две операции
        Console.Write("Введите число a: ");
        a = double.Parse(Console.ReadLine());
        a = a * a;
        a = a * a; 
        Console.WriteLine($"a) a^4 = {a}");


        // б) a^6 за три операции
        Console.Write("Введите число a: ");
        a = double.Parse(Console.ReadLine());
        double temp = a * a; 
        a = temp * temp * temp; 
        Console.WriteLine($"б) a^6 = {a}");

        // в) a^7 за четыре операции
        Console.Write("Введите число a: ");
        a = double.Parse(Console.ReadLine());
        temp = a * a; 
        a = temp * temp * temp * a; 
        Console.WriteLine($"в) a^7 = {a}");

        // г) a^8 за три операции
        Console.Write("Введите число a: ");
        a = double.Parse(Console.ReadLine());
        temp = a * a; 
        temp = temp * temp; 
        a = temp * temp; 
        Console.WriteLine($"г) a^8 = {a}");

        // д) a^9 за четыре операции
        Console.Write("Введите число a: ");
        a = double.Parse(Console.ReadLine());
        temp = a * a * a; 
        a = temp * temp * temp; 
        Console.WriteLine($"д) a^9 = {a}");

        // е) a^10 за четыре операции
        Console.Write("Введите число a: ");
        a = double.Parse(Console.ReadLine());
        temp = a * a; 
        double temp2 = temp * a; 
        a = temp * temp * temp2 * temp2; 
        Console.WriteLine($"е) a^10 = {a}");
        Console.WriteLine("Нажмите на любую клавишу для выхода");
        Console.ReadKey();
    }
}