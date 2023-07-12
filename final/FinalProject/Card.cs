public class Card 
{
    protected string _cardName;
    private string _cardType;
    protected int _attackPoints;
    private int _defensePoints;


    public Card (string cardName, string cardType, int attackPoints, int defensePoints){
        _cardName = cardName;
        _cardType = cardType;
        _attackPoints = attackPoints;
        _defensePoints = defensePoints;
    }

    public string GetCardName(){
        return _cardName;
    }

    public virtual int GetAttackPoints(){
        return 0;
    }
    public virtual int GetDefensePoints(){
        return 0;
    }
}