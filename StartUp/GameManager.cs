using ZorksRevenge.GameStates;

namespace ZorksRevenge.StartUp
{
    internal class GameManager
    {
        private GameState? _gameState = new GameState();

        public GameManager()
        {
            //_gameState = new MainMenu();

            //TESTING
            _gameState = new Campaign();

            _gameState.Display();

            while (true)
            {
                if (_gameState != null)
                {                    
                    _gameState.ReadInput();

                    // Clear the screen each time to keep things clean. 
                    Console.Clear();

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
