public class Checklist : Goals
{
    private int _bonus;
    private int _attempts;
    private int _completed;
    public Checklist(int goalType, string goalName, string goalDescription, int points, bool isCompleted, int bonus, int attempts, int completed = 0) : base(goalType, goalName, goalDescription, points, isCompleted)
    {
        _bonus = bonus;
        _attempts = attempts;
        _completed = completed;
    }
    public Checklist(){

    }
    public override int GetBonus(){
        return _bonus;
    }
    public override int GetAttempts(){
        return _attempts;
    }
    public override int GetCompleted(){
        return _completed;
    }

    public override int RecordEvent()
    {
        // increment attempts
        _completed += 1;
        // check if target hit
        if (_attempts == _completed)
        {
            // if true return points plus bomus and set complete to true
            _points = _points + _bonus;
            _isCompleted = true;
            Console.WriteLine("\nGoal succesfully completed");
            Thread.Sleep(2000);
        }
        // else only award normal points. 

        return _points;
    }
    public override Goals CreateGoal(int goalOption)
    {
        Console.Write("What is the name of your goal");
        string goalName = Console.ReadLine();
        Console.Write("Please type a short description for your goal: ");
        string goalDescription = Console.ReadLine();
        int goalPoints = ValidateIntOption("Points awarded to this goal", 1);
        int goalAttempts = ValidateIntOption("Attempts to complete goal", 1);
        int goalBonus = ValidateIntOption("Bonus award points", 1);
        Checklist goal = new Checklist(goalOption, goalName, goalDescription, goalPoints, false, goalBonus, goalAttempts);
        Console.Write("Goal has been created");
        Thread.Sleep(3000);
        return goal;
    }
        public override string CompletedAttempts()
    {
        return $" -- Completed Attempts: {_completed} / {_attempts}";
    }

}