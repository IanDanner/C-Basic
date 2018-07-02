using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai
{
    public class Wizard : Human
    {
        public Wizard(string person):base(person){
            intelligence = 25;
            health = 50;
        }
        public Wizard(string person, int str, int intel, int dex, int hp):base(person,str,intel,dex,hp){
        }
        public void Heal(){
            System.Console.WriteLine("HEAL");
            int heal = intelligence * 10;
            if(health+heal > 50){
                health = 50;
            }
            else{
                health += heal;
            }
            System.Console.WriteLine("Wizard "+name+" hp:"+health);
        }
        public void Fireball(object obj){
            System.Console.WriteLine("FIREBALL");
            Human enemy = obj as Human;
            Random rand = new Random();
            if(enemy == null){
                Console.WriteLine("Failed Attack");
            }
            else{
                enemy.health -= rand.Next(20,50);
                if(enemy.health<0){
                    enemy.health=0;
                }
                System.Console.WriteLine("Enemy HP:"+enemy.health);
            }
        }
    }
}
