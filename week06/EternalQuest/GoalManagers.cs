using System.Threading.Channels;

public class GoalManager
{
    List<Goal> _goals; 
    int _score;

    string line = "\n--------------------------------\n";
    string menu = @"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit";
    string goalTypes = @"
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    { 
        Console.Clear();
        int option = 0;
        while (option != 6)
        {
            DisplayPlayerInfo();
            Console.Write($"\n{menu}\nSelect a choice from the menu: ");
            while(!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6)
            {
                Console.Write("Invalid - enter a valid menu option");
                Thread.Sleep(1000);
                
                Console.Clear();
                DisplayPlayerInfo();
                Console.Write($"\n{menu}\nSelect a choice from the menu: ");
            }
            if(option >0 && option <=6){
                switch (option)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                }
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        if(_goals.Count>0){
            for(int i = 0; i<_goals.Count(); i++)
            {
                Console.WriteLine($"   {i+1}. {_goals[i].GetName()}");
            }
        }
        else
        {
            Console.WriteLine("No goals created yet.");
        }
    }

    public void ListGoalDetails()
    {
        if(_goals.Count>0){

            for (int i = 0; i < _goals.Count(); i++)
            {   
                Console.WriteLine($"   {i+1}. {_goals[i].GetDetailsString()}");
            }
        }
        else
        {
            Console.WriteLine("Not goals created yet.");
        }
        Console.WriteLine("Press <enter> to continue.");
        while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
        Console.Clear();
    }

    public void CreateGoal()
    {
        Goal newGoal = null;
        
        Console.WriteLine($"\nThe types of goals are:{goalTypes}");

        Console.Write("Which type of goal would you like to create? ");

        int selected;
        while(!int.TryParse(Console.ReadLine(), out selected) || selected < 1 || selected > 3)
        {
            Console.Write("Invalid - enter a valid goal option: ");
        }

        Console.WriteLine(line);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points;

        while(!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid - enter a number: ");
        }

        switch (selected)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2: 
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target;
                while(!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.Write("Invalid - enter a number: ");
                }

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus;
                while(!int.TryParse(Console.ReadLine(), out bonus))
                {
                    Console.Write("Invalid - enter a number: ");
                }

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }
        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        if(_goals.Count()>0)
        {
            Console.WriteLine("\nThe goals are:");
            ListGoalNames();
            int goalSelected;
            bool valid = false;

            do
            {
                Console.Write("Which goal did you accomplish? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out goalSelected))
                {
                    goalSelected -=1;
                    if (goalSelected >=0 && goalSelected < _goals.Count)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Number out of range. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            } while (!valid);
            
            Goal selectedGoal = _goals[goalSelected];

            int earned = selectedGoal.RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!\n");

        }
        else
        {
            Console.WriteLine("Try adding a new Goal to start!");
        }

        Console.WriteLine("Press <enter> to continue.");
        while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
        Console.Clear();

    }

    public void SaveGoals()
    {
        Console.WriteLine(line);
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal g in _goals){
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        List<Goal> loadingGoals = new List<Goal>();

        Console.WriteLine(line);
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            Goal newGoal = null;
            switch (type)
            {
                case "SimpleGoal":

                    SimpleGoal sg = new SimpleGoal(name, description, points);
                    bool state = bool.Parse(parts[4]);
                    sg.SetIsComplete(state);
                    newGoal = sg;
                    break;
                case "EternalGoal":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "ChecklistGoal":
                    int amount = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                    cg.SetAmountCompleted(amount);
                    newGoal = cg;
                    break;
            }
            loadingGoals.Add(newGoal);
        }
        _goals = loadingGoals;
    }
}