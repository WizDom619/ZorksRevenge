namespace ZorksRevenge.GameObjects
{
    /// <summary>
    /// Item is a GameObject that contains all the data relevant to an item. 
    /// </summary>
   
    internal class Item
    {
        // Item's name is used to search and identify. 
        private string _name;
        // Used as flavour text for world building. 
        private string _description;

        public Item(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public void Print()
        {
            ZorkPrinter.Print($"{_name}: ", ZorkPrinter.ItemColour);
            ZorkPrinter.PrintLine($"{_description}");
        }
        public string Name
        {
            get { return _name; }
        }
    }
}