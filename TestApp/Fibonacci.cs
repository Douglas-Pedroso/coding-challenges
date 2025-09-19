using System;

public class Fibonacci
{
    public static void Run()
    {
        int n = 10;
        int a = 0, b = 1;
        Console.Write("Fibonacci: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
}
