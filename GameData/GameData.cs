using ZorksRevenge.Managers;

namespace ZorksRevenge
{
    /* Game Data holds all the managers classes. 
     * Right now there are only three. 
     * */
    internal class GameData
    {
        // Instantiate the Managers
        public ItemManager item_manager{ get; private set; }
        public RoomManager room_manager {  get; private set; }
        public WiringManager wiring_manager{ get; private set; }

        public GameData()
        {
            item_manager = new ItemManager();
            room_manager = new RoomManager();
            wiring_manager = new WiringManager(this);
        }   
    }
}
