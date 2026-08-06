using System.Drawing;
using System.Security.Cryptography;
using System.Xml.Linq;
using ZorksRevenge.MiniGames;

namespace ZorksRevenge
{
    /// <summary>
    /// Here is where all the Game Data is Instanciated
    /// Including Rooms, Items, Room Connections. 
    /// </summary>
    public static class GameData
    {
        private static List<Room> _rooms { get; set; } 
        private static List<Item> _items { get; set; }
        private static List<Container> _containers { get; set; }
        private static List<NPC> _npcs { get; set; }

        public static void Initialize()
        {
            foreach (Room room in _rooms) 
            {
                room.ClearGameObjects();

                foreach (Item item in _items) 
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

                foreach (Container container in _containers)
                {
                    if (container.LocationID == room.ID)
                    {
                        room.AddGameObject(container.ID);
                    }
                }

                foreach (NPC npc in _npcs)
                {
                    if (npc.LocationID == room.ID)
                    {
                        room.AddGameObject(npc.ID);
                    }
                }
            }
        }

        // Since rooms are chained linked you need a searching method to find things. 
        public static Room FindRoomByID(string id)
        { 
            foreach (Room room in _rooms)
            {
                if (room.ID == id)
                {
                    return room;
                }
            }

            return new Room();
        }
        public static Room FindRoomByName(string name)
        {
            foreach (Room room in _rooms)
            {
                if (room.Name.ToUpper() == name.ToUpper())
                {
                    return room;
                }
            }

            return new Room();
        }
        public static GameObject? FindGameObjectByID(string id)
        {
            foreach (Item item in _items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            foreach (Container container in _containers)
            {
                if (container.ID == id)
                {
                    return container;
                }
            }

            foreach (NPC npc in _npcs)
            {
                if (npc.ID == id)
                {
                    return npc;
                }
            }

            return new GameObject();
        }
        public static GameObject? FindGameObjectByName(string name)
        {
            foreach (Item item in _items)
            {
                if (item.Name.ToUpper() == name.ToUpper())
                {
                    return item;
                }
            }

            foreach (Container container in _containers)
            {
                if (container.Name.ToUpper() == name.ToUpper())
                {
                    return container;
                }
            }

            foreach (NPC npc in _npcs)
            {
                if (npc.Name.ToUpper() == name.ToUpper())
                {
                    return npc;
                }
            }

            return new GameObject();
        }
        public static List<Room> Rooms { get { return _rooms; } set { _rooms = value; } }
        public static List<Item> Items { get { return _items; } set { _items = value; } }
        public static List<Container> Containers { get { return _containers; } set { _containers = value; } }
        public static List<NPC> NPCS { get { return _npcs; } set { _npcs = value; } }
    }
}
