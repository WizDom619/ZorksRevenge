using ZorksRevenge.GameObjects;

namespace ZorksRevenge
{
    /// <summary>
    /// Access to Rooms is managed here.  
    /// Here you can Add, Search and Print. 
    /// </summary> 
    /// 
    internal class RoomManager
    {
        private List<Room> _rooms;

        public RoomManager()
        {
            //_rooms = new RoomData().Instanciate();
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
            foreach (Room room in _rooms)
            {
                room.Print();
            }
        }
        public List<Room> Rooms
        {
            get { return _rooms; }
        }
    }
}