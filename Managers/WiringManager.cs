using ZorksRevenge.Managers;
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
        private ItemManager _itemManager;
        private RoomManager _roomManager;
        private MainMenuManager _mainMenu;
        private PlayerData _playerData;
        public WiringManager(GameManager gameManager) 
        {
            // Start New Game
            

            _itemManager = gameManager.GameData.ItemManager;
            _roomManager = gameManager.GameData.RoomManager;
            _mainMenu = gameManager.MainMenuManager;
            _playerData = gameManager.GameData.PlayerData;

            //_playerData.SetPlayerRoom(_roomManager.FindRoom("Entry"));

            _mainMenu.OnNewGame += OnStartNewGame;

            // Put the objects locations
            PutAllItemsInAllRooms();
            // Set which rooms know about each other. 
            ConnectAllRooms();


            
        }
        //Could remove the slipt of the two methods and just have the one. 
        private void PutAllItemsInAllRooms()
        {
            PutItemInRoom("Rock", "Entry");
            PutItemInRoom("Skull", "Entry");
            PutItemInRoom("Pile of Dust", "Hallway");
            PutItemInRoom("Ruby", "Bedroom");
            PutItemInRoom("Pen", "Bedroom");
        }
        // Not mergeed with Put_All_Items_In_All_Rooms()
        // This allows for easy parameter safety checks. 
        private void PutItemInRoom(string item_name, string room_name)
        {
            if (_roomManager.FindRoom(room_name).Name == "Unknown Room")
            {
                Console.WriteLine($"ERROR: Invalid Room Name {room_name}");
                return;
            }
            else if (_itemManager.FindItem(item_name).Name == "Unknown Item")
            {
                Console.WriteLine($"ERROR: Invalid Item Name {item_name}");
                return;
            }

            // Assign an item to sit inside a room. 
            _roomManager.FindRoom(room_name).AddItem(_itemManager.FindItem(item_name));
        }
        private void ConnectAllRooms()
        {
            ConnectRoom("Entry", new CompassDirection(Direction.North), "Hallway");
            ConnectRoom("Hallway", new CompassDirection(Direction.East), "Bedroom");
        }
        private void ConnectRoom(string room1, CompassDirection dir, string room2) 
        {
            if (_roomManager.FindRoom(room1).Name == "Unknown Room")
            {
                Console.WriteLine($"ERROR: Invalid Room Name {room1}");
                return;
            }
            else if (_roomManager.FindRoom(room2).Name == "Unknown Item")
            {
                Console.WriteLine($"ERROR: Invalid Item Name {room2}");
                return;
            }

            _roomManager.FindRoom(room1).SetConnectedRoom(_roomManager.FindRoom(room2), dir.Direction);
            _roomManager.FindRoom(room2).SetConnectedRoom(_roomManager.FindRoom(room1), dir.Opposite());            
        }

        /// <summary>
        /// Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStartNewGame(object sender, EventArgs e)
        {
            _playerData.SetPlayerRoom(_roomManager.FindRoom("Entry"));

        }
    }
}
