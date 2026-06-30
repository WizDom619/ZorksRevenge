using ZorksRevenge.ReAssess;

namespace ZorksRevenge.GameData
{
    /// <summary>
    /// All item objects are instanciated here. 
    /// The intention is have a clean list of all the Game Items. 
    /// Item data can be easily changed here. 
    /// </summary>
    internal class ItemData
    {
        public List<Item> Instanciate()
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
