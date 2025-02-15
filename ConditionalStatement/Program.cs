using System;

class ConditionalStatements
{
    static void Main()
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Positive Number");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative Number");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}