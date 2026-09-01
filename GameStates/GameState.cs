using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    /// <summary>
    /// Game games will be broken down into different states. 
    /// Such as...
    ///     - Main Menu
    ///     - New Game
    ///     - Campaign
    /// The game states will manage each states Display, Input and Process
    /// </summary> 
    public abstract class GameState
    {
        // Every game state will have a unique Display()
        // This method is responsible with everything drawn on the screen to the player
        public abstract void Display(GameData gameData);

        // The ReadInput method will apply to all game states other than Campaign
        // Campaign will override this method to generate Commands. 
        public virtual void ReadInput(GameData gameData)
        {
            // NULL will indicate that no input was received 
            // This should always's overwritten
            gameData.Input = "NULL";

            // This little Print() indicate to the player where they will be typing. 
            ZorkPrinter.Print(":> ");
            string? input = Console.ReadLine();

            // Validates input incase the player enters NULL
            if (input != null)
            {
                gameData.Input = input;
            }
            else
            {
                gameData.Input = "";
            }
        }
        // Every game state will have a unique Process()
        // Thus method is responsible for all updating the system behind the scenes. 
        public abstract void Process(GameData gameData);

        // Press Any Key() will be used when not explicit input is needed to progress (How to Play Menu).
        protected void PressAnyKey()
        {
            ZorkPrinter.PrintLine(" *Press Any Key*");

            // Simply pause the game until a key is pressed. 
            Console.ReadLine();
        }
    }
}