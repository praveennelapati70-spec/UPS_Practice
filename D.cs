using System;
using System.Text;
class D
{
    public static void Blue()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        if (s == sb.ToString())
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
