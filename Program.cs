// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        //numbers = {1, 2, 3, 4, 5} -> target = 4
        //numbers = {2, 4, 3} -> target = 4
        //numbers = {1, 5, 8, 9}; -> target = 2
        int[] numbers = {1, 5, 8, 9};
        int target = 4;

        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Target has been reached in index number {i}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Target not found in array data");
        }
    }
}