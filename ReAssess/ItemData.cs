using ZorksRevenge.GameObjects;

namespace ZorksRevenge.ReAssess.Managers.GameData
{
    // All data relevant to items is kept here. 
    // All item objects are instanciated here. 
    internal class ItemData
    {
        private List<Item> _items; 
        public ItemData()
        {
            _items = new List<Item>
            {
                new Item("Rock", "A small hard rock"),
                new Item("Skull", "Some poor soul that never escaped"),
                new Item("Pile of Dust", "Dirty and gross"),
                new Item("Ruby", "Sparkles in a blood red"),
                new Item("Pen", "A sharp BIC pen, nothing but the best")
            };
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
        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public void OnActionAddItem(string sentName, string sentDesc)
        {
            AddItem(new Item(sentName, sentDesc));            
        }
        public List<Item> Items
        {
            get { return _items; }
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
