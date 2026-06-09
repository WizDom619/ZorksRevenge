using ZorksRevenge.Managers;

namespace ZorksRevenge
{
    // Here is where the game really begins. 
    // Right now is just creating all the game data which is in a separate class. 
    internal class GameManager
    {
        private GameDataManager _gameData;
        private MainMenuManager _mainMenuManager;
        private PlayerInputManager _playerInputManager;

        private WiringManager _wiringManager;

        private bool isGameLooping = true;

        public GameManager()
        {
            // Instiate All Managers
            _gameData = new GameDataManager();
            _mainMenuManager = new MainMenuManager();
            _playerInputManager = new PlayerInputManager(_gameData.PlayerData);

            _wiringManager = new WiringManager(this);
        }

        public void Update()
        {
            // Main Game Loop
            while (isGameLooping)
            {
                _mainMenuManager.Update();
                _playerInputManager.Update();
            }
        }

        public GameDataManager GameData { get { return _gameData; } }
        public MainMenuManager MainMenuManager { get { return _mainMenuManager; } }
    }    
}




