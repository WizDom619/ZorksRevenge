using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the Quit Game Option. 
    /// Player will be given to or not to quit the game. 
    /// Is not, return to main menu. 
    /// If Quit, then terminate the program. 
    /// </summary>
    public class QuitGame : GameState
    {
        public override void Display(GameData gameData)
        {
            ZorkPrinter.PrintLine("----------------------------------------------------------------------------------------------");
            Console.Write("                                     ");
            ZorkPrinter.PrintLine(":( Quit :(");
            ZorkPrinter.PrintLine("----------------------------------------------------------------------------------------------");

            // Ask again, just incase Player wants to keep playing. 
            ZorkPrinter.Print("\nAre you sure you want to Quit?\n", ConsoleColor.Gray, PrintEffect.Italic);
            ZorkPrinter.PrintLine("  (1): No");
            ZorkPrinter.PrintLine("  (2): Yes\n");
        }

        public override void Process(GameData gameData)
        {             
            if (gameData.Input != "2")
            {
                // False alarm, return to Main Menu
                gameData.State = new MainMenu();
            }
            else
            {
                // Game has Ended, display a Goodbye Message. 
                ZorkPrinter.Print("\nThanks for Playing!\n\n");
                // Terminate program. 
                Environment.Exit(0);
            }            
        }
    }
}
