using static System.ConsoleColor;

namespace ZorksRevenge.Utility
{
    /// <summary>
    /// The global constants for Zork's Revenge.
    /// </summary>
    public static class GameConstants
    {
        // The Game's Title
        public const string GameTitle = "Zork's Revenge";

        // The Game's Creator
        public const string GameCreator = "Dominic Towns";

        // The Current Version
        public const string Version = "1.5";

        // For user Input to know there was no Input
        public const string NoInput = "*ERROR, No user input given!!*";

        /// <summary>
        /// These are the default colours for specific Game Objects. 
        /// </summary>
        public const ConsoleColor ItemColour = DarkCyan;
        public const ConsoleColor RoomColour = DarkMagenta;
        public const ConsoleColor PlayerColour = DarkGreen;
        public const ConsoleColor NPCColour = DarkRed;
        public const ConsoleColor ContainerColour = DarkYellow;
    }
}