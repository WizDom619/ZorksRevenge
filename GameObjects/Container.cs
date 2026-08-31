using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    public class Container : GameObject
    {
        private bool _opened;

        private List<string> _contents;

        public Container()
        {
        }

        public Container AddItem(string id)
        {
            Colour = ZorkPrinter.ContainerColour;
            _contents.Add(GameData.FindGameObjectByID(id).ID);
            return this;
        }

        public override void Print()
        {
            ZorkPrinter.PrintLine($"-{_name}", ZorkPrinter.ContainerColour);
            if (!isOpened)
            {
                ZorkPrinter.PrintLine("   Closed");
            }
            else if (_contents.Count == 0)
            {
                ZorkPrinter.PrintLine("   Empty");
            }
            else
            {
                foreach (string id in _contents)
                {
                    ZorkPrinter.Print("   ");
                    GameData.FindGameObjectByID(id).Print();
                }
            }
            
            ZorkPrinter.PrintLine("");
        }

        public bool isOpened 
        { 
            get { return _opened; } 
            set { _opened = value; } 
        }
        public List<string> ItemIDs 
        { 
            get { return _contents; }
            set { _contents = value; }
        }
    }
}
