using ZorksRevenge.MiniGames.FinalBoss.Attributes;
using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    public class Move
    {
        private string _name;
        private string _description;
        private List<mAttribute> _attributes = new List<mAttribute>();

        public Move (string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Action()
        {
            ZorkPrinter.PrintLine($"{_name} {_description}");

            foreach(mAttribute mA in _attributes)
            {
                mA.Action();
            }
        }

        public Move AddAttributes (mAttribute mA)
        {
            _attributes.Add(mA);
            return this;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
