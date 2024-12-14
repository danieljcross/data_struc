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
    }
}