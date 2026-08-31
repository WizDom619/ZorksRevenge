using System.Text.Json.Serialization;
using ZorksRevenge.MiniGames;
using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    public class NPC : GameObject
    {
        // NPC's name is used to search and identify. 
        private string _prize;

        protected bool _isAlive;
        private bool _isHappy;

        private MiniGame? _miniGame;
        private Dictionary<string, bool> _wants;

        public NPC()
        {
            _description = "A Great and Mighty Sphinx, Bring it an Offering and Play it's Game.";
            _colour = ZorkPrinter.NPCColour;

            
        }
        public bool Play()
        {
            if (_id == "S001") { _miniGame = new GuessNumber(); }
            if (_id == "S002") { _miniGame = new RockPaperScissors(); }
            if (_id == "S003") { _miniGame = new Hangman(); }
            if (_id == "S004") { _miniGame = new MathQuiz(); }
            if (_id == "S005") { _miniGame = new WordSearch(); }
            if (_id == "S006") { _miniGame = new Cipher(); }
            if (_id == "S007") { _miniGame = new Quiz(); }
            if (_id == "S008") { _miniGame = new FinalBoss(); }

            return _miniGame.Play();
        }
        public NPC AddPrize(string prize)
        {
            _prize = prize;
            return this;
        }
        public NPC AddWant(string want)
        {
            _wants.Add(want, false);
            return this;
        }       
        public NPC AddMiniGame(MiniGame minigame)
        {
            _miniGame = minigame;
            return this;
        }
        public override void Print()
        {
            if (_isAlive)
            {
                ZorkPrinter.PrintLine($"-{_name} ", ZorkPrinter.NPCColour);
            }
        }
        public void TestPrint()
        {
            Console.WriteLine("ID " + _id);
            Console.WriteLine("Location ID " + _locationID);
            Console.WriteLine("Name " + _name);
            Console.WriteLine("Description " + _description);
            Console.WriteLine("Colour " + _colour.ToString());
            Console.WriteLine("Prize ID " + _prize);
            Console.WriteLine("Is Alive " + _isAlive);
            Console.WriteLine("Is Happy " + _isHappy);
            Console.WriteLine("MiniGame " + _miniGame.ToString()); 

            foreach (KeyValuePair<string, bool> kvp in _wants)
            {
                Console.WriteLine("Want ID " + kvp.Key);
                Console.WriteLine("Want Has " + kvp.Value);
            }
            Console.WriteLine("------------------------------------\n");
        }

        public string PrizeID 
        { 
            get { return _prize; }
            set { _prize = value; }
        }
        public bool IsAlive 
        { 
            get { return _isAlive; } 
            set { _isAlive = value; } 
        }
        public bool IsHappy 
        { 
            get { return _isHappy; } 
            set { _isHappy = value; } 
        }
        [JsonIgnore]
        public MiniGame? MiniGame 
        { 
            get { return _miniGame; } 
            set { _miniGame = value; }
        }
        public Dictionary<string, bool> Wants 
        { 
            get { return _wants; } 
            set { _wants = value; }
        }
    }
}
