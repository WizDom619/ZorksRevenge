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
            ColourPrinter.Write($"{_name}: ", ConsoleColor.DarkYellow);
            Console.WriteLine($"{_description}");
            foreach (Item item in _items)
            {
                ColourPrinter.Write(" -", ColourPrinter.ItemColour);
                item.Print();
            }
            if (_northernRoom != null) { Console.Write($"\n -North of me is"); ColourPrinter.Write($" {_northernRoom.Name}", ColourPrinter.RoomColour); }
            if (_southernRoom != null) { Console.Write($"\n -South of me is"); ColourPrinter.Write($" {_southernRoom.Name}", ColourPrinter.RoomColour); }
            if (_easternRoom != null) { Console.Write($"\n -East of me is"); ColourPrinter.Write($" {_easternRoom.Name}", ColourPrinter.RoomColour); }
            if (_westernRoom != null) { Console.Write($"\n -West of me is"); ColourPrinter.Write($" {_westernRoom.Name}", ColourPrinter.RoomColour); }

            Console.WriteLine("");
            Console.WriteLine("");
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
