using System;

public class PrimeNumbers
{
    public static void Run()
    {
        int number = 17;
        bool isPrime = true;
        if (number < 2) isPrime = false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) isPrime = false;
        }
        Console.WriteLine(number + " é primo? " + isPrime);
    }
}
