using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jim = new Human();
            jim.Custom("jim",4,5,5,125);
            Human bob = new Human();
            jim.Attack(jim,bob);
            Console.WriteLine(bob.health);
        }
    }
}
