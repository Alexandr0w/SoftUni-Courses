﻿using System;

internal class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        decimal sum = 0;

        for (int i = 1; i <= count; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine(sum);
    }
}