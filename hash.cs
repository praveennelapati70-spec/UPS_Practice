
using System;
using System.Collections.Generic;

class V
{
    public static void T()
    {
        Console.Write("Enter the size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<int ,int > red = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value: ");
            int value = Convert.ToInt32(Console.ReadLine());
              
              red.Add(key,value);
            
        }

        if (red.ContainsKey(2))
        {
            red.Remove(2);
        }

        foreach (KeyValuePair<int,int>  v in red)
        {
            Console.WriteLine(v.Key + " : " + v.Value);
        }
    }
}
