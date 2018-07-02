using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string val1,string val2,int val3){
            stringVal = val1;
            suit = val2;
            val = val3;
        }
    }
}