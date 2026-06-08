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

        public void ActivatePlayerInputLoop()
        {
            Console.Clear();

            while (_playerData.IsPlaying)
            {
                Console.WriteLine("****************************************************************************");
                ColourPrinter.WriteLine($"     --{_playerData.GetCurrentRoom.Name}: {_playerData.GetCurrentRoom.Desc}--", ColourPrinter.RoomColour);
                Console.WriteLine("****************************************************************************");


                string i = Console.ReadLine();
            }
        }
    }
}
