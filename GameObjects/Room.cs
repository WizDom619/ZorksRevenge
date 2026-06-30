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
        private List<NPC> _npcs;

        public Room(string name, string description)
        {
            _name = name;
            _description = description;

            _paths = new Paths();

            _items = new List<Item>();
        }
        // Adds and Item within the room. 
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        // Connects various rooms together. 
        public void AddPath(Room room, Direction dir)
        {
            _paths.AddPath(room, dir);
        }
        public void Print()
        {
            ZorkPrinter.Print($"{_name}:", ZorkPrinter.RoomColour);
            ZorkPrinter.PrintLine($"{_description}");
            foreach (Item item in _items)
            {
                ZorkPrinter.Print(" -", ZorkPrinter.ItemColour);
                item.Print();
            }
            
           _paths.Print();
            

            //ZorkPrinter.Print("");
            //ZorkPrinter.Print("");
        }
        public string Name { get { return _name; } }
        public string Desc { get { return _description; } }
    }
}
