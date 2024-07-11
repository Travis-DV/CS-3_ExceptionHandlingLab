using System;
using Validator;

class Program
{
    public static void Main()
    {
        int[] numbersToAdv = Validator.Validator.GetIntArray("Enter numbers separated by spaces to calculate the average:");
        Console.WriteLine("Calculating the average... ");
        Console.WriteLine(CalculateAverage(numbersToAdv).ToString());
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Numbers equals null or length is 0");
            return 0.0;
        }

        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }
}