namespace ZorksRevenge
{
    /* Game Data holds all the managers classes. 
     * Right now there are only three. 
     * */
    internal class GameData
    {
        // Instantiate the Managers
        private ItemManager _itemManager;
        private RoomManager _roomManager;
        private MainMenu _mainMenu;
        private PlayerData _playerData;

        public GameData()
        {
            _itemManager = new ItemManager();
            _roomManager = new RoomManager();
            _mainMenu = new MainMenu();
            _playerData = new PlayerData();
        }  
        
        public ItemManager ItemManager { get { return _itemManager; } }
        public RoomManager RoomManager { get { return _roomManager; } }
        public MainMenu MainMenu { get { return _mainMenu; } }
        public PlayerData PlayerData { get { return _playerData; } }
    }
}
