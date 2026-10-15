
using System;
using System.Collections;

class Sorted
{
    public static void F()
    {
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        SortedList red = new SortedList();

        for (int j = 0; j < n; j++)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            red.Add(num, num);
        }

        if (red.ContainsKey(2))
        {
            red.Remove(2);
        }

        foreach (DictionaryEntry v in red)
        {
            Console.WriteLine(v.Value);
        }
    }

   
}
