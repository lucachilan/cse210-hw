using System;

class Program
{   
    static void Main(string[] args)
    {
        List<Video> playlist = new List<Video>();
        string video1 = "How to train your dragon; Kalypso; 1930; Marcos:haha good video bro;Lupita43:no words for you;Camila:Pelotero";
        string video2 = "How to fry an egg without burning the house down; Chef Slipper; 1505; GordonRamsay:IT IS RAW!!; GrandmaJoe:needs more salt dear; FirefighterPhil:Please never cook again";
        string video3 = "UFO sighting at the local grocery store; ConspiracyTim; 4200; FoxMulder:I want to believe; AlienX:They found me; CashierDan:He just wanted a Slurpee";
        // video prompts were made by AI, I just could think about the "How to train your dragon"


        playlist.Add(new Video(video1));
        playlist.Add(new Video(video2));
        playlist.Add(new Video(video3));

        foreach (Video v in playlist)
        {
            v.DisplayVideoInfo();
            Console.WriteLine("---------------------");
        }

    }
}