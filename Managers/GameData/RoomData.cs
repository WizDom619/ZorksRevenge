namespace ZorksRevenge.Managers.GameData
{
    // All data relevant to rooms is kept here. 
    // All room objects are instanciated here. 
    internal class RoomData
    {
        private List<Room> _rooms;
        public RoomData()
        {
            _rooms = new List<Room>
            {
                new Room("Entry", "This is where your journey begins"),
                new Room("Hallway", "You are in a long hallway"),
                new Room("Bedroom", "A room where you sleep")
            };
        }
        public Room FindRoom(string name)
        {
            Room return_room = new Room("Unknown Room", "Unknown Room");

            foreach (Room room in _rooms)
            {
                if (room.Name == name)
                {
                    return_room = room;
                }
            }
            return return_room;
        }
        public List<Room>Rooms
        {
            get { return _rooms; }
        }
    }
}
