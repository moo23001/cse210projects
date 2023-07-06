using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOption = -1;
        int totalPoints = 0;
        List<Goals> _goalsList = new List<Goals>();
        do
        {
            Console.Clear();
            Console.WriteLine($"Total points: {totalPoints}\n");
            MainMenu();
            Console.Write("Select a choice from the menu: ");
            var optionAsString = Console.ReadLine();
            bool success = int.TryParse(optionAsString, out menuOption);
            if (success)
            {
                switch (menuOption)
                {
                    case 1:
                        Console.Clear();
                        GoalType();
                        int goalOption = ValidateIntOption("Type of goal", 1, 3);
                        switch (goalOption)
                        {
                            case 1:
                                Simple simpleGoal = new Simple();
                                _goalsList.Add(simpleGoal.CreateGoal(goalOption));
                                break;
                            case 2:
                                Eternal eternalGoal = new Eternal();
                                _goalsList.Add(eternalGoal.CreateGoal(goalOption));
                                break;
                            case 3:
                                Checklist checklistGoal = new Checklist();
                                _goalsList.Add(checklistGoal.CreateGoal(goalOption));
                                break;
                        }

                        break;
                    case 2:
                        DisplayGoals();
                        Console.Write("Please hit enter to continue... ");
                        Console.Read();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter the file name: ");
                        string fileName = Console.ReadLine();
                        Save(fileName,_goalsList);
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Enter the file name: ");
                        string loadFile = Console.ReadLine();
                        _goalsList = Load(loadFile);
                        break;
                    case 5:
                        Console.Clear();
                        DisplayGoals();
                        int index = ValidateIntOption("\nWhich goal do you want to complete? ", 1, _goalsList.Count());
                        if (_goalsList[index-1].GetIsCompleted() == false)
                        {
                            totalPoints += _goalsList[index-1].RecordEvent();
                        }
                        else
                        {
                            Console.WriteLine("This goal has already been completed. Choose another goal");
                        }

                        break;
                    case 6:
                        Console.WriteLine("\n\nThanks for using the Eternal Quest program\n\n");
                        break;
                    default:
                        break;
                }
                continue;
            }else{
                Console.Write("This is not an option number. Enter an option from 1 - 4. Press enter to continue...");
                Console.ReadLine();
                continue;
            }


        } while (menuOption != 6);

        static void MainMenu()
        {
            Console.WriteLine("Menu options");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
        }
        static void GoalType()
        {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
        }

    void DisplayGoals()
    {
        Console.Clear();
        string goalCheck = "";
        foreach (Goals goal in _goalsList)
        {
            int index1 = _goalsList.IndexOf(goal);
            if (goal.GetIsCompleted())
            {
                goalCheck = "[X]";
            }
            else
            {
                goalCheck = "[ ]";
            }
            Console.WriteLine($"{index1 + 1}. {goalCheck} {goal.GetName()} ({goal.GetDescription()} {goal.CompletedAttempts()})");
        }

    }
    void Save(string filename, List<Goals> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);
          foreach (Goals g in goals)
            {
                outputFile.WriteLine($"{g.GetGoalType()}±{g.GetName()}±{g.GetDescription()}±{g.GetPoints()}±{g.GetIsCompleted()}±{g.GetBonus()}±{g.GetAttempts()}±{g.GetCompleted()}");        
            }
        }
    }
    List<Goals> Load(string filename)
    {
        List<Goals> goals = new List<Goals>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        totalPoints = int.Parse(lines[0]);
        string[] remainingLines = lines.Skip(1).ToArray();
        foreach (string line in remainingLines)
        {
            string[] parts = line.Split("±");
            if (int.Parse(parts[0]) == 1){
                Simple simpleGoal = new Simple(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goals.Add(simpleGoal);

            }else if(int.Parse(parts[0]) == 2){
                Eternal eternalGoal = new Eternal(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goals.Add(eternalGoal);

            }else{
                Checklist checklistGoal = new Checklist(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                goals.Add(checklistGoal);
            }

        }

        return goals;
    }


    }
    







public static int ValidateIntOption(string message, int lower = 0, int upper = 9999999)
{
    int option = 0;
    int intOut = 0;
    bool success = false;
    do
    {
        Console.Write($"{message}: ");
        var goalTypeOption = Console.ReadLine();
        success = int.TryParse(goalTypeOption, out intOut);
        if (success)
        {
            if (intOut > lower - 1 && intOut < upper + 1)
            {
                option = intOut;
                break;
            }
            else
            {
                Console.Write($"Time cannot less than {lower} or greater than {upper}. Please enter a number between 1 and 6. Press enter to continue...");
                Console.ReadLine();
                continue;
            }
        }
        else
        {
            Console.Write("This is not an integer number. Please enter a positive interger number. Press enter to continue...");
            Console.ReadLine();
        }
    } while (success == false);
    return option;
}

}