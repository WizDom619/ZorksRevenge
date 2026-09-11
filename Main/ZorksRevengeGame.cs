using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    /// <summary>
    /// The beginning of Zork's Revenge
    /// This is a good place to set all the console window configurations.  
    /// Configurations included
    ///     Title, 
    ///     Cursor Visibility, 
    ///     Enabling the use of ANCI codes 
    ///     Performing the initial clearing of the screen
    ///            
    /// Afterwards, instantiate GameManager()
    /// </summary>
    public class ZorksRevengeGame
    {
        public ZorksRevengeGame()
        {
            // Set the window's title. 
            Console.Title = "Zork's Revenge";

            // Set cursor visibility
            // Looks more professional this way
            Console.CursorVisible = false;

            // Enables Ansi codes to be used such as, in ZorkPrinter.ClearScreen()
            // This allows for a more robust way to clear the screen across different operating systems
            ZorkPrinter.EnableAnsiOnWindows();

            // Clears to screen of any initial system loading output. 
            // This guarantees a clean slate to begin the game. 
            ZorkPrinter.ClearScreen();

            // Instantiate the GameManager to begin the game loop
            GameManager _gameManager = new GameManager();
        }
    }
}
