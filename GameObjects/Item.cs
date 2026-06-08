using ZorksRevenge.Utilities;

namespace ZorksRevenge
{
    internal class Item
    {
        private string _name;
        private string _description;

        public Item(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public void ChangeName(string _new_name)
        {
            _name = _new_name;
        }
        public void Print()
        {
            ColourManager.Write($"{_name}: ", ConsoleColor.Cyan);
            ColourManager.WriteLine($"{_description}", ConsoleColor.DarkCyan);
        }        
        public string Name
        {
            get { return _name; }
        }
    }
}
