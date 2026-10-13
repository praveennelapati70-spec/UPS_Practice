using System.Data;

class A
{
    static void Main()
    {
       Console.WriteLine("Enter the number");
       int N=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        do
        {  int d=N%10;
           sum+=d;
           N/=10; 
        }while(N!=0);
        Console.WriteLine(sum);
       
    }
     
}