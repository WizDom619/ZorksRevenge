using ZorksRevenge.Input;

namespace ZorksRevenge
{
    /// <summary>
    /// The Game Manager that holds the main Game Loop. 
    /// </summary>
    
    public class GameManager
    {
        // Will process player's inputs
        private InputParser _inputParser;

        private RoomManager _roomManager;

        private bool isGameLooping = true;

        public GameManager()
        {
            _roomManager = new RoomManager();
        }


        public void Update()
        {            
            // Read Player's Input.
            string input = Console.ReadLine();

            // Convert Input into a Command object. 
            Command inputCommand = _inputParser.Process(input);

            // Send Command to the Event Bus to Process. 
                        
        }
    }
}