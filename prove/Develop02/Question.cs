public class Question
{
    public string _qText;
    

    public string Prompt (){
        List<string> prompts = new List<string>();
        prompts.Add("What was your favorite moment during the day?");
        prompts.Add("Who did you help today to be better?");
        prompts.Add("What was something new you learned today?");
        prompts.Add("What was a funny moment that made you laugh?");
        prompts.Add("What spiritual experience did you have today?");
        prompts.Add("How did you invite the spirit in your life today?");
        
        var random = new Random();
        var index = random.Next(0, prompts.Count);
        return prompts[index];
    }


}