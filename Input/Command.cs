using ZorksRevenge.GameStates.CommandEvents;

namespace ZorksRevenge
{
    /// <summary>
    /// A Command will contain a Verb and a Noun.
    /// This object's properities will then be used affect the game world.
    ///     <example>
    ///     Take, Ruby
    ///     Move, North
    ///     Look, 'current room'
    ///     Drop, Rock
    ///     </example>
    /// </summary>
    public class Command
    {
        public Verb _verb;
        public string _noun;

        public Command(Verb verb, String noun)
        {
            _verb = verb;
            _noun = noun;            
        }        

        public CommandEvent GetEvent()
        {
            CommandEvent commandEvent = new HelpEvent(); 

            switch(_verb)
            {
                case Verb.Take:
                    commandEvent = new TakeEvent(_noun);
                    break;
                case Verb.Move:
                    commandEvent = new MoveEvent(_noun);
                    break;
                case Verb.Look:
                    commandEvent = new LookEvent(_noun);
                    break;
                case Verb.Drop:
                    commandEvent = new DropEvent(_noun);
                    break;
                case Verb.Inventory:
                    commandEvent = new InventoryEvent();
                    break;
                case Verb.Speak:
                    commandEvent = new SpeakEvent(_noun);
                    break;
                case Verb.Blank:
                    commandEvent = new BlankEvent();
                    break;
                case Verb.Help:
                    commandEvent = new HelpEvent();
                    break;
                case Verb.Open:
                    commandEvent = new OpenEvent(_noun);
                    break;
                case Verb.Play:
                    commandEvent = new PlayEvent();
                    break;
                case Verb.Give:
                    commandEvent = new GiveEvent(_noun);
                    break;
                case Verb.Save:
                    commandEvent = new SaveEvent();
                    break;
                case Verb.Quit:
                    commandEvent = new QuitEvent();
                    break;
            }

            return commandEvent;
        }

        public Verb Verb
        { 
            get { return _verb; } 
            private set; 
        }
        public string Noun 
        { 
            get { return _noun; }
            private set; }
    }
}
