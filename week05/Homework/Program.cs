using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssigment math = new MathAssigment("Luca", "Calculus", "2", "20-39,50-62");
        Console.WriteLine(math.GetHomeworkList());
        WritingAssigment writ = new WritingAssigment("Lola", "Poetry", "The daisy flower");
        Console.WriteLine(writ.GetWritingInformation());
    }
}