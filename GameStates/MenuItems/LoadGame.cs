namespace ZorksRevenge.GameStates.MenuItems 
{
    internal class LoadGame : GameState
    {
        public override void Display()
        {
            //TESTING
            Console.WriteLine("Load Game");
        }

        public override GameState? Update()
        {
            //TESTING
            return new MainMenu();
        }
    }
}
