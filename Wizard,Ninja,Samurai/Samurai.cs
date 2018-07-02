using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai
{
    public class Samurai:Human
    {
        public Samurai(string person):base(person){
            health = 200;
        }
        public Samurai(string person, int str, int intel, int dex, int hp):base(person,str,intel,dex,hp){
        }
        public void Death_Blow(object obj){
            System.Console.WriteLine("DEATH BLOW");
            Human enemy = obj as Human;
            Attack(obj);
            if(enemy.health<50){
                enemy.health=0;
            }
            System.Console.WriteLine("Enemy HP:"+enemy.health);                                   
        }
        public void Meditate(){
            System.Console.WriteLine("MEDITATE");
            health = 200;
            System.Console.WriteLine("Samurai "+name+" hp:"+health);                        
        }

    }
}
