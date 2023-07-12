public class Game 
{
    private Player _player1;
    private Player _player2;

    public Game(string player1Name, string player2Name){
        _player1 = new Player(player1Name);
        _player2 = new Player(player2Name);
    }
    public void StartGame(){
        string welcome = "Welcome to the Card Battle Game!\n";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (welcome.Length / 2)) + "}", welcome));
        string versus = $"{_player1.GetPlayerName()} vs. {_player2.GetPlayerName()}\n";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (versus.Length / 2)) + "}", versus));
        string message = "Let the battle begin!\n!";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((message.Length / 2) + 1)) + "}", message));

    }
    public void PlayTurn(){
        
    }

    public Player GetWinner(){
        if (_player1.GetHealthPoints() <= 0){
            return _player2;
        }else if (_player2.GetHealthPoints() <= 0){
            return _player1;
        }else{
            return null;
        }

    }
}