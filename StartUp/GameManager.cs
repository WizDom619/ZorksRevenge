using ZorksRevenge.GameStates.MenuItems;

namespace ZorksRevenge
{
    public class GameManager
    {
        private GameState? _gameState = new GameState();

        public GameManager()
        {
            SaveManager.Initialize();

            _gameState = new MainMenu();

            _gameState.Display();


            while (true)
            {
                if (_gameState != null)
                {                    
                    if (_gameState is not LoadGame)
                    {
                        _gameState.ReadInput();
                    }

                    // Clear the screen each time to keep things clean. 
                    Console.Clear();
                    Console.Write("\x1b[3J\x1b[H");

                    _gameState = _gameState.Update();
                                        
                    _gameState.Display();
                }
                else
                {
                    Console.WriteLine("Null");
                }

            }
        }
    }
}
