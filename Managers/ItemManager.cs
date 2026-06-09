using ZorksRevenge.Managers.GameData;

namespace ZorksRevenge
{
    // Access anything relevant to items is managed here. 
    // Item data is in a separate class. 
    // Items are instantiated in another class and returned, keeps things cleaner.  

    internal class ItemManager
    {
        private WiringManager _wiringManager;

        private List<Item> _items;

        public ItemManager(WiringManager wiringManager)
        {
            _wiringManager = wiringManager;
            _wiringManager.OnActionSendItemsToItemManager += OnActionSendItemsToItemManager;

            _items = new List<Item>();
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
        private void OnActionSendItemsToItemManager(List<Item> items)
        {
            foreach (Item item in items)
            {
                AddItem(item);
            }
        }
        public void Print()
        {
            foreach (Item item in _items)
            {
                item.Print();
            }
            Console.WriteLine("");
        }
    }    
}
