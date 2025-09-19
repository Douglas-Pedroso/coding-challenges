using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== Fibonacci ====");
        Fibonacci.Run();

        Console.WriteLine("\n==== Fatorial ====");
        Factorial.Run();

        Console.WriteLine("\n==== Números Primos ====");
        PrimeNumbers.Run();

        Console.WriteLine("\n==== Soma do Array ====");
        SumArray.Run();

        Console.WriteLine("\n==== Ordenação do Array ====");
        SortingAlgorithms.Run();

        Console.WriteLine("\n==== Inverter String ====");
        ReverseString.Run();

        Console.WriteLine("\n==== Palíndromo ====");
        Palindrome.Run();
    }
}
