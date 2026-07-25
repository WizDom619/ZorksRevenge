using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.GameObjects
{
    internal class Container
    {
        private bool _opened = false;
        private string _name;

        private List<Item> _contents;

        public Container(string name)
        {
            _name = name;
            _contents = new List<Item>();
        }

        public Container AddItem(Item item)
        {
            _contents.Add(item);
            return this;
        }
        public Container AddName(string name)
        {
            _name = name;
            return this;
        }

        public void Print()
        {
            foreach (Item item in _contents)
            {
                ZorkPrinter.Print("  -", ZorkPrinter.ItemColour);
                item.Print();
            }
        }


        public bool Opened { get { return _opened; } set { _opened = value; } }

        public string Name { get { return _name; } }

        public List<Item> Contents { get { return _contents; } }
    }
}
