using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// Game games will be broken down into different states...
    ///     - Campaign
    ///     - How to Play
    ///     - Load Game
    ///     - Main Menu
    ///     - New Game
    ///     - Quit Game
    /// The game states will manage each states Display, Input and Process
    /// </summary> 
    public abstract class GameState
    {
        // Every game state will define their own Display(), Input() and Process()

        // This method is responsible for everything drawn on the screen to the player
        public abstract void Display(GameData gameData);

        // This method is responsible for recieving the player's input
        public abstract void Input(GameData gameData);

        // Thus method is responsible for all updating the systems behind the scenes. 
        public abstract void Process(GameData gameData);


        /// <summary>
        /// The defaultInput method will apply to most Game States
        /// Campaign will be the only one to instead use the InputParser and create Command Objects. 
        /// </summary>        
        protected void defaultInput(GameData gameData)
        {
            // NULL will indicate that no input was received 
            // This should always's overwritten
            gameData.Input = NOINPUT;

            // This little Print() indicate to the player where they will be typing. 
            ZorkPrinter.Print(":> ");
            string? input = Console.ReadLine();

            // Validates input incase the player enters NULL
            if (input != null)
            {
                gameData.Input = input;
            }
        }
        

        // Press Any Key() will be used when not explicit input is needed to progress (How to Play Menu).
        protected void PressAnyKey()
        {
            ZorkPrinter.PrintLine(" *Press Any Key*");

            // Simply pause the game until a key is pressed. 
            Console.ReadLine();
        }
    }
}