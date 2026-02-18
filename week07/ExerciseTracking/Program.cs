using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("18 Feb 2026", 30, 3.0));
        activities.Add(new Cycling("18 feb 2026", 45, 40));
        activities.Add(new Swimming("18 feb 2026", 30,40));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}