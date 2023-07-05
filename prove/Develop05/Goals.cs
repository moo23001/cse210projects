public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected bool _isCompleted;
    protected int _points;
    protected int _goaltype;


    public Goals(int goalType, string name, string description, int points = 0, bool isCompleted = false)
    {
        _goaltype = goalType;
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }
    public Goals()
    {

    }


    public virtual void SetIsCompleted()
    {
        _isCompleted = true;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual int GetGoalType()
    {
        return _goaltype;
    }
    public virtual string GetName()
    {
        return _name;
    }
    public virtual string GetDescription()
    {
        return _description;
    }
    public virtual bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public abstract string CompletedAttempts();

    public abstract int RecordEvent();
    public abstract Goals CreateGoal(int goalOption);
    public virtual int GetBonus(){
        return 0;
    }
    public virtual int GetAttempts(){
        return 0;
    }
    public virtual int GetCompleted(){
        return 0;
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