using ZorksRevenge.Utilities;

namespace ZorksRevenge
{
    internal class Room
    {
        private string _name;
        private string _description;
        private bool _isPlayerHere;

        private Room? _northernRoom;
        private Room? _southernRoom;
        private Room? _easternRoom;
        private Room? _westernRoom;

        private List<Item> _items;

        //public event EventHandler<RoomAddItemEventArgs> on_item_added;

        public Room(string name, string description)
        {
            _name = name;
            _description = description;
            _isPlayerHere = false;

            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        } 
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
            ColourManager.Write($"{_name}: ", ConsoleColor.Yellow);
            Console.WriteLine($"{_description}");
            foreach (Item item in _items)
            {
                ColourManager.Write(" -", ConsoleColor.Cyan);
                item.Print();
            }
            if (_northernRoom != null) { Console.Write($"\n\tNorth of me is"); ColourManager.Write($" {_northernRoom.Name}", ConsoleColor.Yellow); }
            if (_southernRoom != null) { Console.Write($"\n\tSouth of me is"); ColourManager.Write($" {_southernRoom.Name}", ConsoleColor.Yellow); }
            if (_easternRoom != null) { Console.Write($"\n\tEast of me is"); ColourManager.Write($" {_easternRoom.Name}", ConsoleColor.Yellow); }
            if (_westernRoom != null) { Console.Write($"\n\tWest of me is"); ColourManager.Write($" {_westernRoom.Name}", ConsoleColor.Yellow); }

            Console.WriteLine("\n ");
        }
        public string Name { get { return _name; } }
        public bool IsPlayerHere
        {
            get { return _isPlayerHere; }
            set { _isPlayerHere = value; }
        }
    }
}
