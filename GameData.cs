using ZorksRevenge.GameObjects;
using ZorksRevenge.MiniGames;

namespace ZorksRevenge
{
    /// <summary>
    /// Here is where all the Game Data is Instanciated
    /// Including Rooms, Items, Room Connections. 
    /// </summary>
    internal class GameData
    {
        private List<Room> _rooms;

        public List<Room> InstanciateWorld()
        {
            // Create All Rooms 
            // And add Items to the Rooms. 
            _rooms = new List<Room>
            {
                new Room("Entry", "This is where your journey begins")
                .AddItem(new Item("Rock", "A small hard rock"))
                .AddItem(new Item("Skull", "Some poor soul that never escaped"))
                .AddNPC(new NPC()
                    .AddName("Bob")
                    .AddInstructions("Play my Game for a prize")
                    .AddMiniGame(new MiniGame())
                    .AddPrize(new Item("Gold", "shiney and yellow"))
                    ),

                new Room("Hallway", "You are in a long hallway")
                .AddItem(new Item("Pile of Dust", "Dirty and gross")),

                new Room("Bedroom", "A room where you sleep")
                .AddItem(new Item("Ruby", "Sparkles in a blood red"))
                .AddItem(new Item("Pen", "A sharp BIC pen, nothing but the best")),
            }; 

            // Set all paths between Rooms. 
            ConnectPaths(FindRoom("Entry"), Direction.North, FindRoom("Hallway"));
            ConnectPaths(FindRoom("Hallway"), Direction.East, FindRoom("Bedroom"));

            return _rooms;
        }

        // Since rooms are chained linked you need a searching method to find things. 
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

        private void ConnectPaths(Room room1, Direction dir, Room room2)
        {
            room1.AddPath(room2, dir);

            if      (dir == Direction.North) { dir = Direction.South; }
            else if (dir == Direction.South) { dir = Direction.North; }
            else if (dir == Direction.East) { dir = Direction.West; }
            else    { dir = Direction.East; }

            room2.AddPath(room1, dir);
        }
    }
}
