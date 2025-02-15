using System;

class ParseExample
{
    static void Main()
    {
        string validNumber = "123";
        string invalidNumber = "ABC";
        int parsedNumber;

        if (int.TryParse(validNumber, out parsedNumber))
        {
            Console.WriteLine("TryParse Success: " + parsedNumber);
        }
        else
        {
            Console.WriteLine("TryParse Failed");
        }

        try
        {
            int result = int.Parse(invalidNumber);
            Console.WriteLine("Parse Success: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse Failed: Invalid Format");
        }
    }
}