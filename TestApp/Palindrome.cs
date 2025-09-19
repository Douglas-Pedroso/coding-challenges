using System;
//teste
public class Palindrome
{
    public static void Run()
    {
        string word = "radar";
        string reversed = "";
        foreach (char c in word)
        {
            reversed = c + reversed;
        }
        Console.WriteLine(word + " é palíndromo? " + (word == reversed));
    }
}
