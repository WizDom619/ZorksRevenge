using ZorksRevenge.FileIO;
using ZorksRevenge.GameObjects;
using ZorksRevenge.GameStates;
using ZorksRevenge.Input;

namespace ZorksRevenge.Data
{
    /// <summary>
    /// Here is where all the Game Data is Instantiated.
    /// Including Rooms, Items, Room Connections. 
    /// </summary>
    public class GameData
    {
        // Set properties and default values. 
        public GameState? State { get; set; } = new MainMenu();
        // Command holds the input when in the games campaign
        public Command? Command { get; set; } = null;
        // Input holds the input for all other game states (mainly menu states) 
        public string Input { get; set; } = "-1";
        // Holds all the player's data in a single object
        public Player? Player { get; set; } = new Player();

        // Game World data
        public List<Room>? Rooms { get; set; } = new List<Room>();
        public List<Item>? Items { get; set; } = new List<Item>();
        public List<Container>? Containers { get; set; } = new List<Container>();
        public List<NPC>? Npcs { get; set; } = new List<NPC>();

        public void Init()
        {
            FileManager.LoadGameData();

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

        // Since rooms are chained linked you need a searching method to find things. 
        public Room FindRoomByID(string id)
        { 
            foreach (Room room in Rooms)
            {
                if (room.ID == id)
                {
                    return room;
                }
            }

            return new Room();
        }
        public Room FindRoomByName(string name)
        {
            foreach (Room room in Rooms)
            {
                if (room.Name.ToUpper() == name.ToUpper())
                {
                    return room;
                }
            }

            return new Room();
        }
        public GameObject? FindGameObjectByID(string id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            foreach (Container container in Containers)
            {
                if (container.ID == id)
                {
                    return container;
                }
            }

            foreach (NPC npc in Npcs)
            {
                if (npc.ID == id)
                {
                    return npc;
                }
            }

            return new GameObject();
        }
        public GameObject? FindGameObjectByName(string name)
        {
            foreach (Item item in Items)
            {
                if (item.Name.ToUpper() == name.ToUpper())
                {
                    return item;
                }
            }

            foreach (Container container in Containers)
            {
                if (container.Name.ToUpper() == name.ToUpper())
                {
                    return container;
                }
            }

            foreach (NPC npc in Npcs)
            {
                if (npc.Name.ToUpper() == name.ToUpper())
                {
                    return npc;
                }
            }

            return new GameObject();
        }
    }
}
