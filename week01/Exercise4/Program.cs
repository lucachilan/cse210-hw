using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();

        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            inputNumber = int.Parse(stringNumber);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum of your list is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average of your list is: {average}");

        int largest = -1000;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest in your list is: {largest}");
        
        int smallest = 1000;
        foreach (int number in numbers)
        {
            if (number < smallest && number >= 0)
            {
                smallest = number;
            }
        }
    
        // sorting the list
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"The smallest positive number in your list is: {smallest}");

        Console.WriteLine($"Your list is done {numbers}");
    }
}