﻿namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;
            int shotCount = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index >= 0 && index < array.Length)
                {
                    if (array[index] != -1)
                    {
                        int shotTargetValue = array[index];
                        array[index] = -1;
                        shotCount++;

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] != -1)
                            {
                                if (array[i] <= shotTargetValue)
                                {
                                    array[i] += shotTargetValue;
                                }
                                else
                                {
                                    array[i] -= shotTargetValue;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotCount} -> {string.Join(" ", array)}");
        }
    }
}
