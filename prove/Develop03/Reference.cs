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
        string[] splitReference = text.Split(separators, 3, StringSplitOptions.None); // 2 Nefi 2/:15/-16
        string[] splitBookAndChapter = splitReference[0].Split(" "); // 2 / Nefi / 2

        if (splitBookAndChapter.Count() > 2){
            string[] book = splitBookAndChapter.SkipLast(1).ToArray();
            _book = string.Join(" ", book); //2 Nefi
            _chapter = int.Parse(splitBookAndChapter[splitBookAndChapter.Count()-1]); //2
        } else {
            _book = splitBookAndChapter[0]; //Juan
            _chapter = int.Parse(splitBookAndChapter[1]); //14
        }
        if (splitReference.Count() == 3){
            _startverse = int.Parse(splitReference[1]); //15
            _endverse = int.Parse(splitReference[2]);//16
        } else {
             _startverse = int.Parse(splitReference[1]); //15
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

