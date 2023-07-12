public class Common : Card
{
public Common (string cardName, string cardType, int attackPoints, int defensePoints) : base (cardName,cardType,attackPoints,defensePoints) {

}

    public override int GetAttackPoints(){
        return (_attackPoints * 1);
    }
    public override int GetDefensePoints(){
        return (_defensePoints * 2);
    }
}