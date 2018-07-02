using System;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deck_of_Cards newDeck = new Deck_of_Cards();
            // for(int i=0;i<newDeck.deck.Count;i++){
            //     System.Console.WriteLine(newDeck.deck[i]);    
            // }
            // newDeck.Shuffle(3);  
            // for(int i=0;i<newDeck.deck.Count;i++){
            //     System.Console.WriteLine(newDeck.deck[i]);    
            // }
            // newDeck.Deal(7);

            Player newPlayer = new Player("Jim");
            newPlayer.Shuffle();
            newPlayer.Draw();
            newPlayer.Draw();
            newPlayer.Draw();
            newPlayer.Draw();
            newPlayer.Draw();
            for(int i=0;i<newPlayer.hand.Count;i++){
                System.Console.WriteLine(newPlayer.hand[i].stringVal+" "+newPlayer.hand[i].suit);    
            }
            newPlayer.Discard(3);
            newPlayer.Reset();
            newPlayer.Draw();
            System.Console.WriteLine(newPlayer.cards.Count);
            System.Console.WriteLine(newPlayer.hand.Count);
            
        }
    }
}
