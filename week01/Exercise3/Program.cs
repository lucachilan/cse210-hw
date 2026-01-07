using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        Console.WriteLine ("Welcome to Guess my Number");

        while (response != "no")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            bool guessed = false;
            do
            {
                Console.Write("What's your guess? ");
                string guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);   

                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    guessed = true;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guessed = false;
                }
                else
                {
                    Console.WriteLine("Higher");
                    guessed = false;
                }
            } while (guessed == false);
            
            Console.WriteLine("Do you want to continue? ");
            response =  Console.ReadLine();
        }
        Console.WriteLine("\nHave a nice day then!");
    }
}