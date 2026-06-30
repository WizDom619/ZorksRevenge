using ZorksRevenge.Managers;
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

        private ItemManager _itemManager;
        private RoomManager _roomManager; 

        private bool isGameLooping = true;

        public GameManager()
        {
            _inputParser = new InputParser();

            _itemManager = new ItemManager();
            _roomManager = new RoomManager();
        }

        public void Update()
        {
            //Game Loop...	
            while (isGameLooping)
            {
                //TESTING
                //EventBus.Process(_inputParser.Process("look Take  Ruby"));
                //EventBus.Process(_inputParser.Process("Take the Ruby"));
                //EventBus.Process(_inputParser.Process("Take the shiNEY Ruby"));
                //EventBus.Process(_inputParser.Process("Take the wooden spoon becasue it's my TOWARDS favoute TOWARDS thing"));
                //EventBus.Process(_inputParser.Process("Move North"));
                EventBus.Dispatch(_inputParser.Process("Look "));
                //EventBus.Process(_inputParser.Process("Drop Rock"));

                /*
                // Read Player's Input.
                string input = Console.ReadLine();
                // Convert Input into a Command object. 
                Command inputCommand = _inputParser.Process(input);
                // Send Command to the Evetn Bus to Process. 
                EventBus.Dispatch(inputCommand);
                */

                //TESTING
                Console.ReadLine();
            }
        }
    }    
}




