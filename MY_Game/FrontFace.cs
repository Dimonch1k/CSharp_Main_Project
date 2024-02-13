namespace MY_Game
{
    public class FrontFace
    {
        private static Attacks attacks = new Attacks();

        private static PrintManager print = new PrintManager();

        public void User_Game()
        {
            print.Clear(); // clear console and Paint the headline

            print.EndOrContinue(); // Show ways - end or continue the game

            if (IsContinue())
            {
                attacks.Attack(); // User goes to the next stage of the game
            }
            else
            {
                print.EndGame();
            }
        }

        private bool IsContinue()
        {
            Console.Write("\tMake choice: ");
            int choice = Int32.Parse(Console.ReadLine());
            if (choice == 1)
            {
                return false;
            }
            else if (choice == 2)
            {
                print.Clear();
                print.Fighters(); // Show fighters
                return true;
            }
            else
            {
                User_Game();
            }
            return false;
        }
    }
}