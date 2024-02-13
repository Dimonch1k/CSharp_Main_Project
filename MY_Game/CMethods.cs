namespace MY_Game
{
    public class CMethods : IMethods
    {
        private Random random = new Random();
        private PrintManager print = new PrintManager();


        // Is critical damage or not with help Random class
        public override bool IsCriticalRandom(int criticalChance)
        {
            if (random.Next(1, 101) < criticalChance) return true;
            return false;
        }


        // Determine is the fighter dodged enemy fighter attack by dodgeChance
        public override bool IsDodgeAttack(int dodgeChance)
        {
            if (random.Next(1, 101) < dodgeChance) return true; // Return true if it's critical damage
            return false; // Return false if it isn't critical damage
        }


        // Reduce the enemy fighter damage by magical damage
        public override void  ReduceMDamage(ref double damage, int MResistance)
        {
            damage -= (damage / 100) * MResistance;
        }


        // Reduce the enemy fighter damage by physical damage
        public override void ReducePDamage(ref double damage, int PResistance)
        {
            damage -= (damage / 100) * PResistance;
        }


        // Multiply fighter damage if criticalChance is TRUE
        public override void MultiplyDamage(int criticalChance, ref double enemyDamage)
        {
            if (IsCriticalRandom(criticalChance))
            {
                enemyDamage *= 1.5;
            }
        }


        // The user choose the battle ground
        public override string ChooseBattleGround()
        {
            while (true)
            {
                print.PrintBattlePlaces();

                int battleGround = Convert.ToInt32(Console.ReadLine());
                switch (battleGround)
                {
                    case 1:
                        return "vulcan";
                    case 2:
                        return "field";
                    case 3:
                        return "subway";
                    default:
                        Console.WriteLine("Error!!!");
                        Console.WriteLine("Input NUMBER!!!\n\n");
                        continue;
                }
            }
        }
    }
}