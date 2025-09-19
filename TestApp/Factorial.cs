using System;
//teste
public class Factorial
{
    public static void Run()
    {
        int number = 5;
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        Console.WriteLine("Fatorial de " + number + " é " + result);
    }
}
