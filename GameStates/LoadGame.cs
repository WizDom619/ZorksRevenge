using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates 
{
    /// <summary>
    /// This class will load the the previous save file
    /// And begin a Campaign, (from where the player last saved). 
    /// </summary>    
    public class LoadGame : GameState
    {
        public override void Display(GameData gameData)
        {
            // Caching the reference. 
            string name = gameData.Player.Name;

            ZorkPrinter.PrintLine("Load Game");
            ZorkPrinter.PrintLine($"Welcome back {name}");
        }

        public override void Input(GameData gameData)
        {
            PressAnyKey();
        }

        public override void Process(GameData gameData)
        {
            // DOMTODO
            // FileManager.LoadGameData();

            // Begin the Campaign with the previous saves data loaded. 
            gameData.GameState = new Campaign();
        }
    }
}
