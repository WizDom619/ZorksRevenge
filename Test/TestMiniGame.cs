using ZorksRevenge.MiniGames;
using ZorksRevenge.Utility;


namespace ZorksRevenge.Test
{
    internal class TestMiniGame : MiniGame
    {
        public override bool Play()
        {
            bool result = false; 

            ZorkPrinter.PrintLine("Press 1 to Win");
            ZorkPrinter.PrintLine("Press 2 to Lose");
            string i = Console.ReadLine();

            if (i == "1")
            {
                result = true;
            }
            else if (i == "2") 
            {
                result = false;
            }
            Console.Clear();
            Console.Write("\x1b[3J\x1b[H");
            return result;
        }
    }
}
