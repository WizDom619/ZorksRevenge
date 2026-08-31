using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the Quit Game Option. 
    /// Player will be given to or not to quit the game. 
    /// Is not, return to main menu. 
    /// is quite then terminate the program. 
    /// </summary>
    public class QuitGame : GameState
    {
        public override void Display()
        {
            ZorkPrinter.PrintLine("----------------------------------------------------------------------------------------------");
            Console.Write("                                     ");
            ZorkPrinter.PrintLine(":( Quit :(");
            ZorkPrinter.PrintLine("----------------------------------------------------------------------------------------------");

            // Ask again, just in case. 
            ZorkPrinter.Print("\nAre you sure you want to Quit?\n", ConsoleColor.Gray, PrintEffect.Italic);
            ZorkPrinter.PrintLine("  (1): No");
            ZorkPrinter.PrintLine("  (2): Yes\n");
        }

        public override GameState Update()
        {             
            if (_response != "2")
            {
                // False alarm, return to Main Menu
                return new MainMenu();
            }
            else
            {
                // Game has Ended, display a Goodbye Message. 
                ZorkPrinter.Print("\nThanks for Playing!\n\n");
                Environment.Exit(0);
                return null;
            }            
        }
    }
}
