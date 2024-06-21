﻿
internal class Program
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");
    }
}
