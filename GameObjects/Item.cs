using System;

namespace ZorksRevenge
{
    internal class Item
    {
        private string name;
        private string description;

        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public void Change_Name(string new_name)
        {
            name = new_name;
        }
        public string To_String()
        {
            return $"{name}: {description}";
        }        
        public string Name
        {
            get { return name; }
        }
    }
}
