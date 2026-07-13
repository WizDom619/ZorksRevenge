namespace ZorksRevenge.GameStates.MenuItems
{
    internal class NewGame : GameState
    {
        public override void Display()
        {
            //TESTING
            Console.WriteLine("New Game");       
        }

        public override GameState? Update()
        {
            //TESTING
            return new Campaign();
        }
    }
}
