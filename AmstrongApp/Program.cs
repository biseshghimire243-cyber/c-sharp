using System;

class Program
{
    static void Main(string[] args)
    {
        int number, remainder, result = 0, originalNumber;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        originalNumber = number;

        while (number != 0)
        {
            remainder = number % 10;
            result = result + (remainder * remainder * remainder);
            number = number / 10;
        }

        if (result == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong Number.");
        }
    }
}