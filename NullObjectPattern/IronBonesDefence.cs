using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern
{
    public class IronBonesDefence : ISpecialDefence
    {
        public int CaculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
