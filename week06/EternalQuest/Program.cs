// added many ways to check that the inputs were actually what they were asking, being in range and indexes when needed. 
// also added little pauses to check what's going on, it won't continue until you press enter
// name for the file is goals.txt

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager m = new GoalManager();
        m.Start();
    }
}