using System;

public class SumArray
{
    public static void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("Soma do array: " + sum);
    }
}
