using ZorksRevenge.MiniGames.FinalBoss.Attributes;
using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames.FinalBoss
{
    public class Move
    {
        public string Name { get; init; }
        public string _description;

        public List<mAttribute> _attributes = new List<mAttribute>();

        public Move (string name, string description)
        {
            Name = name;
            _description = description;
        }

        public void Action()
        {
            ZorkPrinter.PrintLine($"{Name} {_description}");

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
    }
}
