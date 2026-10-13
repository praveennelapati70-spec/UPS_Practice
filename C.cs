
using System;
class C
{
    public static void Pink()
    {
        Console.WriteLine("Enter the number:");
        int m = Convert.ToInt32(Console.ReadLine());

        int original = m;
        int palindrome = 0;

        while (m != 0)
        {
            int d = m % 10;
            palindrome = (palindrome * 10) + d;
            m = m / 10;
        }

        if (palindrome == original)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
