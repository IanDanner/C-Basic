using System;
using System.Collections.Generic;

namespace Human
{
    public class Human
    {
        public string name = "Bob";
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        public void Custom(string valN = "Joe",int str = 3,int intel=3,int dex=3,int heal=100){
            name = valN;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = heal;
        }
        public void Attack(Human attacker, Human defender){
            int atk = attacker.strength * 5;
            defender.health -= atk;
        }
    }
}
