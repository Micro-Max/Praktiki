namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Честно, почти всю логику методов писал я. С linq тоже сам разбирался, тот же sql, но в другой обёртке.  
            // НО как сделать некоторые методы я вообще не понял. Так что тут,нейронка конкертно помогла
            // Так что оформление тоже с нейронки, извините 
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine("5.1. Сумма элементов с четными индексами: " + SumEvenIndexes(array));
            Console.WriteLine("5.2. Минимальный положительный элемент: " + MinPositive(array));
            Console.WriteLine("5.3. Сумма максимального и минимального элементов: " + (MaxElement(array) + MinElement(array)));
            Console.WriteLine("5.4. Количество положительных элементов: " + CountPositive(array));

            Console.Write("Введите a и b для задачи 5.5: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("5.5. Сумма четных положительных с индексами от a до b: " + SumEvenPositiveInRange(array, a, b));
            Console.WriteLine("5.6. Среднее значение четных элементов: " + AverageEven(array));
            Console.WriteLine("5.7. Сумма четных положительных элементов: " + SumEvenPositive(array));
            Console.WriteLine("5.8. Сумма неотрицательных на четных местах: " + SumNonNegativeEvenPositions(array));
            Console.Write("Введите a и b для задачи 5.9: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            var (max, index) = MaxInRange(array, a, b);
            Console.WriteLine($"5.9. Максимальный элемент с {a} по {b}: {max}, его индекс: {index}");
            Console.WriteLine("5.10. Минимальный на четных позициях: " + MinOnEvenPositions(array));
            Console.Write("Введите a и b для задачи 5.11: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            var (min, minIndex) = MinInRange(array, a, b);
            Console.WriteLine($"5.11. Минимальный элемент с {a} по {b}: {min}, его индекс: {minIndex}");
            Console.WriteLine("5.12. Среднее арифметическое с нечетными индексами: " + AverageOddIndexes(array));
            Console.WriteLine("5.13. Среднее арифметическое элементов не превышающих 50: " + AverageLessThan50(array));
            var (evenIndexArr, oddIndexArr) = SplitByIndexParity(array);
            Console.WriteLine("5.14. Массив с четными индексами: " + string.Join(", ", evenIndexArr));
            Console.WriteLine("5.14. Массив с нечетными индексами: " + string.Join(", ", oddIndexArr));
            var (evenOddArr, oddEvenArr) = SplitByValueAndIndexParity(array);
            Console.WriteLine("5.15. Четные элементы с нечетными индексами: " + string.Join(", ", evenOddArr));
            Console.WriteLine("5.15. Нечетные элементы с четными индексами: " + string.Join(", ", oddEvenArr));
        }
        static int SumEvenIndexes(int[] arr) => arr.Where((x, i) => i % 2 == 0).Sum();
        static int MinPositive(int[] arr) => arr.Where(x => x > 0).Min();
        static int MaxElement(int[] arr) => arr.Max();
        static int MinElement(int[] arr) => arr.Min();
        static int CountPositive(int[] arr) => arr.Count(x => x > 0);
        static int SumEvenPositiveInRange(int[] arr, int a, int b) => arr.Skip(a).Take(b - a + 1).Where((x, i) => x > 0 && x % 2 == 0).Sum();
        static double AverageEven(int[] arr) => arr.Where(x => x % 2 == 0).Average();
        static int SumEvenPositive(int[] arr) => arr.Where(x => x > 0 && x % 2 == 0).Sum();
        static int SumNonNegativeEvenPositions(int[] arr) => arr.Where((x, i) => i % 2 != 0 && x >= 0).Sum();
        static (int max, int index) MaxInRange(int[] arr, int a, int b)
        {
            var subArray = arr.Skip(a).Take(b - a + 1).ToArray();
            int max = subArray.Max();
            int index = Array.IndexOf(subArray, max) + a;
            return (max, index);
        }
        static (int min, int index) MinOnEvenPositions(int[] arr)
        {
            var evenPos = arr.Where((x, i) => i % 2 == 0).ToArray();
            int min = evenPos.Min();
            int index = Array.IndexOf(arr, min);
            return (min, index);
        }
        static (int min, int index) MinInRange(int[] arr, int a, int b)
        {
            var subArray = arr.Skip(a).Take(b - a + 1).ToArray();
            int min = subArray.Min();
            int index = Array.IndexOf(subArray, min) + a;
            return (min, index);
        }
        static double AverageOddIndexes(int[] arr) => arr.Where((x, i) => i % 2 != 0).Average();
        static double AverageLessThan50(int[] arr) => arr.Where(x => x <= 50).Average();
        static (int[] evenIndex, int[] oddIndex) SplitByIndexParity(int[] arr) =>
            (arr.Where((x, i) => i % 2 == 0).ToArray(), arr.Where((x, i) => i % 2 != 0).ToArray());
        static (int[] evenOdd, int[] oddEven) SplitByValueAndIndexParity(int[] arr) =>
            (arr.Where((x, i) => x % 2 == 0 && i % 2 != 0).ToArray(), arr.Where((x, i) => x % 2 != 0 && i % 2 == 0).ToArray());
    }
}