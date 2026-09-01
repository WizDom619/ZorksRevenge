using ZorksRevenge.CommandEvents;
using ZorksRevenge.Data;
using ZorksRevenge.Input;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// Here is the Campaign, there is where the majority of the game will be played. 
    /// </summary> 
    /// 
    public class Campaign : GameState
    {
        private CommandEvent _commandEvent;

        public Campaign()
        {
            // When loaded a session of playing. 
            // The user will always be greeted with the game instructions. 
            _commandEvent = new Command(Verb.Help, "Game Instructions").GetEvent();
        }

        public override void Display(GameData gameData)
        {
            // Caching the references. 
            string verb = gameData.Command.Verb.ToString();
            string noun = gameData.Command.Noun;
            string name = gameData.Player.Name;
            Room currentRoom = gameData.FindRoomByID(gameData.Player.CurrentRoomID);

            // Print the last enter command. 
            // So the player knows what the computer thinks. 
            // Incase of mistakes / confusion 
            ZorkPrinter.Print($"Last Command: ");
            ZorkPrinter.PrintLine($"{verb}, {noun}, {name}", ZorkPrinter.PlayerColour);            

            // Print current rooms artwork. 
            currentRoom.PrintArt();

            // Display what action the player commanded to happen. 
            _commandEvent.Display(gameData);
            ZorkPrinter.PrintLine("");

            // Print current room's information. 
            currentRoom.PrintInfo();
        }

        public override void ReadInput(GameData gameData)
        {
            // Read player input and parse into a command. 
            string? input = Console.ReadLine();
            InputManager.ParseInput(gameData, input);            
        }

        public override void Process(GameData gameData)
        {
            // What kind of GetEvent() Object is it?
            _commandEvent = gameData.Command.GetEvent();

            _commandEvent.Process(gameData);
        }
    }
}