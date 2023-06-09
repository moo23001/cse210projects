public class Activity 
{
    private string _activityName;
    private int _time;
    private string _description;

    public Activity (){

    }
    public Activity (string activityName, string description){
        _activityName = activityName;
        _description = description;
    }

    public string GetDescription(){
        return _description;
    }

    public void Welcome() {
        Console.WriteLine($"Welcome to the {_activityName} activity");
    }
    public int GetTime(){
        return _time;
    }

    public void StartMessage(){
        Console.WriteLine(_description);
    }

    public void EndMessage(){
        Console.WriteLine($"\nYou have completed {GetTime()} seconds of the {_activityName} activity");
    }

    public void Pause(int time){
        Thread.Sleep(time * 1000);
    }
    public int SessionTime(){
        int time = 0;
        int intOut = 0;
        bool success = false;
        do {
            Console.Write("How long, in seconds, would you like for your session? ");
            var secondsAsString = Console.ReadLine();
            success = int.TryParse(secondsAsString, out intOut);
            if (success){
                if (intOut > 0){
                    time = intOut;
                    break;
                }else{
                    Console.Write("Time cannot be negative, please enter a positive whole number. Press enter to continue...");
                    Console.ReadLine();
                    continue;
                }
            }else{
                Console.Write("This is not an integer number. Please enter a positive interger number. Press enter to continue...");
                Console.ReadLine();
            }
        } while (success == false);
        _time = time;
        return time;
    }

    public void CountDown(){
        for (int i = 5;i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Animation(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);
        while(DateTime.Now < endTime){
            Console.Write("<");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("^");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write(">");
            Thread.Sleep(100);
            Console.Write("\b \b");

        }
    }
}