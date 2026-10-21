
using System;

class NumberAnalyzer
{
    public static void G()
    {
        int[] arr = new int[8];
        int count = 0;

        while (count < 8)
        {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                arr[count] = num;
                count++;
            }
            
        }
        int even = 0, odd = 0;
        int positive = 0, negative = 0, zero = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;

            if (arr[i] > 0)
                positive++;
            else if (arr[i] < 0)
                negative++;
            else
                zero++;
        }

        Console.WriteLine("\nEven: " + even);
        Console.WriteLine("Odd: " + odd);
        Console.WriteLine("Positive: " + positive);
        Console.WriteLine("Negative: " + negative);
        Console.WriteLine("Zero: " + zero);

        int largest = 0, second = 0;
        bool hasLargest = false, hasSecond = false;

        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];

            if (!hasLargest || n > largest)
            {
                if (hasLargest)
                {
                    second = largest;
                    hasSecond = true;
                }

                largest = n;
                hasLargest = true;
            }
            else if (n < largest && (!hasSecond || n > second))
            {
                second = n;
                hasSecond = true;
            }
        }

        if (hasSecond)
            Console.WriteLine("Second largest: " + second);
        else
            Console.WriteLine("No second-largest distinct number.");

        Console.Write("Reversed array: ");

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }
}
