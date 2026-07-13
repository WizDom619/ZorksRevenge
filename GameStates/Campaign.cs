using System.Text;
using ZorksRevenge.GameObjects;
using ZorksRevenge.Input;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// Access to Rooms is managed here.  
    /// Here you can Add, Search and Print. 
    /// </summary> 
    /// 
    internal class Campaign : GameState
    {
        private List<Room> _gameWorld;
        private PlayerData _playerData;
        private InputParser _inputParser;
        private Command _command;


        public Campaign()
        {
            _gameWorld = new GameData().InstanciateWorld();
            _playerData = new PlayerData
            {
                CurrentRoom = _gameWorld.Find(r => r.Name == "Entry")
            };

            _inputParser = new InputParser();
            _command = new Command(Verb.Blank, "");
        }

        public override void Display()
        {
            ZorkPrinter.PrintLine("-------------------------------------------------");
            ZorkPrinter.PrintLine($"Location: {_playerData.CurrentRoom.Name}", ZorkPrinter.RoomColour);
            ZorkPrinter.PrintLine($"    {_playerData.CurrentRoom.Desc}");
            ZorkPrinter.PrintLine("-------------------------------------------------");

            if (_command.Verb != Verb.Blank)
            {
                _command.Display(_playerData);
            }


            ZorkPrinter.PrintLine("");
        }

        public override GameState? Update()
        {
            _command = _inputParser.Process(_response);
            _command.Process(_gameWorld, _playerData);
            return this;
        }

        
        public void Print()
        {
            foreach (Room room in _gameWorld)
            {
                room.Print();
            }
        }
    }
}