using ZorksRevenge.GameStates;

namespace ZorksRevenge.StartUp
{
    internal class GameManager
    {
        private GameState? _gameState = new GameState();

        public GameManager()
        {
            _gameState = new MainMenu();

            while (true)
            {
                if (_gameState != null)
                {
                    _gameState.Display();
                    _gameState.ReadInput();                
                    _gameState = _gameState.Update();
                }
                else
                {
                    Console.WriteLine("Null");
                }


                // Clear the screen each time to keep things clean. 
                Console.Clear();
            }












            /*
            // Game Begins with the Main Menu. 
            _menuHandler = new MenuHandler();
            _menuHandler.Update();

            */

            // Begin the Main Game. 
            //_gameData = new GameDataHandler();
            //_gameData.Print();

            
                //_gameData.Display();

                // Read Player's Input.
                //string input = Console.ReadLine();

                //Convert Input into a Command object. 
                //Command inputCommand = _inputParser.Process(input);

                // Send Command to the Event Bus to Process. 
            
        }

    }
}
