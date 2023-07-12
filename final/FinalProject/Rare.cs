public class Rare : Card
{
public Rare (string cardName, string cardType, int attackPoints, int defensePoints) : base (cardName,cardType,attackPoints,defensePoints) {

}
    public override int GetAttackPoints(){
        return (_attackPoints * 2);
    }
        public override int GetDefensePoints(){
        return (_defensePoints * 2);
    }
}