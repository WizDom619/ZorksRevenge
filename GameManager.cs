using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    /// <summary>
    /// The Game Manager that holds the main Game Loop. 
    /// </summary>
    
    public class GameManager
    {
        // Will process player's inputs
        private InputParser _inputParser;

        private bool isGameLooping = true;

        public void Update()
        {            
            // Read Player's Input.
            string input = Console.ReadLine();

            // Convert Input into a Command object. 
            Command inputCommand = _inputParser.Process(input);

            // Send Command to the Evetn Bus to Process. 
                        
        }
    }
}