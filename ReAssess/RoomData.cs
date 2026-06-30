namespace ZorksRevenge.ReAssess
{
    /// <summary>
    /// All Room objects are instanciated here. 
    /// The intention is have a clean list of all the Game Rooms. 
    /// Room data can be easily changed here. 
    /// </summary>
    internal class RoomData
    {
        public List<Room> Instanciate()
        {
            return new List<Room>
            {
                new Room("Entry", "This is where your journey begins"),
                new Room("Hallway", "You are in a long hallway"),
                new Room("Bedroom", "A room where you sleep")
            };
        }        
    }
}
