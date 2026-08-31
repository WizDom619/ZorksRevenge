using ZorksRevenge.Utility;


namespace ZorksRevenge.MiniGames.FinalBoss
{
    public class Pokemon
    {
        private string _name;
        private List<Move> _moves = new List<Move>();

        public Pokemon(string name) 
        {
            _name = name;
        }

        public void Action(int i)
        {
            ZorkPrinter.Print($"{_name} uses ");

            if (i == 0)
            {
                _moves[0].Action();
            }
            else
            {
                _moves[i - 1].Action();
            }

        }

        public Pokemon AddMove(Move move)
        {
            _moves.Add(move);
            return this;
        }

        public string Name
        {
            get { return _name; }
        }

        public List<Move> Moves
        {
            get {  return _moves; }
        }
    }
}
