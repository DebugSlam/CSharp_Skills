using System;

namespace While;
class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int maximalNumber = int.MinValue;
        int sumAll = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > maximalNumber)
            {
                maximalNumber = number;
            }

            sumAll += number;

        }

        if (maximalNumber == sumAll - maximalNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {maximalNumber}");
        }

        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(maximalNumber - (sumAll - maximalNumber))}");
        }

    }
}