using System;

namespace Warriors_Fight
{

    class Program
    {
        private static void Main(string[] args)
        {

            Warrior thor = new Warrior("Thor", 100, 26, 15);

            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 12, 50);

            Battle.StartFight(thor, loki);


        }
    }

}