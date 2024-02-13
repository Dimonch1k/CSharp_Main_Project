namespace MY_Game
{
    class CArcher : IHero
    {
        public CArcher()
        {
            Name = "ARCHER";
            Health = 800;
            AttackPower = 150;
            PResistance = 8;
            MResistance = 8;
            CriticalChance = 20;
            DodgeChance = 40;
            TakenDMG = 0.0;
        }

        public PrintManager print = new PrintManager(); // Create PrintManager object
        public IMethods methods = new CMethods(); // Create object from IMethods


        // Get Attack kind of fighter
        public override AttackKind GetAttackKind()
        {
            return AttackKind.Physical;
        }


        // Defends from enemy fighter attack
        public override void GetAttack(IHero enemy, string battleGround)
        {
            ChangeStatsWithArena(battleGround);
            bool dead = isDead(enemy);
            if (dead)
            {
                Console.WriteLine($"{Name} HAS DIED", print.Red());
                return;
            }
            else
            {
                RenewStats();
            }
            return;
        }


        // Do attack to the fighter and determine is the hero dead - true and end the game, isn't dead - false and continue the game
        public bool isDead(IHero enemy)
        {
            double enemyDamage = enemy.AttackPower;
            if (!methods.IsDodgeAttack(DodgeChance))
            {
                methods.MultiplyDamage(enemy.CriticalChance, ref enemyDamage); // Increase the enemy damage by critical chance
                if (AttackKind.Magical == enemy.GetAttackKind()) // If true - the enemy fighter is mage
                {
                    methods.ReduceMDamage(ref enemyDamage, MResistance); // Reduce the magical hero damage, makes the math operations with resistance
                }
                else // reduce physical damage by pResistance
                {
                    methods.ReducePDamage(ref enemyDamage, PResistance); ; // Reduce the physical hero damage, makes the math operations with resistance
                }
                if (enemyDamage > Health)
                {
                    Health = 0;
                    return true; // Return true if the ARCHER survived
                }
                    

                print.PrintHealthDamage(HitAndHeal(enemyDamage), Name, Health, enemyDamage, enemy.Name); // Print what amount of Health and Damage that deals enemy fighter
                return false;
            }
            else
            {
                print.PrintDodged(Name, enemy.Name); // Print message about dodged enemy attack
                return false;
            }
        }


        // Change static stats of fighter depends on battle field
        public void ChangeStatsWithArena(string battleGround)
        {
            switch (battleGround.ToLower())
            {
                case "vulcan":
                    VulcanStats();
                    print.BuffsDebuffs();
                    Console.WriteLine($"\n\t  {Name}'s magical resistance increases by 10 units", print.Green());
                    Console.WriteLine($"\t  {Name}'s physical resistance reduced by 5 units\n", print.Red());
                    break;

                case "field":
                    FieldStats();
                    print.BuffsDebuffs();
                    Console.WriteLine($"\n\t  {Name}'s dodge chance increases by 10 units\n", print.Green());
                    break;

                case "subway":
                    SubwayStats();
                    print.BuffsDebuffs();
                    Console.WriteLine($"\n\t  {Name}'s dodge chance reduced by 20 units\n", print.Red());
                    break;

                default:
                    Console.WriteLine("\n\tError!!!");
                    Console.WriteLine("\tInput NUMBER!!!\n\n");
                    break;
            }
        }


        // Change fighter stats if battle ground is vulcan
        public override void VulcanStats()
        {
            MResistance += 10;
            PResistance -= 5;
        }


        // Change fighter stats if battle ground is vulcan
        public override void FieldStats()
        {   
            DodgeChance += 10;
        }


        // Change fighter stats if battle ground is vulcan
        public override void SubwayStats()
        {
            DodgeChance -= 20;
        }


        // Renew fighter's static stats after defending, because the at the new locations the stats are changed and because it necessarry
        public override void RenewStats()
        {
            PResistance = 8;
            MResistance = 8;
            CriticalChance = 20;
            DodgeChance = 40;
        }


        public override double HitAndHeal(double enemyDMG)
        {
            Health -= enemyDMG; // The enemy fighter deals damage   
            TakenDMG += enemyDMG;

            double heals = (Health / 10);
            Health += (Health / 10); // Increase the health by 1/10 of whole Health

            return heals;
        }
    }
}