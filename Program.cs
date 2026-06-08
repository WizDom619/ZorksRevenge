using System.Drawing;
using ZorksRevenge.Utilities;

namespace ZorksRevenge
{
    /* The Main Program.
     * Everything starts here. 
     * It's only purpose is to begin the my game. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Colour.TEST_PrintAllColours();
            //ZorksRevengeMain _zrMain = new ZorksRevengeMain();

            //TESTING 2
            ColourManager.TEST_PrintAllColours();
            //ColourManager.Flicker("A torch flickers on the wall...");

            //GameManager _game_manager = new GameManager();

            GameData _gameData = new GameData();

            _gameData.RoomManager.Print();
            _gameData.ItemManager.Print();

        }
    }
}
