using ZorksRevenge.Data;
using ZorksRevenge.GameStates;

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

        //private InputParser

        public GameManager()
        {
            _gameData = new GameData();

            // Initialise all other Managers
            //FileManager.Init(_gameData);

            /// Static Classes 
            // ZorkPrinter
            // InputManager
            // 

            _gameData.GameState = new MainMenu();
        }

        public void Run()
        {
            // The Game Loop
            while (true)
            {
                _gameData.GameState.Display(_gameData);
                _gameData.GameState.Input(_gameData);
                _gameData.GameState.Process(_gameData);
            }
        }
    }
}
