namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            int c = 3;
            int d = 2;
            int e = 1;

            if (b > a || d > c || e > d)
            {
                Console.WriteLine("Неправильное значение сторон");
            }
            else
            {
                double n1 = (a / (double)d) * (b / (double)e);
                double n2 = (b / (double)d) * (a / (double)e);
                double x = n1 > n2 ? n1 : n2;

                double m1 = (a / (double)c) * (b / (double)d);
                double m2 = (b / (double)c) * (a / (double)d);
                double y = m1 > m2 ? m1 : m2;

                double l1 = (a / (double)c) * (b / (double)e);
                double l2 = (b / (double)c) * (a / (double)e);
                double z = l1 > l2 ? l1 : l2;

                if (x > y && x > z)
                {
                    if (n1 > n2)
                    {
                        Console.WriteLine("Вдоль длинной стороны, используя плоскость (d;e)");
                    }
                    else
                    {
                        Console.WriteLine("Вдоль короткой стороны, используя плоскость (e;d)");
                    }
                }
                else if (y > x && y > z)
                {
                    if (m1 > m2)
                    {
                        Console.WriteLine("Вдоль длинной стороны, используя плоскость (c;d)");
                    }
                    else
                    {
                        Console.WriteLine("Вдоль короткой стороны, используя плоскость (d;c)");
                    }
                }
                else if (z > x && z > y)
                {
                    if (l1 > l2)
                    {
                        Console.WriteLine("Вдоль длинной стороны, используя плоскость (c;e)");
                    }
                    else
                    {
                        Console.WriteLine("Вдоль короткой стороны, используя плоскость (e;c)");
                    }
                }
                Console.WriteLine("Нажмите на любую клавишу для выхода");
                Console.ReadKey();
            }
        }
    }
}
