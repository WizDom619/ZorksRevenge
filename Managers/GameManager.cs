using ZorksRevenge.Managers;
using ZorksRevenge.Managers.GameData;

namespace ZorksRevenge
{
    // Here is where the game really begins. 
    // Right now is just creating all the game data which is in a separate class. 
    internal class GameManager
    {
        private WiringManager _wiringManager;

        private ItemManager _itemManager;
        private RoomManager _roomManager; 
        //private MainMenuManager _mainMenuManager;
        //private PlayerInputManager _playerInputManager;


        private bool isGameLooping = true;

        public GameManager()
        {
            // Instiate All Managers

            _wiringManager = new WiringManager();

            _itemManager = new ItemManager(_wiringManager);
            _roomManager = new RoomManager(_wiringManager);

            //_mainMenuManager = new MainMenuManager(_wiringManager);
            //_playerInputManager = new PlayerInputManager(_wiringManager);
            //
            _wiringManager.Update();
        }

        public void Update()
        {
            _itemManager.Print();
            _roomManager.Print();
            // Main Game Loop
            while (isGameLooping)
            {
                //_mainMenuManager.Update();
                //_playerInputManager.Update();
            }
        }
        //public MainMenuManager MainMenuManager { get { return _mainMenuManager; } }
    }    
}




