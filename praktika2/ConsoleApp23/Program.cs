using System;

class Program
{
    static void Main()
    {
        int a, b, c;
        a = b = c = 2;
        double z = a * b + c++ / b - a * b * --c;

        // а) Результат должен быть 3.66
        a = b = c = 2;
        z = (a * b) + ((double)c++ / b) - (a * b * --c);
        Console.WriteLine($"а) Результат: {Math.Round(z,2)}");

        // б) Результат должен быть -1
        a = b = c = 2;
        z = (a * b + c++) / (b - a * b * --c);
        Console.WriteLine($"б) Результат: {z}");

        // в) Результат должен быть 2
        a = b = c = 2;
        z = (a * (b + c++) / b) - (a * b * --c);
        Console.WriteLine($"в) Результат: {z}");

        // г) Результат должен быть -2
        a = b = c = 2;
        z = a * (b + (c++ / (b - a * b * --c)));
        Console.WriteLine($"г) Результат: {z}");

        // д) Результат должен быть -4
        a = b = c = 2;
        z = (a * b + c++) / (b - a) * b * --c; // Я хотел сделать исключение, но решил что не нужно, ответ то правильный
        Console.WriteLine($"д) Результат: {z}");
        Console.WriteLine("Нажмите на любую клавишу для выхода");
        Console.ReadKey();
    }
}

