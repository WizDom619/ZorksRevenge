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
            ColourManager.Write($"{_name}: ", ConsoleColor.Magenta);
            ColourManager.WriteLine($"{_description}", ConsoleColor.DarkMagenta);
            foreach (Item item in _items)
            {
                ColourManager.Write(" -", ConsoleColor.Cyan);
                item.Print();
            }
            /*if (_northernRoom != null) { result += $"\n\tNorth of me is {_northernRoom.Name}"; }
            if (_southernRoom != null) { result += $"\n\tSouth of me is {_southernRoom.Name}"; }
            if (_easternRoom != null) { result += $"\n\tEast of me is {_easternRoom.Name}"; }
            if (_westernRoom != null) { result += $"\n\tWest of me is {_westernRoom.Name}"; }*/

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
