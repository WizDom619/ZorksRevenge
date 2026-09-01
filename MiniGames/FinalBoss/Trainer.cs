namespace ZorksRevenge.MiniGames.FinalBoss
{
    public class Trainer
    {
        private string _name;
        private int _current = 0;

        private List<Pokemon> _pokemons = new List<Pokemon>();

        public Trainer (string name)
        {
            _name = name;
        }

        public Trainer AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon); 
            
            return this;
        }

        public string Name
        {
            get { return _name; }
        }

        public Pokemon GetNextPokemon()
        {
            _current++;

            if (_current >= _pokemons.Count)
            {
                _current = 0;
            }

            if (_current == 0)
            {
                return _pokemons[0];
            }
            else
            {
                return _pokemons[_current - 1];
            }
        }

        public Pokemon CurPokemon
        {
            get { return _pokemons[_current];  }
        }
    }
}
