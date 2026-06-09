using ZorksRevenge.Managers.GameData;
using ZorksRevenge.Utilities;

namespace ZorksRevenge
{
    /* I;ve struggled with finding a way to have the managers to reference each other without being tightly coupled. 
     * The Wiring Manager is the soultion. 
     * This class is the only class tightly coupled with the other managers. 
     * It's job is to connect references such as what items are in what rooms. 
     * ... What rooms connect to each other. 
     * ... What manager subscribe to other managers events. ect...
     */
    internal class WiringManager
    {

        private ItemData _itemData;
        private RoomData _roomData;
        //private PlayerData _playerData;

        //private List<Item> _items;

        public event Action<List<Item>>? OnActionSendItemsToItemManager;
        public event Action<List<Room>>? OnActionSendRoomsToRoomManager;
        public event Action<Item,Room>? OnActionPutItemInRoom;

        public WiringManager() 
        {
            _itemData = new ItemData();
            _roomData = new RoomData();

            //Setup
            // Put the objects locations
            PutAllItemsInAllRooms();

            //_playerData.SetPlayerRoom(_roomManager.FindRoom("Entry"));

            //_mainMenu.OnNewGame += OnStartNewGame;

            
            // Set which rooms know about each other. 
            ConnectAllRooms();

            

        }
        public void Update()
        {
            OnActionSendItemsToItemManager?.Invoke(_itemData.Items);
            OnActionSendRoomsToRoomManager?.Invoke(_roomData.Rooms);
            PutAllItemsInAllRooms();
        }
        private void PutAllItemsInAllRooms()
        {
            PutItemInRoom("Rock", "Entry");
            PutItemInRoom("Skull", "Entry");
            PutItemInRoom("Pile of Dust", "Hallway");
            PutItemInRoom("Ruby", "Bedroom");
            PutItemInRoom("Pen", "Bedroom");
        }
        private void PutItemInRoom(string item_name, string room_name)
        {
            if (_roomData.FindRoom(room_name).Name == "Unknown Room")
            {
                Console.WriteLine($"ERROR: Invalid Room Name {room_name}");
                return;
            }
            else if (_itemData.FindItem(item_name).Name == "Unknown Item")
            {
                Console.WriteLine($"ERROR: Invalid Item Name {item_name}");
                return;
            }

            // Assign an item to sit inside a room. 
            OnActionPutItemInRoom?.Invoke(_itemData.FindItem(item_name), _roomData.FindRoom(room_name));
        }
        private void ConnectAllRooms()
        {
            //ConnectRoom("Entry", new CompassDirection(Direction.North), "Hallway");
            //ConnectRoom("Hallway", new CompassDirection(Direction.East), "Bedroom");
        }
        private void ConnectRoom(string room1, CompassDirection dir, string room2) 
        {
            /*if (_roomManager.FindRoom(room1).Name == "Unknown Room")
            {
                Console.WriteLine($"ERROR: Invalid Room Name {room1}");
                return;
            }
            else if (_roomManager.FindRoom(room2).Name == "Unknown Item")
            {
                Console.WriteLine($"ERROR: Invalid Item Name {room2}");
                return;
            }*/

            //_roomManager.FindRoom(room1).SetConnectedRoom(_roomManager.FindRoom(room2), dir.Direction);
            //_roomManager.FindRoom(room2).SetConnectedRoom(_roomManager.FindRoom(room1), dir.Opposite());            
        }

        /// <summary>
        /// Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStartNewGame(object sender, EventArgs e)
        {
            //_playerData.SetPlayerRoom(_roomManager.FindRoom("Entry"));

        }
    }
}
