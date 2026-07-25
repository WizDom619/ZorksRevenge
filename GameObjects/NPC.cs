using ZorksRevenge.MiniGames;

namespace ZorksRevenge.GameObjects
{
    internal class NPC
    {
        // NPC's name is used to search and identify. 
        protected string _name;
        protected string _instructions;
        protected bool _isAlive = true;
        private bool _isHappy = false;
        private MiniGame _miniGame;
        private Item _prize;

        private Dictionary<string, bool> _wants = new Dictionary<string, bool>();

        public NPC(string name)
        {
            _name = name;
        }

        public NPC AddWant(string want)
        {
            _wants.Add(want, false);
            return this;
        }

        public bool Play()
        {
            return _miniGame.Play();
        }
        public NPC AddInstructions(string instructions)
        {
            _instructions = instructions;
            return this;
        }
        public NPC AddMiniGame(MiniGame minigame)
        {
            _miniGame = minigame;
            return this;
        }
        public NPC AddPrize(Item prize)
        {
            _prize = prize;
            return this;
        }

        public void Print()
        {
            if (_isAlive != true)
            {
                return;
            }
            ZorkPrinter.PrintLine("Sphinx:");
            ZorkPrinter.PrintLine($" -{_name} ", ZorkPrinter.NPCColour);
        }

       
        public string Name
            { get { return _name; } }
        public string Instructions
            { get { return _instructions; } }
        public Dictionary<string, bool> Wants
        { get { return _wants; } }
        public bool IsAlive
        { get { return _isAlive; } set { _isAlive = value; } }
        public bool IsHappy
        { get { return _isHappy; } set { _isHappy = value; } }
        public MiniGame MiniGame
        { get { return _miniGame; } }
        public Item Prize
        { get { return _prize; } }


    }
}
