using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int temp = num, sum = 0, digits = num.ToString().Length;

        while (temp > 0)
        {
            int remainder = temp % 10;
            sum += (int)Math.Pow(remainder, digits);
            temp /= 10;
        }

        if (sum == num)
            Console.WriteLine(num + " is an Armstrong number.");
        else
            Console.WriteLine(num + " is not an Armstrong number.");
    }
}