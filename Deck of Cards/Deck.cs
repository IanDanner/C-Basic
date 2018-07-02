using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public string[] suits = {"Heart","Diamond","Spade","Club"};
        public string[] ranks= {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};
        public int[] values={1,2,3,4,5,6,7,8,9,10,11,12,13};
        public Deck() {
            for(int i=0;i<ranks.Length;i++){
                for(int ii=0;ii<suits.Length;ii++){
                    Card newCard = new Card(ranks[i],suits[ii],values[i]);
                    System.Console.WriteLine(newCard.stringVal+" "+newCard.suit);
                    cards.Add(newCard);
                }
            }
        }
        public Card Deal(){
            System.Console.WriteLine("DEALING");
            int top = cards.Count-1;
            Card deal = cards[top];
            cards.RemoveAt(top);
            System.Console.WriteLine("Dealt Card: "+deal.stringVal+" "+deal.suit);
            System.Console.WriteLine("Cards left in Deck: "+cards.Count);
            return deal;
        }
        public List<Card> Reset(){
            System.Console.WriteLine("RESETING");
            cards.Clear();
            for(int i=0;i<ranks.Length;i++){
                for(int ii=0;ii<suits.Length;ii++){
                    Card newCard = new Card(ranks[i],suits[ii],values[i]);
                    System.Console.WriteLine(newCard.stringVal+" "+newCard.suit);
                    cards.Add(newCard);
                }
            }
            System.Console.WriteLine("Last Card: "+cards[cards.Count-1].stringVal+" "+cards[cards.Count-1].suit);
            System.Console.WriteLine("Cards in Deck: "+cards.Count);
            return cards;
        }
        public List<Card> Shuffle(){
            System.Console.WriteLine("SHUFFLING");
            Random rand = new Random();
            for(int idx=0;idx<cards.Count;idx++){
                Card temp = cards[idx];
                int temp2 = rand.Next(0,cards.Count-1);
                cards[idx] = cards[temp2];
                cards[temp2] = temp;
            }
            return cards;
        }
        
    }
}