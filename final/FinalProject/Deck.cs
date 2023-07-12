public class Deck
{
    private List<Card> cards;
    private Random rnd;
    
    public Deck(){
        cards = new List<Card>();
        rnd = new Random();
    }

    public void AddCard(Card card){
        cards.Add(card);
    }

    public Card DrawCard(){
        int index = rnd.Next(cards.Count);
        Card drawnCard = cards[index];
        //cards.RemoveAt(index);
        return drawnCard;
    }

    
}