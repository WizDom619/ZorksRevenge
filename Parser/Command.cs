using ZorksRevenge.ReAssess;

namespace ZorksRevenge.Parser
{
    /// <summary>
    /// A Command will contain a Vern and a Noun.
    /// This object's properities will then be used affect the game world.
    ///     <example>
    ///     Take, Ruby
    ///     Move, North
    ///     Look, 'current room'
    ///     Drop, Rock
    ///     </example>
    /// </summary>
    internal class Command
    {
        public Verb Verb {  get; private set; }
        public string Noun { get; private set; }

        public Command(Verb verb, String noun)
        {
            Verb = verb;
            Noun = noun;
        }
        public override string ToString()
        {
            return $"Command: \"{Verb}\", \"{Noun}\"";
        }
    }
}
