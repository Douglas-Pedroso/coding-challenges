using System;
//test
public class ReverseString
{
    public static void Run()
    {
        string str = "Douglas";
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("String invertida: " + new string(arr));
    }
}
