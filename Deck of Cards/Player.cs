using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Player:Deck
    {
        public string name;
        public List<Card> hand = new List<Card>();
        public Player(string val) {
            name = val;
        }
        public Card Draw(){
            System.Console.WriteLine("DRAWING");
            if(hand.Count>0&&cards.Count==52){
                hand.Clear();
            }
            Card card = Deal();
            hand.Add(card);
            return card;
        }
        public Card Discard(int val){
            System.Console.WriteLine("DISCARDING");
            if(val>hand.Count-1||val<0){
                return null;
            }
            Card card = hand[val];
            hand.Remove(card);
            cards.Add(card);
            Shuffle();
            System.Console.WriteLine("Discarded "+card.stringVal+" "+card.suit);
            return card;
        }
    }
}