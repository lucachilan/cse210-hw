using System;
using System.Data.Common;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

// Added a file from where it loads scriptures, you can continue to memorize other ones when you're done with the first one,
// it's random which scripture are you going to memorize next 
class Program
{
    static int numberToHide = 10;
    static string answer = " ";
    static Scripture _selectedScripture;

    static void Main(string[] args)
    {
        while(answer!="quit"){
            _selectedScripture = Scripture.GetRandomScripture();

            while(!_selectedScripture.IsCompletelyHidden()){
                Console.Clear();
                Console.WriteLine(_selectedScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to continue, enter 'quit' to exit");
                answer = Console.ReadLine();
                if (answer != "quit")
                {
                    _selectedScripture.HideRandomWords(numberToHide);
                }
                if (_selectedScripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(_selectedScripture.GetDisplayText());
                    Console.WriteLine($"You have ended the memorizing process for {_selectedScripture.GetReference().GetDisplayText()}");
                    Console.WriteLine("\n Press Enter to try a new scripture, enter 'quit' to exit the Scripture Memorizer");                    
                    answer = Console.ReadLine();
                }
            }
        }
    }
}