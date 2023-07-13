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
    public Deck GetDeck(){
        return deck;
    }
    public void Attack(Player attackingPlayer, Card attackCard, Player opponent, Card defendCard){
        int damagePoints = attackCard.GetAttackPoints() - defendCard.GetDefensePoints();
        if (damagePoints > 0){
            opponent._healthPoints -= damagePoints;
        }
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine ($"{_playerName} attacks {opponent.GetPlayerName()} with {attackCard.GetCardName()} (ATK: {attackCard.GetAttackPoints()})");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine ($"{opponent.GetPlayerName()} defends against {attackingPlayer.GetPlayerName()} with {defendCard.GetCardName()} (DEF: {defendCard.GetDefensePoints()})");
        EffectiveMsg(opponent,damagePoints);
    }

    public void PlayCard(Card card){
        Console.WriteLine($"{_playerName} plays {card.GetCardName()} (ATK: {card.GetAttackPoints()}, DEF: {card.GetDefensePoints()})");
    }

    public void EffectiveMsg(Player opponent, int damagePoints){

        if (damagePoints > 0){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"- Attack is effective! {opponent.GetPlayerName()} lost {damagePoints} health points.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }else{
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"+ Defense is effective! {opponent.GetPlayerName()} lost no health points.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}