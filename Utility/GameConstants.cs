namespace ZorksRevenge.Utility
{
    /// <summary>
    /// Global constants for Zork's Revenge.
    /// Centralizing these here keeps them easy to find and update,
    /// and avoids magic strings/values scattered across the codebase.
    /// </summary>
    public static class GameConstants
    {
        /// <summary>
        /// The title displayed in the console window.
        /// </summary>
        public const string GameTitle = "Zork's Revenge";

        /// <summary>
        /// The creator/author of the game. Update this with your name.
        /// </summary>
        public const string GameCreator = "Dominic Towns";

        /// <summary>
        /// The current version of the game. Bump this as you release updates.
        /// </summary>
        public const string Version = "1.5";
    }
}