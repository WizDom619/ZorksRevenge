using ZorksRevenge.Data;
using ZorksRevenge.GameStates;

namespace ZorksRevenge.CommandEvents
{
    internal class QuitEvent : CommandEvent
    {
        public override void Process(GameData gameData)
        {
            gameData.State = new MainMenu();
        }

        public override void Display(GameData gameData)
        {
        }
    }
}
