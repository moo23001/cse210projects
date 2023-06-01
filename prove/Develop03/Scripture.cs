public class Scripture 
{
    List<Word> _words = new List<Word>();

    public List<Word> GetScripture(){
        return _words;
    }


    public Scripture(string text)
    {
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

    public void DisplayScripture(){
        
        for(int i = 0; i <= _words.Count()-1; i++) {
            Console.Write(_words[i].GetWordText() + " ");
        }
    }

    public void HideWord(List<Word> scriptureWords)
    {
        int counter = 0;
        while(counter < 3){
            if (AllWordsHidden(scriptureWords) == false){
                break;} 
            else {
                Random rnd = new Random();
                int index = rnd.Next(0,scriptureWords.Count());
                if (scriptureWords[index].GetHidden() == false){
                scriptureWords[index].SetHidden();
                scriptureWords[index].SetWordUnderscore();
                counter++;
                }
            }
        }

    }

    // AllWordsHidden return a bool (true) if all words are hidden
    public bool AllWordsHidden(List<Word> scriptureWords){
        bool flag = false;
        foreach(Word word in scriptureWords){
            if (word.GetHidden() == false){
                flag = true;
                break;
            } 
        }
        return flag;
    }
    
}