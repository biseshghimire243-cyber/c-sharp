using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        int sum = 0;

        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            sum = sum + numbers[i];
        }

        Console.WriteLine("Sum of the array elements = " + sum);
    }
}