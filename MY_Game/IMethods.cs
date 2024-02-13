namespace MY_Game
{
    public abstract class IMethods
    {
        public abstract bool IsCriticalRandom(int criticalChance);
        public abstract bool IsDodgeAttack(int dodgeChance);
        public abstract void ReduceMDamage(ref double damage, int MResistance);
        public abstract void ReducePDamage(ref double damage, int PResistance);
        public abstract void MultiplyDamage(int criticalChance, ref double enemyDamage);
        public abstract string ChooseBattleGround();
    }
}
