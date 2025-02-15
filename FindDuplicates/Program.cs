using System;
using System.Collections.Generic;

class FindDuplicates
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 5 };
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in numbers)
        {
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        Console.WriteLine("Duplicate Numbers:");
        foreach (int dup in duplicates)
        {
            Console.WriteLine(dup);
        }
    }
}