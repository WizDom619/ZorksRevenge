using ZorksRevenge.Data;
using ZorksRevenge.Input;

namespace ZorksRevenge.CommandEvents
{
    public abstract class CommandEvent
    {
        public abstract void Display(GameData gameData);
        public abstract void Process(GameData gameData);
    }
}
