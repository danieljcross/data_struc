using System;
using System.Collections.Generic;

class PlayingCardTests
{

    public static void RunTests()
    {
        // Variables you will need
        List<string> cardsInHand = new List<string>{"A", "2", "3", "7", "8", "9", "10", "J", "Q", "K", "K"};
        HashSet<string> cardsSet = PlayingCardChecker.CreateCardSet(cardsInHand);
        List<string> missingCards = PlayingCardChecker.GetMissingCards(cardsSet);

        // Look for missing cards and displays them
        if (missingCards.Count == 0){
            Console.WriteLine("All cards are present.");
        }
        else{
            Console.WriteLine("Missing cards:");
            int cardCount = missingCards.Count;
            foreach (string missingCard in missingCards){
                Console.Write(missingCard);
                cardCount -= 1;
                if (cardCount > 1){
                    Console.Write(", ");
                }
                else if (cardCount == 1){
                    Console.Write(", and ");
                }
            }
        }
    }
}
  