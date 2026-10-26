using System;
class Odd
{
    public static void Y()
    {
        Console.Write("Enter a row:");
        int size=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a column:");
        int r=Convert.ToInt32(Console.ReadLine());
        int [,] arr=new int[size,r];
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < r; j++)
            {
            Console.WriteLine("Enter the element");
            arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
            
            
        }
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < r; j++)
            {
                if (arr[i,j] % 2 != 0)
            {
                Console.Write(arr[i,j]);
            }
            }
            
        }
    }
}