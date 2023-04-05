﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Fight
{
     class MagicWarrior : Warrior
    {

        int teleportChance = 0;

        CanTeleport teleportType = new CanTeleport();

        public MagicWarrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0,
            int teleportChance = 0)
        {
           this.teleportChance = teleportChance;
        }

        public override double Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            if (rndDodge < this.teleportChance)
            {
                Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 10000;
            } else
            {
                return base.Block();
            }
        }

    }
}
