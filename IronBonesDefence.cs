using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern
{
    public class IronBonesDefence : SpecialDefence
    {
        public override int CaculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
