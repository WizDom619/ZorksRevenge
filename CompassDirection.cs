using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge
{
    public enum Direction
    {
        North,
        South,
        East,
        West,
        NULL
    };

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
