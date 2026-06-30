using ZorksRevenge.GameObjects;

namespace ZorksRevenge
{
    internal class Paths
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

        public void AddPath(Room room, Direction dir)
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

        public void Print()
        {
            if (_north != null) { ZorkPrinter.Print($"\n -North of me is"); ZorkPrinter.Print($" {_north.Name}", ZorkPrinter.RoomColour); }
            if (_south != null) { ZorkPrinter.Print($"\n -South of me is"); ZorkPrinter.Print($" {_south.Name}", ZorkPrinter.RoomColour); }
            if (_east != null) { ZorkPrinter.Print($"\n -East of me is"); ZorkPrinter.Print($" {_east.Name}", ZorkPrinter.RoomColour); }
            if (_west != null) { ZorkPrinter.Print($"\n -West of me is"); ZorkPrinter.Print($" {_west.Name}", ZorkPrinter.RoomColour); }

        }
    }
}
