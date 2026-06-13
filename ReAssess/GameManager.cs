using ZorksRevenge.EventArgs;
using ZorksRevenge.ReAssess.Utilities;

namespace ZorksRevenge.ReAssess.Managers
{
    // Here is where the game really begins. 
    // Right now is just creating all the game data which is in a separate class. 
    internal class GameManager
    {
        private EventManager _eventManager;

        private ItemManager _itemManager;
        private RoomManager _roomManager; 
        //private MainMenuManager _mainMenuManager;
        private PlayerInputManager _playerInputManager;


        private bool isGameLooping = true;

        public GameManager()
        {
            // Instiate All Managers

            _eventManager = new EventManager();

            _itemManager = new ItemManager(_eventManager);
            _roomManager = new RoomManager(_eventManager);
            //_mainMenuManager = new MainMenuManager();
            _playerInputManager = new PlayerInputManager();

            //_eventManager.OnActionSendItemsToItemManager += _itemManager.OnActionSendItemsToItemManager;
            
            _eventManager.Setup();
        }

        public void Update()
        {
            //_itemManager.Print();
            //_roomManager.Print();
            ColourPrinter.TEST_PrintAllColours();
            // Main Game Loop
            while (isGameLooping)
            {
                //_mainMenuManager.Update();
                //_playerInputManager.Update();
            }
        }
    }    
}




