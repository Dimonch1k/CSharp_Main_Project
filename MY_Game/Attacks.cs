namespace MY_Game
{
    internal class Attacks
    {
        private IHero? hero1 = null;
        private IHero? hero2 = null;
        private PrintManager print = new PrintManager();

        public void Attack()
        {
            IHero fighter1 = SelectFFighter();
            IHero fighter2 = SelectSFighter();

            while (true)
            {
                // Fighter 1 attacks Fighter 2
                print.Clear();
                print.F1AttacksF2(fighter1.Name, fighter2.Name);
                fighter2.GetAttack(fighter1, ChooseBattleGround()); // Fighter 2 is being attacked
                Console.ReadKey(); // Stops the program until the user presses the button

                SFighterIsDead(fighter1, fighter2); // Checking if the fighter 1 Win?


                // Fighter 2 attacks Fighter 1

                print.Clear();
                print.F2AttacksF1(fighter2.Name, fighter1.Name);
                fighter1.GetAttack(fighter2, ChooseBattleGround()); // Fighter 1 is being attacked
                Console.ReadKey(); // Stops the program until the user presses the button

                FFighterIsDead(fighter1, fighter2); // Checking if the fighter 2 Win?
            }
        }

        // Checking if the fighter 2 has died, if true fighter 1 Win
        private void FFighterIsDead(IHero fighter1, IHero fighter2)
        {
            if (fighter1.Health <= 0)
            {
                print.ReceivedDamage(fighter1.Name, fighter2.Name, fighter1.TakenDMG, fighter2.TakenDMG);

                Console.ReadKey();
                bool archer = (fighter2.Name == "ARCHER");
                bool mage = (fighter2.Name == "MAGE");
                bool warrior = (fighter2.Name == "WARRIOR");

                if (archer) print.ArcherWin();
                if (mage) print.MageWin();
                if (warrior) print.WarriorWin();

                print.EndGame();
            }
        }

        // Checking if the fighter 1 has died, if true fighter 2 Win
        private void SFighterIsDead(IHero fighter1, IHero fighter2)
        {
            if (fighter2.Health <= 0)
            {
                print.ReceivedDamage(fighter1.Name, fighter2.Name, fighter1.TakenDMG, fighter2.TakenDMG);

                bool archer = (fighter1.Name == "ARCHER");
                bool mage = (fighter1.Name == "MAGE");
                bool warrior = (fighter1.Name == "WARRIOR");

                if (archer) print.ArcherWin();
                if (mage) print.MageWin();
                if (warrior) print.WarriorWin();

                print.EndGame();
            }
        }


        // Selecting fighters
        private IHero SelectFFighter()
        {
            print.Clear();
            print.Fighters();
            Console.Write("\tEnter 1 fighter: ", print.Blue());
            int Selection1 = Int32.Parse(Console.ReadLine());
            hero1 = newFighter(Selection1);
            if (hero1 == null)
            {
                SelectFFighter();
            }
            return hero1;
        }
        private IHero SelectSFighter()
        {
            print.Clear();
            print.Fighters();
            Console.Write("\tEnter 2 fighter: ", print.Purple());
            int Selection2 = Int32.Parse(Console.ReadLine());
            hero2 = newFighter(Selection2);
            if (hero2 == null)
            {
                SelectSFighter();
            }
            return hero2;
        }


        // The user is choosing the battle ground
        public string ChooseBattleGround()
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
                        Console.WriteLine("\n\tError!!!");
                        Console.WriteLine("\tInput NUMBER!!!\n\n");
                        Console.ReadKey();
                        print.Clear();
                        break;
                }
            }
        }


        private IHero? newFighter(int num)
        {
            switch (num)
            {
                case 1:
                    return new CArcher();
                case 2:
                    return new CMage();
                case 3:
                    return new CWarrior();
                default:
                    print.Error_StartAttackAgain();
                    return null;
            }

        }
    }
}
