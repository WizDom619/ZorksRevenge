using ZorksRevenge.FileIO;
using ZorksRevenge.Data;
using ZorksRevenge.Input; 
using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    public class GameManager
    {
        // Holds all the game data (both the player and world data)
        private GameData _gameData = new GameData();

        //private InputParser

        public GameManager()
        {
            // Initialise all Managers
            FileManager.Init(_gameData);

            /// Static Classes 
            // ZorkPrinter
            // InputManager

            while (true)
            {
                DisplayOutput();
                ReadInput();
                ProcessData();
            }
        }
        private void DisplayOutput()
        {
            ZorkPrinter.ClearScreen();
            _gameData.State.Display(_gameData);
        }

        private void ReadInput()
        {
            _gameData.State.ReadInput(_gameData);
        }

        private void ProcessData()
        {
            _gameData.State.Process(_gameData);
        }

    }
}
