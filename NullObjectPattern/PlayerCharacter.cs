using System;

namespace NullObjectPattern
{
    public class PlayerCharacter
    {
        private readonly ISpecialDefence _specialDefence;

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
            Health = 100;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public void Hit(int damage)
        {
            var damageReduction = 0;

            if(_specialDefence != null)
                damageReduction = _specialDefence.CaculateDamageReduction(damage);
            
            var totalDamageTaken = damage - damageReduction;
            Health -= totalDamageTaken;

            var msg = string.Format("{0}'s health has been reduced by {1} to {2}.", Name, totalDamageTaken, Health);
            Console.WriteLine(msg);

        }
    }
}
