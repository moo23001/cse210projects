public class Common : Card
{
public Common (string cardName, string cardType, int attackPoints, int defensePoints) : base (cardName,cardType,attackPoints,defensePoints) {

}

    public override int GetAttackPoints(){
        return (int)(base.GetAttackPoints() * 1.2);
    }
    public override int GetDefensePoints(){
        return (int)(base.GetDefensePoints() * 1.8);
    }
}