namespace ZorksRevenge
{
    /// <summary>
    /// The begginning of the Zork's Revenge Game
    /// Before the game actually starts, this is a good place to set all the console window configurations.  
    /// Such as... Title, Cursor Visibility, Screen Size or Margin Size. 
    /// Afterwards, instantiate a GameManager and the game actually begins. 
    /// </summary>
    internal class ZorksRevengeGame
    {
        private GameManager _gameManager;

        public ZorksRevengeGame()
        {
            //Set the window title. 
            Console.Title = "Zork's Revenge";

            //Set cursor visibility
            //TODO Unsure if I want this true of false... 
            Console.CursorVisible = false;

            //Clears to screen incase of any initial loading output. 
            //Guarantee a clean slate to begin the game. 
            Console.Clear();

            //Begin the game with the Game Manager
            //_gameManager = new GameManager();
            //_gameManager.Update();
        }
    }
}
