namespace ZorksRevenge
{
    internal class Room
    {
        private string _name;
        private string _description;
        private bool _isPlayerHere;

        private Room _northern_room;
        private Room _southern_room;
        private Room _eastern_room;
        private Room _western_room;

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
        public void SetConnectedRoom(Room room, CompasDirection.Direction dir)
        {
            switch (dir)
            {
                case CompasDirection.Direction.North:
                    _northern_room = room;
                    break;

                case CompasDirection.Direction.South:
                    _southern_room = room;
                    break;

                case CompasDirection.Direction.East:
                    _eastern_room = room;
                    break;

                case CompasDirection.Direction.West:
                    _western_room = room;
                    break;
            }
        }
        public string To_String()
        {
            string result = "";

            result += $"{name}: {description}\n";
            foreach (Item item in items)
            {
                result += $"\t{item.To_String()} \n";
            }
            if (northern_room != null) { result += $"\n\tNorth of me is {northern_room.name}"; }
            if (southern_room != null) { result += $"\n\tSouth of me is {southern_room.name}"; }
            if (eastern_room != null) { result += $"\n\tEast of me is {eastern_room.name}"; }
            if (western_room != null) { result += $"\n\tWest of me is {western_room.name}"; }

            result += $"\n ";

            return result;
        }
        public bool Is_Player_Here
        {
            get { return is_player_here; }
            set { is_player_here = value; }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
