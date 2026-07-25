namespace ZorksRevenge.GameObjects
{
    /// <summary>
    /// Room is a GameObject that contains all the data relevant to an Room. 
    /// </summary>
    
    internal class Room
    {
        private string _name;
        private string _description;

        private Paths _paths;

        private List<Item> _items;
        private List<Container> _containers;
        private NPC _npc;


        public Room(string name, string description)
        {
            _name = name;
            _description = description;

            _paths = new Paths();

            _items = new List<Item>();
            _containers = new List<Container>();

            _npc = null;
        }

        // Adds and Item within the room. 
        public Room AddItem(Item item)
        {
            _items.Add(item);
            return this;
        }

        // Connects various rooms together. 
        public Room AddPath(Room room, Direction dir)
        {
            _paths.Add(room, dir);
            return this;
        }

        public Room AddNPC(NPC npc)
        {
            _npc = npc;
            return this;
        }

        public Room AddContainer(Container container)
        {
            _containers.Add(container);
            return this;
        }

        public void Print()
        {
            if (Items.Count != 0)
            {
                ZorkPrinter.PrintLine("Items: ");
                foreach (Item item in _items)
                {
                    if (item.Name == "Cake")
                    {
                        // Do Nothing
                    }
                    else 
                    {
                        ZorkPrinter.Print(" -", ZorkPrinter.ItemColour);
                        item.Print();
                    }
                    
                }
                Console.WriteLine("");
            }
            
            if (_containers.Count > 0) 
            {
                ZorkPrinter.PrintLine("Containers: ");
                foreach (Container container in _containers)
                {
                    ZorkPrinter.Print($" -{container.Name}");
                    if (container.Opened == true &&
                        container.Contents.Count != 0)
                    {
                        ZorkPrinter.PrintLine(" Item's: ");
                        container.Print();
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            
            if (_npc != null)
            { 
                NPC.Print();
                Console.WriteLine("");
            }

            ZorkPrinter.PrintLine("Pathways: ");
            _paths.Print();            
        }
        public string Name { get { return _name; } }
        public string Desc { get { return _description; } }
        public Paths Paths { get { return _paths; } }
        public List<Item> Items { get { return _items; } }
        public List<Container> Containers { get { return _containers; } }
        public NPC NPC { get { return _npc; } }
    }
}
