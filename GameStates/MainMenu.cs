using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the Main menu 
    /// This will be the first menu state the player will see. 
    /// Here the player will need to navigate to other menu states before playing. 
    /// </summary>
    public class MainMenu : GameState
    {
        //Players options to navigate the main menu
        public override void Display(GameData gameData)
        {
            ZorkPrinter.PrintTitle();
            ZorkPrinter.PrintLine("Please Select a Number:\n");
            ZorkPrinter.PrintLine("  (1): New Game");
            ZorkPrinter.PrintLine("  (2): Load Game");
            ZorkPrinter.PrintLine("  (3): How to Play");
            ZorkPrinter.PrintLine("  (4): Quit Game\n");
        }

        // User will enter a number to navigate the Main Menu
        public override void Process(GameData gameData)
        {
            switch (gameData.Input)
            {
                case "1":
                    gameData.State = new NewGame();
                    return;

                case "2":
                    gameData.State = new LoadGame();
                    return;

                case "3":
                    gameData.State = new HowToPlay();
                    return;

                case "4":
                    gameData.State = new QuitGame();
                    return;

                default:
                    return;
            }
        }
    }
}
