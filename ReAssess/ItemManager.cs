using ZorksRevenge.GameData;

namespace ZorksRevenge.ReAssess
{
    /// <summary>
    /// Access to Items is managed here.  
    /// Here you can Add, Remove, Change Name, Search and Print. 
    /// </summary>
    internal class ItemManager
    {
        // Items are instantiated in another class and returned, keeps things cleaner.
        private List<Item> _items;

        public ItemManager()
        {
            // The Item List is filled here. 
            _items = new ItemData().Instanciate();
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }
        public void ChangeItemName(string old_name, string new_name)
        {
            foreach (Item item in _items)
            {
                if (item.Name == old_name)
                {
                    item.ChangeName(new_name);
                }
            }
        }
        public Item FindItem(string name)
        {
            Item return_item = new Item("Unknown Item", "Unknown Desc");

            foreach (Item item in _items)
            {
                if (item.Name == name)
                {
                    return_item = item;
                }
            }
            return return_item;
        }
        public void Print()
        {
            foreach (Item item in _items)
            {
                item.Print();
            }
            Console.WriteLine("");
        }
        public List<Item> Items
        {
            get { return _items; }
        }
    }    
}
