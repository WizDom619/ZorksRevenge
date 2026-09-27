using ZorksRevenge.Data;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// New Game will...
    /// Get the player to input their name.
    /// Load a new save file and beginning the Campaign().
    /// </summary>
    public class NewGame : GameState
    {
        public override void Display(GameData gameData)
        {
            Console.WriteLine("New Game, Press Enter your Name: \n");
        }

        public override void Input(GameData gameData)
        {
            defaultInput(gameData);
        }

        public override void Process(GameData gameData)
        {
            // Set the player's name
            gameData.Player.Name = gameData.Input;

            // DOMTODO
            //FileManager.NewGameData();

            // Begin the Campaign with a new save data. 
            gameData.GameState = new Campaign();
        }
    }
}
