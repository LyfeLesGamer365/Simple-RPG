using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature // gives livng creatures, monsters and player a current and max health
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }

    }
}
