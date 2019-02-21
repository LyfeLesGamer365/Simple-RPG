using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item // gives a weapon a max and min amout of damage dealt
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
       
      public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
