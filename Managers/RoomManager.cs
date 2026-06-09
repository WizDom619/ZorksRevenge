using ZorksRevenge.Managers.GameData;

namespace ZorksRevenge
{
    // Access anything relevant to rooms is managed here. 
    // Room data is in a separate class. 
    // Rooms are instantiated in another class and returned, keeps things cleaner. 
    internal class RoomManager
    {
        private WiringManager _wiringManager;

        private List<Room> _rooms;

        public RoomManager(WiringManager wiringManager)
        {
            _wiringManager = wiringManager;
            _wiringManager.OnActionSendRoomsToRoomManager += OnActionSendRoomsToRoomManager;
            _wiringManager.OnActionPutItemInRoom += OnActionPutItemInRoom;

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
        public void Print()
        {
            foreach(Room room in _rooms)
            {
                room.Print();
            }
        }        
    }
}
