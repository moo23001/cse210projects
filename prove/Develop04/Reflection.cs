public class Reflection : Activity 
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection (string activityName, string description) : base(activityName, description){

    }
    public void SetPrompts(){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public void SetQuestions(){
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    

    public string GetPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(0,_prompts.Count());
        return _prompts[index];
    }

    public List<string> GetQuestions(){
        return _questions;
    }

    public void DisplayQuestions(int time){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        List<int> oldQuestions = new List<int>();
        while (DateTime.Now < endTime){
            Random rnd = new Random();
            int index = rnd.Next(0,GetQuestions().Count());
            if (oldQuestions.Contains(index)){
                continue;
            }else{
                oldQuestions.Add(index);
                Console.WriteLine(_questions[index]);
                Pause(5);
            }
        }
    }
}