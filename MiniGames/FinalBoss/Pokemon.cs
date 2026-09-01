using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames.FinalBoss
{
    public class Pokemon
    {
        private string Name { get; init; }
        private List<Move> Moves { get; init; } = new List<Move>();

        public Pokemon(string name) 
        {
            Name = name;
        }

        public void Action(int i)
        {
            ZorkPrinter.Print($"{Name} uses ");

            if (i == 0)
            {
                Moves[0].Action();
            }
            else
            {
                Moves[i - 1].Action();
            }

        }

        public Pokemon AddMove(Move move)
        {
            Moves.Add(move);
            return this;
        }
    }
}
