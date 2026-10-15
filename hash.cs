
using System;
using System.Collections;

class V
{
    public static void T()
    {
        Console.Write("Enter the size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Hashtable red = new Hashtable();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value: ");
            string value = Console.ReadLine();

            red[key] = value;
        }

        if (red.ContainsKey(2))
        {
            red.Remove(2);
        }

        foreach (DictionaryEntry v in red)
        {
            Console.WriteLine(v.Key + " : " + v.Value);
        }
    }
}
