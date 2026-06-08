using ZorksRevenge.Managers;

namespace ZorksRevenge
{
    // Here is where the game really begins. 
    // Right now is just creating all the game data which is in a separate class. 
    internal class GameManager
    {
        private GameData _gameData;
        private WiringManager _wiringManager;
        private PlayerInputManager _playerInputManager;

        public GameManager()
        {
            _gameData = new GameData();
            _wiringManager = new WiringManager(_gameData);
            _playerInputManager = new PlayerInputManager(_gameData.PlayerData);
        }
    }    
}




