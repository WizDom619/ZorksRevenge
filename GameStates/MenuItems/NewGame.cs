namespace ZorksRevenge.GameStates.MenuItems
{
    public class NewGame : GameState
    {
        public override GameState? Update()
        {
            SaveManager.NewGameData();
            Player.Name = _response;
            return new Campaign();
        }
        public override void Display()
        {
            Console.WriteLine("New Game, Press Enter your Name: \n");
        }
    }
}
