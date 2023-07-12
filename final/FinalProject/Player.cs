public class Player
{
    private string _playerName;
    private int _healthPoints;
    private Deck deck;

    public Player (string name){
        _playerName = name;
        _healthPoints = 100;
        deck = new Deck();
    }
    public string GetPlayerName(){
        return _playerName;
    }
    public int GetHealthPoints(){
        return _healthPoints;
    }

    public void PlayCard(Card card){
        Console.WriteLine($"{_playerName} plays{card.GetCardName()} (ATK: {card.GetAttackPoints()}, DEF: {card.GetDefensePoints()})");
    }
}