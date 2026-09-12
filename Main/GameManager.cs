using ZorksRevenge.FileIO;
using ZorksRevenge.Input;
using ZorksRevenge.Utility;
using ZorksRevenge.GameData;

namespace ZorksRevenge.Main
{
    /// <summary>
    /// This is the Game Manager
    /// Here all Manager Classes will be instantiated or initialised.
    /// Additionally this class will also Run the main Game Loop 
    /// </summary>
    public class GameManager
    {
        // Holds all the game data (both the player and world data)
        private GameData _gameData;
        private DisplayManager _displayManager;
        private InputManager _inputManager;
        private ProcessManager _processManager;

        //private InputParser

        public GameManager()
        {
            _gameData = new GameData();
            _displayManager = new DisplayManager(_gameData);
            _inputManager = new InputManager(_gameData);
            _processManager = new ProcessManager(_gameData);

            // Initialise all other Managers
            //FileManager.Init(_gameData);

            /// Static Classes 
            // ZorkPrinter
            // InputManager            
        }

        public void Run()
        {
            // The Game Loop
            while (true)
            {
                _displayManager.Display();
                _inputManager.Input();
                _processManager.Process();
            }
        }
    }
}
