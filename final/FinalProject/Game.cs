public class Game 
{
    private Player _player1;
    private Player _player2;

    public Game(string player1Name, string player2Name){
        _player1 = new Player(player1Name);
        _player2 = new Player(player2Name);

        _player1.GetDeck().AddCard(new Common("Arcane Warrior", "Warrior",15,20));
        _player1.GetDeck().AddCard(new Common("Silent Blade", "Bounty Hunter",20,10));
        _player1.GetDeck().AddCard(new Rare("Guardian", "Mage",20,20));
        _player1.GetDeck().AddCard(new Rare("Soul Eater", "Demon",15,20));
        _player1.GetDeck().AddCard(new Epic("Dragon Fang", "Demon",25,20));

        _player2.GetDeck().AddCard(new Common("Aztaroth", "Mage",20,15));
        _player2.GetDeck().AddCard(new Common("Storm Breaker", "Warrior",15,20));
        _player2.GetDeck().AddCard(new Rare("Nightmare", "Demon",20,20));
        _player2.GetDeck().AddCard(new Rare("Frostbite", "Monster",25,10));
        _player2.GetDeck().AddCard(new Epic("Mystic Sky", "Bounty Hunter",25,20));


    }
    public void StartGame(){
        Console.Clear();
        string welcome = "Welcome to the Card Battle Game!\n";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (welcome.Length / 2)) + "}", welcome));
        string versus = $"{_player1.GetPlayerName()} vs. {_player2.GetPlayerName()}\n";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (versus.Length / 2)) + "}", versus));
        string message = "Let the battle begin! Press Enter to start...\n";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((message.Length / 2) + 1)) + "}", message));
        

    }
    public void PlayTurn(){
        if (_player1.GetHealthPoints() > 0){
            Card player1AttackCard = _player1.GetDeck().DrawCard();
            Card player2DefendCard = _player2.GetDeck().DrawCard();
            _player1.PlayCard(player1AttackCard);
            _player1.Attack(_player1, player1AttackCard, _player2, player2DefendCard);

            Console.WriteLine($"{_player2.GetPlayerName()}'s remaining health: {_player2.GetHealthPoints()}\n");
        }
        if (_player2.GetHealthPoints() > 0){
            Card player2AttackCard = _player2.GetDeck().DrawCard();
            Card player1DefendCard = _player1.GetDeck().DrawCard();
            _player2.PlayCard(player2AttackCard);
            _player2.Attack(_player2, player2AttackCard, _player1, player1DefendCard);

            Console.WriteLine($"{_player1.GetPlayerName()}'s remaining health: {_player1.GetHealthPoints()}\n");
        }
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