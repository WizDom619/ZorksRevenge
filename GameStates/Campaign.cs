namespace ZorksRevenge
{
    /// <summary>
    /// Access to Rooms is managed here.  
    /// Here you can Add, Search and Print. 
    /// </summary> 
    /// 
    public class Campaign : GameState
    {
        private InputParser _inputParser;
        private Command _command;

        private CommandEvent _commandEvent;

        public Campaign()
        {
            GameData.Initialize();

            _inputParser = new InputParser();
            _command = new Command(Verb.Blank, "Game Instructions");
            _commandEvent = _command.GetEvent();
        }

        public override GameState? Update()
        {
            _command = _inputParser.Process(_response);

            _commandEvent = _command.GetEvent();

            _commandEvent.Process();

            if (_commandEvent is QuitEvent)
            {
                return new MainMenu();
            }
            else
            {
                return this;
            }
        }

        public override void Display()
        {
            ZorkPrinter.Print($"Last Command: ");
            ZorkPrinter.PrintLine($"{_command.Verb}, {_command.Noun}, {Player.Name}", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");

            _commandEvent.Display();
            ZorkPrinter.PrintLine("");
            
            GameData.FindRoomByID(Player.CurrentRoomID).Print();
        }

        
        public void Print()
        {
            foreach (Room room in GameData.Rooms)
            {
                room.Print();
            }
        }
    }
}