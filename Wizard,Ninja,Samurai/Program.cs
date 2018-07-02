using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard jim = new Wizard("jim");
            Ninja kyo = new Ninja("kyo");
            Samurai bob = new Samurai("bob");

            jim.Fireball(bob);
            kyo.Steal(jim);
            bob.Death_Blow(kyo);
            jim.Fireball(bob);
            kyo.Steal(jim);
            bob.Death_Blow(kyo);
            jim.Fireball(bob);
            kyo.Steal(jim);
            bob.Death_Blow(kyo);
            jim.Fireball(bob);
            kyo.Steal(jim);
            bob.Death_Blow(kyo);
        }
    }
}
