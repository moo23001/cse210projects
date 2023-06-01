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
        string[] separators = {" ", ":", "-"};
        string[] splitReference = text.Split(separators, 4, StringSplitOptions.None);
        if (splitReference.Count() == 4){
            _book = splitReference[0];
            _chapter =  int.Parse(splitReference[1]);
            _startverse = int.Parse(splitReference[2]);
            _endverse = int.Parse(splitReference[3]);
        } else {
             _book = splitReference[0];
             _chapter =  int.Parse(splitReference[1]);
             _startverse = int.Parse(splitReference[2]);
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

