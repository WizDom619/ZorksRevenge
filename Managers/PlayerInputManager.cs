using ZorksRevenge.Managers.GameData;
using ZorksRevenge.Utilities;

namespace ZorksRevenge.Managers
{
    internal class PlayerInputManager
    {
        private PlayerData _playerData;

        public PlayerInputManager(PlayerData playerData)
        {
            _playerData = playerData;            
        }

        public void Update()
        {
            Console.Clear();

            while (_playerData.IsPlaying)
            {
                Console.WriteLine("****************************************************************************");
                ColourPrinter.Write($"     {_playerData.GetCurrentRoom.Name}: ", ColourPrinter.RoomColour); 
                Console.WriteLine(       $"{_playerData.GetCurrentRoom.Desc}");
                Console.WriteLine("****************************************************************************");

                string i = Console.ReadLine();
            }
        }
    }
}
