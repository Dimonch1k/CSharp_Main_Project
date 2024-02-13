namespace MY_Game
{
    abstract class IHero
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackPower { get; set; }
        public int PResistance { get; set; }
        public int MResistance { get; set; }
        public int CriticalChance { get; set; }
        public int DodgeChance { get; set; }
        public enum AttackKind
        {
            Magical,
            Physical
        }


        public double TakenDMG { get; set; }


        // Methods
        public abstract AttackKind GetAttackKind();
        public abstract void GetAttack(IHero enemy, string battleGround);

        public abstract void VulcanStats();
        public abstract void FieldStats();
        public abstract void SubwayStats();

        public abstract void RenewStats();
        public abstract double HitAndHeal(double enemyDMG);
    }
}
