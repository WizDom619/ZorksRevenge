using ZorksRevenge.GameObjects;

namespace ZorksRevenge
{
    internal class PlayerData
    {
        private string _name;
        private int _money = 0;
        private Room? _currentRoom;

        private List<Item> _inventory;

        public PlayerData()
        {
            _inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _inventory.Add(item);
        }

        public void PrintInventory()
        {
            if (_inventory != null)
            {
                foreach (Item item in _inventory)
                {
                    item.Print();
                }
            }
        }

        public Room? CurrentRoom
        {
            get { return _currentRoom; }
            set { _currentRoom = value; }
        }
        public List<Item> Inventory { get { return _inventory; } }
        public int Money { get { return _money; } set { _money = value; } }
    }    
}
