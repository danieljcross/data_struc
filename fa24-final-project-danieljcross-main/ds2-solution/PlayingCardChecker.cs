using System;
using System.Collections.Generic;

class PlayingCardChecker{
    // List of cards that should belong
    private static List<string> FullDeck = new List<string>{
        "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
    };

    // Remove duplicates
    public static HashSet<string> CreateCardSet(List<string> cards){
        return new HashSet<string>(cards);
    }

    // Look for missing cards
    public static List<string> GetMissingCards(HashSet<string> cardsSet){

        // Adds missing cards in a list and returns it
        List<string> missingCards = new List<string>();
        foreach (string card in FullDeck){
            if (!cardsSet.Contains(card)){
                missingCards.Add(card);
            }
        }
        return missingCards;
    }
}