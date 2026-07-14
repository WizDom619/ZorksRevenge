using ZorksRevenge.MiniGames;

namespace ZorksRevenge.GameObjects
{
    internal class NPC
    {
        // NPC's name is used to search and identify. 
        private string _name;

        private string _instructions;

        private MiniGame _miniGame;

        private Item _prize;

        public NPC()
        {

        }
        public void Print()
        {
            ZorkPrinter.PrintLine("Sphinx:");
            ZorkPrinter.PrintLine($" -{_name} ", ZorkPrinter.NPCColour);
        }

        public NPC AddName(string name)
        {
            _name = name;
            return this;
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
        public string Name
        {
            get { return _name; }
        }
        public string Instructions
        {
            get { return _instructions; }
        }
        public MiniGame MiniGame
        {
            get { return _miniGame; }
        }
        public Item Prize
        {
            get { return _prize; }
        }
    }
}
