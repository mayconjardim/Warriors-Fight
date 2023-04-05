using System;

namespace Warriors_Fight
{

    class Program
    {
        private static void Main(string[] args)
        {

            Warrior thor = new Warrior("Thor", 120, 26, 10);

            Warrior loki = new Warrior("Loki", 100, 26, 10);

            Battle.StartFight(thor, loki);


        }
    }

}