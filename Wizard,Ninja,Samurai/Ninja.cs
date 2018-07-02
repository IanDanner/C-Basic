using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai
{
    public class Ninja:Human
    {
        public Ninja(string person):base(person){
            dexterity = 175;
        }
        public Ninja(string person, int str, int intel, int dex, int hp):base(person,str,intel,dex,hp){
        }
        public void Steal(object obj){
            System.Console.WriteLine("STEAL");
            Human enemy = obj as Human;
            Attack(obj);
            health += 10;
            System.Console.WriteLine("Enemy HP:"+enemy.health);
            if(health>100){
                health=100;
            }
            System.Console.WriteLine("Ninja "+name+" hp:"+health);            
        }
        public void Get_Away(){
            System.Console.WriteLine("GET AWAY");
            if(health-15<0){
                System.Console.WriteLine("Cannot Escape");
            }
            else{
                health-=15;
            }
            System.Console.WriteLine("Ninja "+name+" hp:"+health);            
        }
    }
}
