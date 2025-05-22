namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };
            int[] diff1 = array1.Except(array2).ToArray();
            Console.WriteLine("19.1. Элементы в первом, но не во втором: " + string.Join(", ", diff1));
            int[] intersection = array1.Intersect(array2).ToArray();
            Console.WriteLine("19.2. Общие элементы: " + string.Join(", ", intersection));
            int[] union = array1.Union(array2).Except(intersection).ToArray();
            Console.WriteLine("19.3. Объединение без общих элементов: " + string.Join(", ", union));
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}