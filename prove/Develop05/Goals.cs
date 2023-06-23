public class Goals
{
    private string _name;
    private string _description;
    private bool _isCompleted;
    private int _points;
    private int _goaltype;
    List<Goals> _goalsList = new List<Goals>();

    public Goals (int goalType, string name, string description,  int points = 0, bool isCompleted = false){
        _goaltype = goalType;
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }
    public Goals(){

    }
    
    public virtual void SetPoints(int points){
        _points = points;
    }
    public virtual int GetPoints(){
        return _points;
    }
    public virtual void RecordEvent(){

    }
    public virtual void CreateGoal(){
        int goalOption = validateIntOption("Type of goal", 1, 3);
        Console.WriteLine("What is the name of your goal");
        string goalName = Console.ReadLine();
        Console.WriteLine("Please type a short description for your goal: ");
        string goalDescription = Console.ReadLine();
        int goalPoints = validateIntOption("Points awarded to this goal",1);
        Goals goal = new Goals(goalOption,goalName,goalDescription,goalPoints);
        _goalsList.Add(goal);
        Console.Write("Goal has been created");
        Thread.Sleep(3000);
     }
    public virtual void  DisplayGoals(){
        string goalCheck = "";
        foreach(Goals goal in _goalsList){
            int index = _goalsList.IndexOf(goal);
            if (goal._isCompleted){
                goalCheck = "[X]";
           } else{
                goalCheck = "[ ]";
           }
            Console.WriteLine($"{index+1}. {goalCheck} {goal._name} ({goal._description})");
        }

    }
    public int validateIntOption(string message, int lower = 0, int upper = 9999999){
        int option = 0;
        int intOut = 0;
        bool success = false;
        do{
            Console.Write($"{message}: ");
            var goalTypeOption = Console.ReadLine();
            success = int.TryParse(goalTypeOption, out intOut);
            if (success){
                if (intOut > lower-1 && intOut < upper+1){
                    option = intOut;
                    break;
                }else{
                    Console.Write($"Time cannot less than {lower} or greater than {upper}. Please enter a number between 1 and 6. Press enter to continue...");
                    Console.ReadLine();
                    continue;
                }
            }else{
                Console.Write("This is not an integer number. Please enter a positive interger number. Press enter to continue...");
                Console.ReadLine();
            }
        }while (success == false);
        return option;
    }

}