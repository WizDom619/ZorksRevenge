using ZorksRevenge.GameObjects;
using ZorksRevenge.ReAssess.Utilities;

namespace ZorksRevenge.ReAssess.Managers
{
    // Access anything relevant to rooms is managed here. 
    // Room data is in a separate class. 
    // Rooms are instantiated in another class and returned, keeps things cleaner. 
    internal class RoomManager
    {
        private EventManager _eventManager;

        private List<Room> _rooms;

        public RoomManager(EventManager eventManager)
        {
            _eventManager = eventManager;
            _eventManager.OnActionSendRoomsToRoomManager += OnActionSendRoomsToRoomManager;
            _eventManager.OnActionPutItemInRoom += OnActionPutItemInRoom;
            _eventManager.OnActionConnectRoom += OnActionConnectRoom;

            _rooms = new List<Room>();

        }
        public Room FindRoom(string name)
        {
            Room return_room = new Room("Unkown Room", "Unknown Desc");

            foreach (Room room in _rooms)
            {
                if (room.Name == name)
                {
                    return_room = room;
                }
            }
            return return_room;
        }
        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        private void OnActionSendRoomsToRoomManager(List<Room> rooms)
        {
            foreach(Room room in rooms)
            {
                AddRoom(room);
            }
        }
        private void OnActionPutItemInRoom(Item item, Room room)
        {
            room.AddItem(item);
        }
        private void OnActionConnectRoom(Room room1, Direction dir, Room room2)
        {
            room1.SetConnectedRoom(room2, dir);
        }
        public void Print()
        {
            foreach(Room room in _rooms)
            {
                room.Print();
            }
        }        
    }
}
