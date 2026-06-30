using ZorksRevenge.Utility; 

namespace ZorksRevenge
{
    /// <summary>
    /// Room is a GameObject that contains all the data relevant to an Room. 
    /// </summary>
    
    internal class Room
    {
        private string _name;
        private string _description;

        private Room? _northernRoom;
        private Room? _southernRoom;
        private Room? _easternRoom;
        private Room? _westernRoom;

        private List<Item> _items;

        public Room(string name, string description)
        {
            _name = name;
            _description = description;

            _items = new List<Item>();
        }
        // Adds and Item within the room. 
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        // Connects various rooms together. 
        public void SetConnectedRoom(Room room, Direction dir)
        {
            switch (dir)
            {
                case Direction.North:
                    _northernRoom = room;
                    break;

                case Direction.South:
                    _southernRoom = room;
                    break;

                case Direction.East:
                    _easternRoom = room;
                    break;

                case Direction.West:
                    _westernRoom = room;
                    break;
            }
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
            if (_northernRoom != null) { ZorkPrinter.Print($"\n -North of me is"); ZorkPrinter.Print($" {_northernRoom.Name}", ZorkPrinter.RoomColour); }
            if (_southernRoom != null) { ZorkPrinter.Print($"\n -South of me is"); ZorkPrinter.Print($" {_southernRoom.Name}", ZorkPrinter.RoomColour); }
            if (_easternRoom != null) { ZorkPrinter.Print($"\n -East of me is"); ZorkPrinter.Print($" {_easternRoom.Name}", ZorkPrinter.RoomColour); }
            if (_westernRoom != null) { ZorkPrinter.Print($"\n -West of me is"); ZorkPrinter.Print($" {_westernRoom.Name}", ZorkPrinter.RoomColour); }

            //ZorkPrinter.Print("");
            //ZorkPrinter.Print("");
        }
        public string Name { get { return _name; } }
        public string Desc { get { return _description; } }
        public bool IsPlayerHere
        {
            get { return _isPlayerHere; }
            set { _isPlayerHere = value; }
        }
    }
}
