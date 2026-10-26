using System;
class Pro
{public static void R()
    {
        Console.Write("Enter a number:");
        int i=Convert.ToInt32(Console.ReadLine());
        Random obj=new Random();
        int coupon=obj.Next(1000,999);
        Console.WriteLine(coupon);
    }
}