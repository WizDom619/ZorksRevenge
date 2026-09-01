using ZorksRevenge.Data;
using ZorksRevenge.FileIO;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates 
{
    // This class will load the the previous save file
    // And begin a Campaign, (from where the player last saved). 
    public class LoadGame : GameState
    {
        public override void Display(GameData gameData)
        {
            // Caching the reference. 
            string text = gameData.Player.Name;

            ZorkPrinter.PrintLine("Load Game");
            ZorkPrinter.PrintLine($"Welcome back {text}");
        }

        public override void ReadInput(GameData gameData)
        {
            PressAnyKey();
        }

        public override void Process(GameData gameData)
        {
            // TODO
            // FileManager.LoadGameData();

            // Begin the Campaign with the previous saves data loaded. 
            gameData.State = new Campaign();
        }
    }
}
