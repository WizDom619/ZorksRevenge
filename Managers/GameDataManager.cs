using ZorksRevenge.Managers.GameData;

namespace ZorksRevenge.Managers
{
    /* Game Data holds all the managers classes. 
     * Right now there are only three. 
     * */
    internal class GameDataManager
    {
        // Instantiate the Managers
        private ItemManager _itemManager;
        private RoomManager _roomManager;
        private PlayerData _playerData;

        public GameDataManager()
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
