namespace NullObjectPattern
{
    public abstract class SpecialDefence
    {
        public abstract int CaculateDamageReduction(int totalDamage);

        //Singleton
        public static SpecialDefence NullObject
        {
            get { return new NonDefence(); }
        }

        private class NonDefence : SpecialDefence
        {
            public override int CaculateDamageReduction(int totalDamage)
            {
                return 0; //*** no-op behavior
            }
        }
    }
}
