using System;
// added a way to not show the same prompts or questions within the same session until they are all done. 
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity();
        ReflectingActivity refl = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        string choice = DisplayMenu();
        while (choice != "4")
        {
            switch (choice)
            {
                case "1":
                    breath.Run();
                    break;
                case "2":
                    refl.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":

                break;
            }    
            choice = DisplayMenu();
        }
    }


    static string DisplayMenu()
    {
        string menu = 
@"Menu Options:
    1. Start Breathing Activity
    2. Start Reflecting Activity
    3. Start Listing Activity
    4. Quit
Select a choice from the menu: ";
        Console.Clear();
        Console.Write(menu);
        return Console.ReadLine();
    }
}