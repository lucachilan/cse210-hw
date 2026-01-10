using System;
using System.IO.Enumeration;
using System.Net.Quic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// well, I added a Files class, to upload or read the different files, either prompts, or journals that you might like to open. 
// I also added a way to change journals, in case there's more than one person, it asks for the journal filename once at the beginning and uses it for the rest of tasks
// In the settings tab you can change the file you're editing
// The journal saves as an CSV file, you can access it on excel
// The files can be uploaded in the project folder and they auto synchronize with the bin version, so they can run with the program

class Program
{

    static void Main(string[] args)
    {
        bool saveStatus = true; //used for checking if changes are saved
        string option = "a";
        string menu = "\nPlease select one of the following:\n1. Write\n2. Display\n3. Load\n4. save\n5. Quit\n6. Settings\nWhat would you like to do? ";
        string settings = "1. Change Journal File\n2. Go Back";
        
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new Journal();

        string filename;
        Console.WriteLine("What is the filename for your journal? ");
        
        filename = Console.ReadLine();
        while (!File.Exists(filename))
        {
            Console.WriteLine("Cannot Find the file, try again: ");
            filename = Console.ReadLine();
        }    

        myJournal.LoadFromFile(filename);
        saveStatus = true;

        while(option != "5")
        {
            Console.Write(menu);
            option = Console.ReadLine();
            if (option == "1")
            {
                myJournal.AddEntry();
                saveStatus = false;
            }
            else if (option == "2")
            {
                myJournal.DisplayAll();
                Console.WriteLine("\n When you are done reading, press anything");
                Console.ReadKey();
            }
            else if (option == "3")
            {
                Console.WriteLine("Open the same one or a new one?\n1. The same one\n2. A new one");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    if (!saveStatus)
                    {
                        myJournal.SaveToFile(filename);
                    }
                    myJournal.LoadFromFile(filename);   
                }
                else if (answer == "2")
                {
                    Console.WriteLine("What is the filename for your journal? ");
                    filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename);
                }
            }
            else if (option == "4")
            {
                myJournal.SaveToFile(filename);
                saveStatus = true;
            }
            else if (option == "5")
            {
                if (saveStatus == true)
                {
                    Console.WriteLine("Bye!");
                }
                else if(saveStatus == false)
                {
                    Console.WriteLine("Do you want to save before leaving?\n1. Yes\n2. No");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        myJournal.SaveToFile(filename);
                    }
                    else if (answer == "2")
                    {
                        Console.WriteLine("Ok, bye!");
                    }
                }
            }
            else if (option == "6")
            {
                Console.WriteLine(settings);
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    myJournal.SaveToFile(filename);
                    Console.WriteLine("What is your journal filename? ");
                    filename = Console.ReadLine();
                    while (!File.Exists(filename))
                    {
                        Console.WriteLine("Cannot Find the file, try again: ");
                        filename = Console.ReadLine();
                    }   
                }
            }
        }
    }
}