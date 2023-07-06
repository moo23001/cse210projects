public class Simple : Goals
{
    public Simple(int goalType, string goalName, string goalDescription, int points, bool isCompleted) : base(goalType, goalName, goalDescription, points, isCompleted)
    {

    }
    public Simple(){

    }
    public override Goals CreateGoal(int goalOption)
    {
        Console.WriteLine("What is the name of your goal");
        string goalName = Console.ReadLine();
        Console.WriteLine("Please type a short description for your goal: ");
        string goalDescription = Console.ReadLine();
        int goalPoints = ValidateIntOption("Points awarded to this goal", 1);
        Simple goal = new Simple(goalOption, goalName, goalDescription, goalPoints, false);
        Console.Write("\nGoal has been created");
        Thread.Sleep(3000);
        return goal;
    }
    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine("\nGoal succesfully completed");
        Thread.Sleep(2000);
        return _points;
    }

    public override string CompletedAttempts()
    {
        return "";
    }
}