﻿internal class Program
{
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());
        if (grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
    }
}