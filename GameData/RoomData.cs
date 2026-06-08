namespace ZorksRevenge
{
    // All data relevant to rooms is kept here. 
    // All room objects are instanciated here. 
    internal class RoomData
    {
        public List<Room> InstantiateRoomData()
        {
            return new List<Room>
            {
                new Room("Entry", "This is where you start"),
                new Room("Hallway", "You are in a long hallway"),
                new Room("Bedroom", "A room where you sleep")
            };

        }
    }
}
