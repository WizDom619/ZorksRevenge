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
        public override string ToString()
        {
            return $"{_name}: {_description}";
        }        
        public string Name
        {
            get { return _name; }
        }
    }
}
