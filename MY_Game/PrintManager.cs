namespace MY_Game
{
    public class PrintManager
    {
        public void PrintHealthDamage(double heals, string Name, double Health,  double Damage, string enemyName)
        {
            Console.WriteLine($"\t{enemyName} dealt {Math.Floor(Damage)} damage.", Red());
            Console.WriteLine($"\t{Name} heals by {Math.Floor(heals)}", Green());
            Console.WriteLine($"\t{Name}'s health: {Math.Floor(Health)}.", Green());
            Console.ResetColor();
        }

        public void PrintDodged(string Name, string enemyName)
        {
            Console.WriteLine($"\t{Name} has been dodged the {enemyName}'s attack\n");
        }

        public void BuffsDebuffs()
        {
            Console.WriteLine($"\tBUFFS  ||  DEBUFFS", Purple());
        }

        // Display 3 battle places and user choose one
        public void PrintBattlePlaces()
        {
            Console.WriteLine("\tBattlefields:", Purple());
            Console.WriteLine("\t  1. Vulcan", Red());
            Console.WriteLine("\t  2. Field", Yellow());
            Console.WriteLine("\t  3. Subway\n", Gray());
            ResetColor();
            Console.Write("\tChoose Battle Ground: ");
        }

        // Display all fighters on the arena
        public void Fighters()
        {
            Console.WriteLine("\tFIGHTERS:", Red());
            Console.WriteLine("\t  1. Archer", Green());
            Console.WriteLine("\t  2. Mage", Blue());
            Console.WriteLine("\t  3. Warrior", Purple());
            Console.WriteLine("");
            ResetColor();
        }


        // Fighter 1 attacks Fighter 2
        public void F1AttacksF2(string fName1, string fName2)
        {
            Console.WriteLine($"\t{fName1} attacks {fName2}\n", Blue());
        }
        
        // Fighter 2 attacks Fighter 1
        public void F2AttacksF1(string fName2, string fName1)
        {
            Console.WriteLine($"\t{fName2} attacks {fName1}\n", Blue());
        }


        // Paint on the screen the Header - "START GAME"
        public void StartGame()
        {
            Console.WriteLine($@"           ____    ______  ______  ____    ______      ____    ______           ____          ", Blue());
            Console.WriteLine($@"         /\  _`\ /\__  _\/\  _  \/\  _`\ /\__  _\    /\  _`\ /\  _  \  /'\_/`\/\  _`\         ");
            Console.WriteLine($@"         \ \,\L\_\/_/\ \/\ \ \L\ \ \ \L\ \/_/\ \/    \ \ \L\_\ \ \L\ \/\      \ \ \L\_\       ");
            Console.WriteLine($@"          \/_\__ \  \ \ \ \ \  __ \ \ ,  /  \ \ \     \ \ \L_L\ \  __ \ \ \__\ \ \  _\L       ");
            Console.WriteLine($@"           /\ \L\ \  \ \ \ \ \ \/\ \ \ \\ \  \ \ \     \ \ \/, \ \ \/\ \ \ \_/\ \ \ \L\ \     ", Yellow());
            Console.WriteLine($@"           \ `\____\  \ \_\ \ \_\ \_\ \_\ \_\ \ \_\     \ \____/\ \_\ \_\ \_\\ \_\ \____/     ");
            Console.WriteLine($@"            \/_____/   \/_/  \/_/ \/_/\/_/\/ / \/_/      \/___/  \/_/\/_/\/_/ \/_/\/___/      ");

            ResetColor();
            Console.WriteLine("\n\n\n");
        }

        // Paint on the screen - "END GAME"
        public void EndGame()
        {
            Console.Write("\n\n\n");
            Console.WriteLine($@"           ____    __  __  ____        ____    ______           ____             ", Blue());
            Console.WriteLine($@"          /\  _`\ /\ \/\ \/\  _`\     /\  _`\ /\  _  \  /'\_/`\/\  _`\            ");
            Console.WriteLine($@"          \ \ \L\_\ \ `\\ \ \ \/\ \   \ \ \L\_\ \ \L\ \/\      \ \ \L\_\          ");
            Console.WriteLine($@"           \ \  _\L\ \ , ` \ \ \ \ \   \ \ \L_L\ \  __ \ \ \__\ \ \  _\L          ");
            Console.WriteLine($@"            \ \ \L\ \ \ \`\ \ \ \_\ \   \ \ \/, \ \ \/\ \ \ \_/\ \ \ \L\ \        ", Yellow());
            Console.WriteLine($@"             \ \____/\ \_\ \_\ \____/    \ \____/\ \_\ \_\ \_\\ \_\ \____/        ");
            Console.WriteLine($@"              \/___/  \/_/\/_/\/___/      \/___/  \/_/\/_/\/_/ \/_/\/___/         ");
            ResetColor();
            Console.ReadKey();
            Environment.Exit(0);
        }



        // Paint on the screen - "Win Archer"
        public void ArcherWin()
        {
            Console.WriteLine($@"           __      __                  ______               __                         ", Blue());
            Console.WriteLine($@"          /\ \  __/\ \  __            /\  _  \             /\ \                        ");
            Console.WriteLine($@"          \ \ \/\ \ \ \/\_\    ___    \ \ \L\ \  _ __   ___\ \ \___      __   _ __     ");
            Console.WriteLine($@"           \ \ \ \ \ \ \/\ \ /' _ `\   \ \  __ \/\`'__\/'___\ \  _ `\  /'__`\/\`'__\   ");
            Console.WriteLine($@"            \ \ \_/ \_\ \ \ \/\ \/\ \   \ \ \/\ \ \ \//\ \__/\ \ \ \ \/\  __/\ \ \/    ", Yellow());
            Console.WriteLine($@"             \ `\___x___/\ \_\ \_\ \_\   \ \_\ \_\ \_\\ \____\\ \_\ \_\ \____\\ \_\    ");
            Console.WriteLine($@"              '\/__//__/  \/_/\/_/\/_/    \/_/\/_/\/_/ \/____/ \/_/\/_/\/____/ \/_/    ");
            ResetColor();
        }

        // Paint on the screen - "Win Mage"
        public void MageWin()
        {
            Console.WriteLine($@"           __      __                                                        ", Blue());
            Console.WriteLine($@"          /\ \  __/\ \  __              /'\_/`\                              ");
            Console.WriteLine($@"          \ \ \/\ \ \ \/\_\    ___     /\      \     __       __      __     ");
            Console.WriteLine($@"           \ \ \ \ \ \ \/\ \ /' _ `\   \ \ \__\ \  /'__`\   /'_ `\  /'__`\   ");
            Console.WriteLine($@"            \ \ \_/ \_\ \ \ \/\ \/\ \   \ \ \_/\ \/\ \L\.\_/\ \L\ \/\  __/   ");
            Console.WriteLine($@"             \ `\___x___/\ \_\ \_\ \_\   \ \_\\ \_\ \__/.\_\ \____ \ \____\  ", Yellow());
            Console.WriteLine($@"              '\/__//__/  \/_/\/_/\/_/    \/_/ \/_/\/__/\/_/\/___L\ \/____/  ");
            Console.WriteLine($@"                                                              /\____/        ");
            Console.WriteLine($@"                                                              \_/__/         ");
            ResetColor();
        }

        // Paint on the screen - "Win Warrior"
        public void WarriorWin()
        {
            Console.WriteLine($@"           __      __                  __      __                                                 ", Blue());
            Console.WriteLine($@"          /\ \  __/\ \  __            /\ \  __/\ \                          __                    ");
            Console.WriteLine($@"          \ \ \/\ \ \ \/\_\    ___    \ \ \/\ \ \ \     __     _ __   _ __ /\_\    ___   _ __     ");
            Console.WriteLine($@"           \ \ \ \ \ \ \/\ \ /' _ `\   \ \ \ \ \ \ \  /'__`\  /\`'__\/\`'__\/\ \  / __`\/\`'__\   ");
            Console.WriteLine($@"            \ \ \_/ \_\ \ \ \/\ \/\ \   \ \ \_/ \_\ \/\ \L\.\_\ \ \/ \ \ \/ \ \ \/\ \L\ \ \ \/    ", Yellow());
            Console.WriteLine($@"             \ `\___x___/\ \_\ \_\ \_\   \ `\___x___/\ \__/.\_\\ \_\  \ \_\  \ \_\ \____/\ \_\    ");
            Console.WriteLine($@"              '\/__//__/  \/_/\/_/\/_/    '\/__//__/  \/__/\/_/ \/_/   \/_/   \/_/\/___/  \/_/    ");
            ResetColor();
        }


        

        // Display taken damage in two fighters
        public void ReceivedDamage(string name1, string name2, double takenDMG1, double takenDMG2)
        {
            Console.WriteLine($"\t{name1} received {Math.Floor(takenDMG1)} dmg\n");
            Console.WriteLine($"\t{name2} received {Math.Floor(takenDMG2)} dmg\n\n");
        }
         


        // Print two ways - end of continue
        public void EndOrContinue()
        {
            Red();
            Console.WriteLine("\t1. Exit the game");
            Green();
            Console.WriteLine("\t2. Continue the game");
            Console.ResetColor();
        }


        public void Error_StartAttackAgain()
        {
            Console.WriteLine("\t\tIncorrect inputting!!!", Purple());
            Console.WriteLine("\t\tPlease choose fighters by number!!!", Purple());
            Console.ReadKey();
            ResetColor();
            Clear();
        }


        // CLEAR Console
        public void Clear()
        {
            Console.Clear();
            StartGame();
        }


        // COLORS

        public ConsoleColor Red()
        {
            return Console.ForegroundColor = ConsoleColor.Red;
        }
        public ConsoleColor Green()
        {
            return Console.ForegroundColor = ConsoleColor.Green;
        }
        public ConsoleColor Blue()
        {
            return Console.ForegroundColor = ConsoleColor.Blue;
        }
        public ConsoleColor Purple()
        {
            return Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public ConsoleColor Yellow()
        {
            return Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public ConsoleColor Gray()
        {
            return Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void ResetColor()
        {
            Console.ResetColor();
        }
    }
}
