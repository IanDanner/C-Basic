//Custom Way to do Deck of cards



using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck_of_Cards
    {
        public List<string> deck = new List<string>();
        public string[] suits = {"Heart","Diamond","Spade","Club"};
        public string[] ranks= {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};
        public Deck_of_Cards(){
            for(int i=0;i<ranks.Length;i++){
                for(int ii=0;ii<suits.Length;ii++){
                    deck.Add(ranks[i]+" "+suits[ii]);
                }
            }
        }
        public void Shuffle(int num){
            Random rand = new Random();
            for(int i=0;i<num;i++){
                for(int idx=0;idx<deck.Count;idx++){
                    string temp = deck[idx];
                    int temp2 = rand.Next(0,51);
                    deck[idx] = deck[temp2];
                    deck[temp2] = temp;
                }
            }
        }
        public string[] Deal(int num){
            string[] hand = new string[num];
            int amt = 0;
            while(amt < num){
                int card = deck.Count-1;
                hand[amt] = deck[card];
                deck.RemoveAt(card);
                System.Console.WriteLine("In my Hand: "+hand[amt]);
                amt++;
            }
            System.Console.WriteLine("Cards left in deck: "+deck.Count);
            return hand;
        }
        
    }
}