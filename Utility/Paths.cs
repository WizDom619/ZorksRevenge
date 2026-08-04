namespace ZorksRevenge.Utility
{
    public class Paths
    {
        private Room? _north;
        private Room? _south;
        private Room? _east;
        private Room? _west;

        public Paths()
        {
            _north = null; 
            _south = null;
            _east = null;
            _west = null;
        }

        public void Add(Room room, Direction dir)
        {
            switch (dir)
            {
                case Direction.North:
                    _north = room;
                    break;

                case Direction.South:
                    _south = room;
                    break;

                case Direction.East:
                    _east = room;
                    break;

                case Direction.West:
                    _west = room;
                    break;
            }
        }

        public Room? GetRoom( Direction dir)
        {
            switch (dir)
            {
                case Direction.North:
                    return _north;

                case Direction.South:
                    return _south;

                case Direction.East:
                    return _east;

                case Direction.West:
                    return _west;
            }

            return null;
        }

        public void Print()
        {
            if (_north != null) { ZorkPrinter.Print($" -North of me is"); ZorkPrinter.Print($" {_north.Name}\n", ZorkPrinter.RoomColour); }
            if (_south != null) { ZorkPrinter.Print($" -South of me is"); ZorkPrinter.Print($" {_south.Name}\n", ZorkPrinter.RoomColour); }
            if (_east != null) { ZorkPrinter.Print($" -East of me is"); ZorkPrinter.Print($" {_east.Name}\n", ZorkPrinter.RoomColour); }
            if (_west != null) { ZorkPrinter.Print($" -West of me is"); ZorkPrinter.Print($" {_west.Name}\n", ZorkPrinter.RoomColour); }
        }
    }
}
