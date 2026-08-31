using ZorksRevenge.Utility;

namespace ZorksRevenge.CommandEvents
{
    public class MoveEvent : CommandEvent
    {
        private string _noun;
        private bool _didMove = false; 
        Direction _dir;

        public MoveEvent(string noun)
        {
            _noun = noun;
        }
        public override void Process()
        {
            _didMove = false;
            _dir = ConvertStringToDirection(_noun);

            if (_dir != Direction.NULL &&
                GameData.FindRoomByID(Player.CurrentRoomID).Exits[_dir] != "NULL")
            {
                _didMove = true;
                Player.MoveCount += 1;
                Player.CurrentRoomID = GameData.FindRoomByID(Player.CurrentRoomID).Exits[_dir];
            }
        }
        public override void Display()
        {
            if (_didMove)
            {
                ZorkPrinter.Print("You moved ");
                ZorkPrinter.Print($"{_dir}, ");
                ZorkPrinter.Print($"You are now in ");
                ZorkPrinter.PrintLine($"{GameData.FindRoomByID(Player.CurrentRoomID).Name}", ZorkPrinter.RoomColour);
            }
            else
            {
                ZorkPrinter.PrintLine("There are no Paths in that direction");
            }                
        }
        private Direction ConvertStringToDirection(String noun)
        {
            Direction dir = Direction.NULL;

            if (noun.ToUpper() == "NORTH") { dir = Direction.North; }
            if (noun.ToUpper() == "SOUTH") { dir = Direction.South; }
            if (noun.ToUpper() == "EAST") { dir = Direction.East; }
            if (noun.ToUpper() == "WEST") { dir = Direction.West; }

            return dir;
        }
    }
}
