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
