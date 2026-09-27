using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the Main menu 
    /// This will be the first menu state the player will see. 
    /// Here the player will need to navigate to other menu states before beginning the game. 
    /// </summary>
    public class MainMenu : GameState
    {
        // Players options to navigate the main menu
        public override void Display(GameData gameData)
        {
            ZorkArt.PrintTitle();
            ZorkPrinter.PrintLine("Please Type a Number to Select an Option:\n");
            ZorkPrinter.PrintLine("  (1): New Game");
            ZorkPrinter.PrintLine("  (2): Load Game");
            ZorkPrinter.PrintLine("  (3): How to Play");
            ZorkPrinter.PrintLine("  (4): Quit Game\n");
        }

        public override void Input(GameData gameData)
        {
            defaultInput(gameData);
        }

        // A single digit will be used to navigate the menu.
        public override void Process(GameData gameData)
        {
            switch (gameData.Input)
            {
                case "1":
                    gameData.GameState = new NewGame();
                    return;

                case "2":
                    gameData.GameState = new LoadGame();
                    return;

                case "3":
                    gameData.GameState = new HowToPlay();
                    return;

                case "4":
                    gameData.GameState = new QuitGame();
                    return;

                default:
                    return;
            }
        }
    }
}
