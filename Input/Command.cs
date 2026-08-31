using ZorksRevenge.CommandEvents;
using ZorksRevenge.Utility;

namespace ZorksRevenge.Input
{
    /// <summary>
    /// A Command will contain a Verb and a Noun.
    /// This holds the player's input in a form that the game can understand. 
    ///     <example>
    ///     Take, Ruby
    ///     Move, North
    ///     Drop, Rock
    ///     </example>
    /// </summary>
    public class Command
    {
        private Verb Verb {  get; init; }
        private string Noun { get; init; }

        public Command(Verb verb, String noun)
        {
            Verb = verb;
            Noun = noun;            
        }        

        // The Command knows what kind of Command Event it's verb creates. 
        public CommandEvent GetEvent()
        {
            CommandEvent commandEvent;

            switch(Verb)
            {
                case Verb.Drop:
                    commandEvent = new DropEvent(Noun);
                    break;
                case Verb.Give:
                    commandEvent = new GiveEvent(Noun);
                    break;
                // Although the case isn't necessary, for readability it's included 
                case Verb.Help:
                    commandEvent = new HelpEvent();
                    break;
                case Verb.Inventory:
                    commandEvent = new InventoryEvent();
                    break;
                case Verb.Look:
                    commandEvent = new LookEvent(Noun);
                    break;
                case Verb.Move:
                    commandEvent = new MoveEvent(Noun);
                    break;
                case Verb.Open:
                    commandEvent = new OpenEvent(Noun);
                    break;
                case Verb.Play:
                    commandEvent = new PlayEvent();
                    break;
                case Verb.Save:
                    commandEvent = new SaveEvent();
                    break;
                case Verb.Speak:
                    commandEvent = new SpeakEvent(Noun);
                    break;
                case Verb.Quit:
                    commandEvent = new QuitEvent();
                    break;
                case Verb.Take:
                    commandEvent = new TakeEvent(Noun);
                    break;
                // By default the Command Event will be Help
                // This is because either the Verb is NULL or there's a spelling mistake. 
                // Either way the Help Event will show the player all available commands to the player to choose. 
                default:                    
                    commandEvent = new HelpEvent();
                    break;
            }

            return commandEvent;
        }
    }
}
