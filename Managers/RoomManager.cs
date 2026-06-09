using ZorksRevenge.Managers.GameData;

namespace ZorksRevenge
{
    // Access anything relevant to rooms is managed here. 
    // Room data is in a separate class. 
    // Rooms are instantiated in another class and returned, keeps things cleaner. 
    internal class RoomManager
    {
        private List<Room> _rooms;

        public RoomManager()
        {
            _rooms = new RoomData().InstantiateRoomData();
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
        public void Print()
        {
            foreach(Room room in _rooms)
            {
                room.Print();
            }
        }        
    }
}
