using MY_Game;

namespace MY_GAME
{
    class Game
    {
        public static void Main(string[] args)
        {
            Console.Write("Press some button to start the game.");
            Console.ReadKey();
            FrontFace frontFace = new FrontFace();
            frontFace.User_Game();
        }
    }
}