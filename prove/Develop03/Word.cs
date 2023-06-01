public class Word 
{
    private bool _hidden;
    private string _wordText;
    

    public Word (string text){
        _wordText = text;
        _hidden = false;
    }


    public string GetWordText(){
        return _wordText;
    }

    public void SetWordUnderscore(){
        _wordText = new string ('_',_wordText.Length);
    }

    public bool GetHidden(){
        return _hidden;
    }

    public void SetHidden(){
        _hidden = true;
    }

    
 
}