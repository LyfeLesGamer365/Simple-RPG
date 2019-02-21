using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature // gives the player a gold ex and level amount
    {

        public int Gold {get;set;}
        public int ExeriencePoints {get;set;}
        public int Level {get;set;}

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }

    }
}
