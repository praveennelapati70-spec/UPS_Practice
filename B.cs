

class B
{
    public static void Hello()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0 ||
            (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
    }
}