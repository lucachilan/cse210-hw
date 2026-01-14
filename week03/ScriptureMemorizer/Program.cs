using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int numberToHide = 3;
    static string answer = " ";
    static void Main(string[] args)
    {
        Reference reference = new Reference("John",3,16,17);
        Scripture scripture = new Scripture(reference,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue, enter 'quit' to exit");
            answer = Console.ReadLine();
            if (answer != "quit")
            {
                scripture.HideRandomWords(numberToHide);
            }
            
        }
        


    }
}