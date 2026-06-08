namespace ZorksRevenge
{
    // Here is where the game really begins. 
    // Right now is just creating all the game data which is in a separate class. 
    internal class GameManager
    {
        public GameData _game_data;

        public GameManager()
        {
            _game_data = new GameData();

            //TESTING it's are passed by reference by default. 
            Console.WriteLine(_game_data.RoomManager.ToString());
            Console.WriteLine(_game_data.ItemManager.ToString());
        }
    }    
}




