namespace ZorksRevenge.Managers.GameData
{
    // All data relevant to items is kept here. 
    // All item objects are instanciated here. 
    internal class ItemData
    {
        public List<Item> InstantiateItemData()
        {
            return new List<Item>
            {
                new Item("Rock", "A small hard rock"),
                new Item("Skull", "Some poor soul that never escaped"),
                new Item("Pile of Dust", "Dirty and gross"),
                new Item("Ruby", "Sparkles in a blood red"),
                new Item("Pen", "A sharp BIC pen, nothing but the best")
            };
        }  
    }
}
