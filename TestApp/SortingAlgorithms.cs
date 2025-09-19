using System;

public class SortingAlgorithms
{
    public static void Run()
    {
        int[] numbers = { 5, 2, 8, 1, 3 };
        Array.Sort(numbers);
        Console.Write("Array ordenado: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
