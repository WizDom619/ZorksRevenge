using ZorksRevenge.ReAssess.Utilities;

namespace ZorksRevenge.GameObjects
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
            ColourPrinter.Write($"{_name}: ", ColourPrinter.ItemColour);
            ColourPrinter.WriteLine($"{_description}", ConsoleColor.Gray);
        }        
        public string Name
        {
            get { return _name; }
        }
    }
}
