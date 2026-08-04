using static System.Net.Mime.MediaTypeNames;

namespace ZorksRevenge
{
    /// <summary>
    /// Room is a GameObject that contains all the data relevant to an Room. 
    /// </summary>
    
    public class Room
    {
        private string _id;
        private string _name;
        private string _description;

        private List<string> _gameObjectsIDs = new List<string>();
        private Dictionary<Direction, string> _exits = new Dictionary<Direction, string>();

        public Room ClearGameObjects()
        {
            _gameObjectsIDs.Clear();
            return this;
        }

        // Adds and Item within the room. 
        public Room AddGameObject(string gameObject)
        {
            _gameObjectsIDs.Add(gameObject);
            return this;
        }

        // Connects various rooms together. 
        public Room AddExit(Direction dir, string exit)
        {
            _exits.Add(dir, exit);
            return this;
        }

        public void Print()
        {
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.Print($"Location: ");
            ZorkPrinter.Print($"{GameData.FindRoomByID(Player.CurrentRoomID).Name}   ", ZorkPrinter.RoomColour);
            ZorkPrinter.PrintLine($"{GameData.FindRoomByID(Player.CurrentRoomID).Desc}");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            if (_gameObjectsIDs.Count == 0)
            {
                ZorkPrinter.PrintLine("Room is Empty");
            }
            else
            {
                bool noItems = true;

                ZorkPrinter.PrintLine("Items: ", ZorkPrinter.ItemColour);
                foreach (string id in GameObjectsIDs)
                {
                    GameObject go = GameData.FindGameObjectByID(id);

                    if (go is Item)
                    {
                        noItems = false;
                        if (go.ID == "777")
                        {
                            // Do Nothing
                        }
                        else
                        {
                            ZorkPrinter.Print(" ");
                            GameData.FindGameObjectByID(id).Print();
                        }
                    }
                }
                if (noItems)
                {
                    ZorkPrinter.PrintLine($" -Empty");
                }
                Console.WriteLine("");

                bool noContainers = true;
                ZorkPrinter.PrintLine("Containers: ");
                foreach (string id in GameObjectsIDs)
                {
                    GameObject go = GameData.FindGameObjectByID(id);

                    if (go is Container)
                    {
                        ZorkPrinter.Print(" ");
                        noContainers = false;
                        go.Print();                        
                    }
                }
                if (noContainers)
                {
                    ZorkPrinter.PrintLine($" -Empty");
                }

                bool noSphinxs = true;

                ZorkPrinter.PrintLine("Sphinx: ", ZorkPrinter.NPCColour);
                foreach (string id in GameObjectsIDs)
                {
                    GameObject go = GameData.FindGameObjectByID(id);

                    if (go is NPC npc)                  
                    {
                        if (npc.IsAlive)
                        {
                            noSphinxs = false;
                            ZorkPrinter.Print(" ");
                            GameData.FindGameObjectByID(id).Print();
                        }
                    }
                }  
                if (noSphinxs)
                {
                    ZorkPrinter.PrintLine($" -Empty");
                }
                Console.WriteLine("");

                ZorkPrinter.PrintLine("Paths: ");
                foreach (KeyValuePair<Direction, string> kvp in _exits)
                {
                    foreach (Room room in GameData.Rooms)
                    {
                        if (room.ID == kvp.Value)
                        {
                            if (kvp.Key == Direction.North &&
                                kvp.Value != "NULL")
                            {
                                ZorkPrinter.Print($" North: ");
                                ZorkPrinter.PrintLine($"{room.Name}", ZorkPrinter.RoomColour);
                            }
                            if (kvp.Key == Direction.South &&
                                kvp.Value != "NULL")
                            {
                                ZorkPrinter.Print(" South: ");
                                ZorkPrinter.PrintLine($"{room.Name}", ZorkPrinter.RoomColour);
                            }
                            if (kvp.Key == Direction.East &&
                                kvp.Value != "NULL")
                            {
                                ZorkPrinter.Print(" East: ");
                                ZorkPrinter.PrintLine($"{room.Name}", ZorkPrinter.RoomColour);
                            }
                            if (kvp.Key == Direction.West &&
                                kvp.Value != "NULL")
                            {
                                ZorkPrinter.Print(" West: ");
                                ZorkPrinter.PrintLine($"{room.Name}", ZorkPrinter.RoomColour);
                            }
                        }
                    }
                }
                Console.WriteLine("");
            }          
        }

        public void PrintTest()
        {
            Console.WriteLine("ID " + _id);
            Console.WriteLine("Name " + _name);
            Console.WriteLine("Desc " + _description);

            if (_gameObjectsIDs.Count > 0)
            {
                Console.WriteLine("GameObject Count = " + _gameObjectsIDs.Count);

                foreach(string GO in _gameObjectsIDs)
                {
                    Console.WriteLine("  - " + GameData.FindGameObjectByID(GO).Name);
                }
            }
            else
            {
                Console.WriteLine("GameObject Count = 0");
            }

            Console.WriteLine(_exits.Count);
            Console.WriteLine("-------------------");
        }


        public string ID 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string Desc 
        { 
            get { return _description; } 
            set { _description = value; } 
        }
        public List<string> GameObjectsIDs 
        { 
            get { return _gameObjectsIDs; } 
            set { _gameObjectsIDs = value; } 
        }
        public Dictionary<Direction, string> Exits 
        { 
            get { return _exits; } 
            set { _exits = value; } 
        }
    }
}
