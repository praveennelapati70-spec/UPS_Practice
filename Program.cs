using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your Year: ");
        int s= Convert.ToInt32(Console.ReadLine());
        if(s==4){
            Console.Write("Enter your Cgpa");
            int  r=Convert.ToInt32(Console.ReadLine());
            if(r>8){
                Console.Write("Enter your Backlogs");
                int m=Convert.ToInt32(Console.ReadLine());
                if(m==0){
                Console.WriteLine("Eligible");} 
                else{
                    Console.WriteLine("Not Eligible");
                }
            }
            else{
                Console.WriteLine("You have less cgpa");
            }
        }else{
            Console.WriteLine("Your not the final year student");
        }
        
        
        
    }
}