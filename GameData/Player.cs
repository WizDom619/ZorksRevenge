using ZorksRevenge.GameObjects;
using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    public static class Player
    {
        private static string _name;
        private static string _currentRoomID;
        private static int _moveCount;
        private static bool _didBeatGame;

        private static List<string> _inventory = new List<string>();

        public static void AddItem(string id)
        {
            _inventory.Add(id);
        }

        public static void PrintInventory()
        {
            ZorkPrinter.PrintLine("Inventory: ");
            if (_inventory.Count != 0)
            {
                foreach (string id in _inventory)
                {
                    if (GameData.FindGameObjectByID(id) is Item item)
                    {
                        if (item.ID == "I001") { item.Colour = ConsoleColor.Yellow; }
                        if (item.ID == "I002") { item.Colour = ConsoleColor.Blue; }
                        if (item.ID == "I003") { item.Colour = ConsoleColor.Green; }
                        if (item.ID == "I004") { item.Colour = ConsoleColor.Cyan; }
                        if (item.ID == "I005") { item.Colour = ConsoleColor.Red; }
                        if (item.ID == "I006") { item.Colour = ConsoleColor.Magenta; }
                        if (item.ID == "I007") { item.Colour = ConsoleColor.White; }

                        if (item.ID == "I033") { item.Colour = ConsoleColor.DarkGreen; }
                        if (item.ID == "I034") { item.Colour = ConsoleColor.DarkRed; }
                        if (item.ID == "I035") { item.Colour = ConsoleColor.DarkBlue; }

                        ZorkPrinter.Print($" -{item.Name}: ", item.Colour);
                        ZorkPrinter.PrintLine($"{item.Desc}");
                    }
                }
            }
            else
            {
                ZorkPrinter.PrintLine(" -Empty");
            }
        }
        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static string CurrentRoomID
        {
            get { return _currentRoomID; }
            set { _currentRoomID = value; }
        }
        public static int MoveCount
        {
            get { return _moveCount; }
            set { _moveCount = value; }
        }
        public static bool DidBeatGame
        {
            get { return _didBeatGame; }
            set { _didBeatGame = value; }
        }
        public static List<string> Inventory 
        { 
            get { return _inventory; } 
            set { _inventory = value; }
        }
    }    
}
