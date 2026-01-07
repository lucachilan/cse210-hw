using System;

class Program
{
    static void Main(string[] args)
    {
        Program.DisplayWelcome();
        string name = Program.PromptUserName();
        int number = Program.PromptUserNumber();
        int square = Program.SquareNumber(number);
        Program.DisplayResult(name, square);

    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name=Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput=Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number ;
        return square;
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}