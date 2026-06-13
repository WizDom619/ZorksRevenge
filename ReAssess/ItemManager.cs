using ZorksRevenge.GameObjects;

namespace ZorksRevenge.ReAssess.Managers
{
    // Access anything relevant to items is managed here. 
    // Item data is in a separate class. 
    // Items are instantiated in another class and returned, keeps things cleaner.  

    internal class ItemManager
    {
        private EventManager _eventManager;

        private List<Item> _items;

        public ItemManager(EventManager eventManager)
        {
            _eventManager = eventManager;
            //_eventManager.OnActionSendItemsToItemManager += OnActionSendItemsToItemManager;

            _items = new List<Item>();
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
