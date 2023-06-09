public class Breathing : Activity 
{
    private string _breatheIN;
    private string _breatheOut;
    public Breathing (string activityName, string description) : base(activityName, description){
        
        _breatheIN = "Breathe In...";
        _breatheOut = "Breathe Out...";
    }

    public void BreatheInOut(int time){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        while (DateTime.Now < endTime){
        Console.Write($"\n{_breatheIN}");
        CountDown();
        Console.WriteLine();
        Console.Write($"{_breatheOut}");
        CountDown();
        }

    }
}