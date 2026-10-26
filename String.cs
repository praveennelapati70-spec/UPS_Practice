using System;
class String
{
    public static void X()
    { Console.Write("Enter a Size:");
      int i=Convert.ToInt32(Console.ReadLine()); 
        string  [] arr=new string [i];
        for(int k = 0; k < i; k++)
        {
            Console.Write("Enter the Strings:");
            arr[k]=Console.ReadLine();
        }
        for(int r = 0; r < i; r++)
        {
            Console.WriteLine(arr[r]);
        }
        
    }
}