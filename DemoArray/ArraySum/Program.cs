﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[5];
        numbers[0] = 2;
        numbers[1] = 5;
        numbers[2] = 9;
        numbers[3] = 6;
        numbers[4] = 7;

        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total = total + numbers[i];
        }
        Console.WriteLine(total.ToString());
    }
}