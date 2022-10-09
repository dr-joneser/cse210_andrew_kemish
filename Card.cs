public class Card1 {
    static Random rnd = new Random();
    public int Generate(int currentCard) {
        int cardNum  = rnd.Next(1, 14);
        while (cardNum == currentCard){
            Generate(currentCard);
        }

        return cardNum;
    }

    public static void DisplayCurrentCard(int currentCard) {
        Console.WriteLine($"The card is: {currentCard}");
    }


    public static void ReplaceOldWithNew(int currentCard, int newCard) {
        currentCard = newCard;
        Console.WriteLine($"The Card is: {newCard}");
    }


}