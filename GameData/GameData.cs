namespace ZorksRevenge
{
    /* Game Data holds all the managers classes. 
     * Right now there are only three. 
     * */
    internal class GameData
    {
        // Instantiate the Managers
        public ItemManager _itemManager;
        public RoomManager _roomManager;
        public WiringManager _wiringManager;

        public GameData()
        {
            _itemManager = new ItemManager();
            _roomManager = new RoomManager();
            _wiringManager = new WiringManager(this);
        }  
        
        public ItemManager ItemManager { get { return _itemManager; } }
        public RoomManager RoomManager { get { return _roomManager; } }
        public WiringManager WiringManager { get { return _wiringManager; } }
    }
}
