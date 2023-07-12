public class Epic : Card
{
public Epic (string cardName, string cardType, int attackPoints, int defensePoints) : base (cardName,cardType,attackPoints,defensePoints) {

}
    public override int GetAttackPoints(){
        return (_attackPoints * 3);
    }
        public override int GetDefensePoints(){
        return (_defensePoints * 1);
    }
}