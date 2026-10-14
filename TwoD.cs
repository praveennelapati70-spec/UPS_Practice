using System;
using System.Data;
using System.Numerics;
class M
{
    public static void R()
    {   Console.Write("Enter the layer:");
        int p=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Column:");
        int j=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the row:");
        int k=Convert.ToInt32(Console.ReadLine());
        int [,,] arr=new int[p,j,k];
        for(int i = 0; i < p; i++)
        {
            for(int m = 0; m < k; m++)
            { 
                for(int r = 0; r < j; r++)
                {
                Console.Write($"Enter the value:{i},{m},{r} : ");
                arr[i,m,r]=Convert.ToInt32(Console.ReadLine());
                }   
            }

        }
         for(int i = 0; i < p; i++)
        {
            Console.WriteLine("layer" + i);

            for(int m = 0; m < k; m++)
            {
                for(int r = 0; r < j; r++)
                {
                  Console.Write(arr[i,m,r] + "\t");
                }
                 Console.WriteLine();

            }
        }
        int sum=0;
        int max=0;
        int min=int.MaxValue;
        for(int i = 0; i < p; i++)
        {
            for(int m = 0; m < k; m++)
            {
                for(int r = 0; r < j; r++)
                {
                    sum+=arr[i,m,r];
                 max=Math.Max(max,arr[i,m,r]);
                 min=Math.Min(min,arr[i,m,r]);
                }
                 

            }
        }
        Console.WriteLine(sum);
        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}