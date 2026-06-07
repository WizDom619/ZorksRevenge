namespace ZorksRevenge
{
    /* Game Data holds all the managers classes. 
     * Right now there are only three. 
     * */
    internal class GameData
    {
        // Instantiate the Managers
        public ItemManager itemManager{ get; private set; }
        public RoomManager roomManager {  get; private set; }
        public WiringManager wiringManager{ get; private set; }

        public GameData()
        {
            itemManager = new ItemManager();
            roomManager = new RoomManager();
            wiringManager = new WiringManager(this);

        }   
    }
}
