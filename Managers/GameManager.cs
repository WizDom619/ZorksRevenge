using System;

namespace ZorksRevenge
{
    // Here is where the game really begins. 
    // Right now is just creating all the game data which is in a separate class. 
    internal class GameManager
    {
        public GameData game_data;

        public GameManager()
        {
            game_data = new GameData();

            //TESTING it's are passed by reference by default. 
            Console.WriteLine(game_data.room_manager.To_String());
            Console.WriteLine(game_data.item_manager.To_String());

        }
    }    
}




