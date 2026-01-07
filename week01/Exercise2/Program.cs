using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was the grade? ");
        string inputFromUser = Console.ReadLine();
        int grade = int.Parse(inputFromUser);
        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        int remainder = grade % 10;
        string sign;
        
        if (remainder >=7 )
        {
            sign = "+";
            if (letterGrade == "A")
            {
                sign = "";
            }
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (letterGrade == "F")
        {
            sign = "";
        }

        Console.WriteLine($"The grade is {letterGrade}{sign}");

    }
}