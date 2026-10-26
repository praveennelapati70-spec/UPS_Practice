using System;
using System.Collections.Generic;
class List
{
    public static void E()
    {
        Console.Write("Enter the Elements:");
        int i=Convert.ToInt32(Console.ReadLine());
        HashSet<int> red=new HashSet<int>(i);
        for(int j = 0; j < i; j++)
        {
            Console.Write("Enter the Elements");
            red.Add(Convert.ToInt32(Console.ReadLine()));
        }
        if (red.Contains(2))
        {
            red.Remove(2);
        }
        else
        {
            red.Add(2);
        }
        foreach(int m in red)
        {
            Console.WriteLine(m);
        }

    }
}