using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern
{
    public class DiamondSkinDefence : SpecialDefence
    {
        public override int CaculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
