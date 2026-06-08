namespace ZorksRevenge
{
    // Access anything relevant to items is managed here. 
    // Item data is in a separate class. 
    // Items are instantiated in another class and returned, keeps things cleaner.  

    internal class ItemManager
    {
        private List<Item> _items;

        public ItemManager()
        {
            _items = new ItemData().InstantiateItemData(); 
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            _items.Remove(item);
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
        public void Print()
        {
            foreach (Item item in _items)
            {
                item.Print();
            }
        }
    }    
}
