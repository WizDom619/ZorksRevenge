using ZorksRevenge.Managers.GameData;
using ZorksRevenge.Utilities;

namespace ZorksRevenge.Managers
{
    internal class PlayerInputManager
    {
        private bool _isPlaying = true;

        public PlayerInputManager( )
        {
                       
        }

        public void Update()
        {
            

            while (_isPlaying)
            {
                Console.Clear();

                Console.WriteLine("****************************************************************************");
                //ColourPrinter.Write($"     {_playerData.GetCurrentRoom.Name}: ", ColourPrinter.RoomColour); 
                //Console.WriteLine(       $"{_playerData.GetCurrentRoom.Desc}");
                Console.WriteLine("****************************************************************************");



                string i = Console.ReadLine();
            }
        }
    }
}
