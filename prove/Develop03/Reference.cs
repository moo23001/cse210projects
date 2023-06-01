public class Reference 
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    //public string GetReference(){
       // return _textReference;
   // }
    public Reference(string text) {
        string[] separators = {":", "-"};
        string[] splitReference = text.Split(separators, 3, StringSplitOptions.None);
        string[] splitBookAndChapter = splitReference[0].Split(" ");

        if (splitBookAndChapter.Count() > 2){
            string[] book = splitBookAndChapter.SkipLast(1).ToArray();
            _book = string.Join(" ", book);
            _chapter = int.Parse(splitBookAndChapter[splitBookAndChapter.Count()-1]);
        } else {
            _book = splitBookAndChapter[0];
            _chapter = int.Parse(splitBookAndChapter[1]);
        }
        if (splitReference.Count() == 3){
            _startverse = int.Parse(splitReference[1]);
            _endverse = int.Parse(splitReference[2]);
        } else {
             _startverse = int.Parse(splitReference[1]);
        }
      
        

   }

    public void DisplayReference(){
        if (_endverse == 0){
            Console.WriteLine(_book + " " + _chapter + ":" + _startverse);
        } else{
            Console.WriteLine(_book + " " + _chapter + ":" + _startverse + "-" + _endverse);
        }
    }
    
}

