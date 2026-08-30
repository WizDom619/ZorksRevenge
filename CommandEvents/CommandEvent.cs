namespace ZorksRevenge.CommandEvents
{
    public abstract class CommandEvent
    {
        public abstract void Process();
        public abstract void Display();
    }
}
