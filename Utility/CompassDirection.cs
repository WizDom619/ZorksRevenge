namespace ZorksRevenge
{
    /// <summary>
    /// This Class is to define directions. 
    /// The directions will be used to ditermine which way the player moves from room to room.
    /// I could remove Opposite() to create impossible geometry...
    ///    You are in RoomA, you go North. 
    ///    You are in RoomB, you go South.
    ///    You are in RoomC (not back to roomA like expected). 
    /// TODO Clean this up, and in Rooms too. 
    /// </summary>

    internal class CompassDirection
    {
        private Direction _direction;

        public CompassDirection(Direction dir)
        {
            _direction = dir;
        }

        public Direction Opposite()
        {
            Direction dir = Direction.NULL;

            if (_direction == Direction.North) { dir = Direction.South; }
            if (_direction == Direction.South) { dir = Direction.North; }
            if (_direction == Direction.East) { dir = Direction.West; }
            if (_direction == Direction.West) { dir = Direction.East; }

            return dir;
        }

        public Direction Direction { get { return _direction; } }
    }
}
