public class Listing : Activity
{
    private List<string> _listPrompts = new List<string>();
    private List<string> _listItems = new List<string>();

    public Listing (string activityName, string description) : base(activityName, description){

    }

    public void SetListingPrompts(){
        _listPrompts.Add("Who are people that you appreciate?");
        _listPrompts.Add("What are personal strengths of yours?");
        _listPrompts.Add("Who are people that you have helped this week?");
        _listPrompts.Add("When have you felt the Holy Ghost this month?");
        _listPrompts.Add("Who are some of your personal heroes?");
    }

    public string GetListingPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(0,_listPrompts.Count());
        return _listPrompts[index];
    }

    public void SetListedItems(int time){
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {GetListingPrompt()} ---\n");
        Console.Write("You may begin in: ");
        CountDown();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        List<string> listedItems = new List<string>();
        while (DateTime.Now < endTime){
            Console.Write("> ");
            string item = Console.ReadLine();
            _listItems.Add(item);
        }
    }

    public void DisplayNumberOfItems(){
        Console.WriteLine($"\nYou listed {_listItems.Count()} items! ");
        Console.WriteLine("\nWell done!!");
    }
}