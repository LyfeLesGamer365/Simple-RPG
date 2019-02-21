using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Monster  : LivingCreature //gives a monster a xp and gold drop along w/ a name and id
    {
        public int ID {get;set;}
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }

    }
}
