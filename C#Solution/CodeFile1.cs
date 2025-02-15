using System;

class LoopExamples
{
    static void Main()
    {
        Console.WriteLine("For Loop Example:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("While Loop Example:");
        int count = 1;
        while (count <= 5)
        {
            Console.WriteLine(count);
            count++;
        }

        Console.WriteLine("Do-While Loop Example:");
        int num = 1;
        do
        {
            Console.WriteLine(num);
            num++;
        } while (num <= 5);
    }
}