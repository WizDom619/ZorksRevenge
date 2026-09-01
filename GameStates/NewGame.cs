using ZorksRevenge.Data;
using ZorksRevenge.FileIO;

namespace ZorksRevenge.GameStates
{
    // New Game will...
    // Get the player to input their name.
    // Load a new save file and beging the Campaign(). 
    public class NewGame : GameState
    {
        public override void Display(GameData gameData)
        {
            Console.WriteLine("New Game, Press Enter your Name: \n");
        }

        public override void Process(GameData gameData)
        {
            // Set the player's name
            gameData.Player.Name = gameData.Input;

            // TODO
            //FileManager.NewGameData();

            // Begin the Campaign with a new save data. 
            gameData.State = new Campaign();
        }
    }
}
