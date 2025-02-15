using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = num > 1;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine(num + " is a Prime Number.");
        else
            Console.WriteLine(num + " is not a Prime Number.");
    }
}