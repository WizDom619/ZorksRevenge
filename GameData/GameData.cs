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
        private PlayerData _playerData;

        public GameData()
        {
            _itemManager = new ItemManager();
            _roomManager = new RoomManager();
            _playerData = new PlayerData();
        }  
        
        public ItemManager ItemManager { get { return _itemManager; } }
        public RoomManager RoomManager { get { return _roomManager; } }
        public PlayerData PlayerData { get { return _playerData; } }
    }
}
