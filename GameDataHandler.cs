using ZorksRevenge.GameObjects;

namespace ZorksRevenge
{
    /// <summary>
    /// Access to Rooms is managed here.  
    /// Here you can Add, Search and Print. 
    /// </summary> 
    /// 
    internal class GameDataHandler
    {
        private List<Room> _gameWorld;

        private Room _currentRoom;

        public GameDataHandler()
        {
            _gameWorld = new GameData().InstanciateWorld();
            _currentRoom = _gameWorld.Find(r => r.Name == "Entry");

        }

        public void Display()
        {
            Console.WriteLine("You are in... ");
            _currentRoom.Print();
            ZorkPrinter.Print(":> ");

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