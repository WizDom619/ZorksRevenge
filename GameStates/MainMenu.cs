using ZorksRevenge.Menu;
using ZorksRevenge.StartUp;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the Main menu 
    /// This will be the first menu state the player will see. 
    /// Here the player can navigate to other menu states and begin playing the game. 
    /// </summary>
    internal class MainMenu : GameState
    {
        //Players options to navigate the main menu
        public override void Display()
        {
            ZorkPrinter.PrintTitle();
            ZorkPrinter.PrintLine("Please Select a Number:\n");
            ZorkPrinter.PrintLine("  (1): New Game");
            ZorkPrinter.PrintLine("  (2): Load Game");
            ZorkPrinter.PrintLine("  (3): How to Play");
            ZorkPrinter.PrintLine("  (4): Quit Game\n");
        }

        public override GameState? Update()
        {
            switch (_response)
            {
                case "1":
                    return new NewGame();

                case "2":
                    return new LoadGame();

                case "3":
                    return new HowToPlay();

                case "4":
                    return  new QuitGame();

                default:
                    break;
            }

            return null;
        }
    }
}
