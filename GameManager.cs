using ZorksRevenge.FileIO;
using ZorksRevenge.GameData;
using ZorksRevenge.GameStates;
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
            FileManager.Init();

            // ZorkPrinter
            // InputManager

            // 
            _gameData.State = new MainMenu();

            while (true)
            {
                Display();
                ReadInput();
                Process();
            }
        }
        private void Display()
        {
            ZorkPrinter.ClearScreen();
            _gameData.Display();
        }

        private void ReadInput()
        {
            string? input = Console.ReadLine();
            InputManager.ParseInput(_gameData, input);
        }

        private void Process()
        {
            _gameData.Update(_gameData);
        }

    }
}
