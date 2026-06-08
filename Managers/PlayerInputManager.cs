namespace ZorksRevenge.Managers
{
    internal class PlayerInputManager
    {
        private PlayerData _playerData;

        public PlayerInputManager(PlayerData playerData)
        {
            _playerData = playerData;

            Console.Clear();

            while (_playerData.IsPlaying)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine($" {_playerData.CurrentRoom.Name}");
                Console.WriteLine("***********************************************");


                string i = Console.ReadLine();
            }
        }
    }
}
