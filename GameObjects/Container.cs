using ZorksRevenge.Main;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameObjects
{
    public class Container : GameObject
    {
        private bool isOpened { get; set; } 
        private List<string> ItemIDs { get; set; }

        public Container AddItem(string id)
        {
            Colour = ZorkPrinter.ContainerColour;
            ItemIDs.Add(id);
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
    }
}
