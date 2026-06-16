using ZorksRevenge.Parser;
using ZorksRevenge.Utilities;

namespace ZorksRevenge
{
    /// <summary>
    /// The Game Manager that holds the main Game Loop. 
    /// </summary>
    internal class GameManager
    {
        // Will process player's inputs
        private InputParser _inputParser;

        private bool isGameLooping = true;

        public GameManager()
        {
            _inputParser = new InputParser();
        }

        public void Update()
        {
            //Game Loop...	
            while (isGameLooping)
            {
                //Console.Write("> ");

                //TESTING
                _inputParser.Process("look Take  Ruby");
                _inputParser.Process("Take the Ruby");
                _inputParser.Process("Take the shiNEY Ruby");
                _inputParser.Process("Take the wooden spoon becasue it's my favoute thing");
                _inputParser.Process("Move North");
                _inputParser.Process("Look ");
                _inputParser.Process("Drop Rock");

                string input = Console.ReadLine();
                //Command output = _inputParser.Process(input);
                //TODO Send Command to Event Bus
            }
        }
    }    
}




