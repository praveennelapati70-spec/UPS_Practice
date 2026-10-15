using System;
using System.Collections;

class Nokia
{
    public static void P()
    {
       Console.Write("Enter the size:");
       int i=Convert.ToInt32(Console.ReadLine());
       ArrayList red=new ArrayList(i);
       for(int k = 0; k < i; k++)
        {   Console.Write("Enter the Element:");
            red.Add(Console.ReadLine());
        }
        if (red.Contains(2))
        {
            red.Remove(2);
        }
        foreach(Object v in red)
        {
            Console.WriteLine(v);
        }

    }
}