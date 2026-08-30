using ZorksRevenge.Save;

namespace ZorksRevenge.GameStates 
{
    public class LoadGame : GameState
    {
        public override GameState? Update()
        {
            SaveManager.LoadGameData();
            return new Campaign();
        }
        public override void Display()
        {
            //TESTING
            Console.WriteLine("Load Game");
        }
    }
}
