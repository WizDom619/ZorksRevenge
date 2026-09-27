using ZorksRevenge.GameObjects;
using ZorksRevenge.GameStates;
using ZorksRevenge.Input;
using ZorksRevenge.Utility;

namespace ZorksRevenge.Data
{
    /// <summary>
    /// Here is where all the Game Data is Instantiated.
    /// Including Rooms, Items, Room Connections. 
    /// </summary>
    public class GameData
    {
        // Hold the Player's Input
        public string Input { get; set; }

        // Input holds the input for all other game states (mainly menu states) 
        public GameState State { get; set; }

        // Holds all relevant data about the Player. 
        public PlayerData Player { get; set; }

        // Command holds the input when in the games campaign
        public Command Command { get; set; }

        // Game World data
        public List<Room> Rooms { get; set; }
        public List<Item> Items { get; set; }
        public List<Container> Containers { get; set; }
        public List<NPC> NPCs { get; set; }

        public GameData()
        {
            Player = new PlayerData();
            Command = new Command(Verb.NULL, GameConstants.NoInput);

            Rooms = new List<Room>();
            Items = new List<Item>();
            Containers = new List<Container>();
            NPCs = new List<NPC>();
        }
        
        public void Init()
        {
            //DOMTODO
            foreach (Room room in Rooms)
            {
                room.ClearGameObjects();

                foreach (Item item in Items) 
                {
                    if (item.LocationID == room.ID)
                    {
                        if (item.ID == "I001") { item.Colour = ConsoleColor.Yellow; }
                        if (item.ID == "I002") { item.Colour = ConsoleColor.Blue; }
                        if (item.ID == "I003") { item.Colour = ConsoleColor.Green; }
                        if (item.ID == "I004") { item.Colour = ConsoleColor.Cyan; }
                        if (item.ID == "I005") { item.Colour = ConsoleColor.Red; }
                        if (item.ID == "I006") { item.Colour = ConsoleColor.Magenta; }
                        if (item.ID == "I007") { item.Colour = ConsoleColor.White; }

                        if (item.ID == "I033") { item.Colour = ConsoleColor.DarkGreen; }
                        if (item.ID == "I034") { item.Colour = ConsoleColor.DarkRed; }
                        if (item.ID == "I035") { item.Colour = ConsoleColor.DarkBlue; }

                        room.AddGameObject(item.ID);
                        
                    }
                }

                foreach (Container container in Containers)
                {
                    if (container.LocationID == room.ID)
                    {
                        room.AddGameObject(container.ID);
                    }
                }

                foreach (NPC npc in Npcs)
                {
                    if (npc.LocationID == room.ID)
                    {
                        room.AddGameObject(npc.ID);
                    }
                }
            }
        }

        /// <summary>
        /// The following are searching methods to find Rooms and other GameObjects 
        /// Using Lambda Expressions the first ID or name match will be returned
        /// All IDs should be unique to their GameObject so you can do multiple list searches using the name ID without worrying for an incorrect match. 
        /// </summary>
        public Room? FindRoomByID(string id)
        {
            return Rooms.FirstOrDefault(n => n.ID == id);
        }
        public Room? FindRoomByName(string name)
        {
            return Rooms.FirstOrDefault(n => n.Name.ToUpper() == name.ToUpper());
        }
        public GameObject? FindGameObjectByID(string id)
        {
            GameObject gameObject;

            gameObject = Items.First(n => n.ID == id);
            gameObject = Containers.First(n => n.ID == id);
            gameObject = NPCs.First(n => n.ID == id);

            return gameObject;
        }
        public GameObject? FindGameObjectByName(string name)
        {
            GameObject gameObject;

            gameObject = Items.First(n => n.Name.ToUpper() == name.ToUpper());
            gameObject = Containers.First(n => n.Name.ToUpper() == name.ToUpper());
            gameObject = NPCs.First(n => n.Name.ToUpper() == name.ToUpper());

            return gameObject;
        }
    }
}
