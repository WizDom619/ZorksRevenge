///<summary>
/// A space for all public Enums to be set.
/// </summary>
namespace ZorksRevenge
{
    // This will be used by the InputParser and Command classes to ditermine what action the command is. 
    public enum Verb
    {
        Take,
        Move,
        Look,
        Drop,
        Inventory,
        Speak,
        Blank,
        Help,
        Open,
        Play,
        Give,
        NULL
    };
    // This enum will be used by the CompassDirection class to know direction it is pointitng. 
    public enum Direction
    {
        North,
        South,
        East,
        West,
        NULL
    };
    // This enum will be used by the Main Menu class to set the stae of the menu. 
    public enum MenuState
    {
        MainMenu,
        NewGame,
        LoadGame,
        HowToPlay,
        Quit,
        NULL
    };
    // This enum will be used by the Zork printer to ditermine what text effects to apply on a print. 
    // FYI Bold is an option for ASCII Escape characters but it doesn't affect anything, atleast not in Windows Console. 
    public enum PrintEffect
    {
        // Reset [0m
        Italic, // [3m
        Underline, // [4m
        Blinking, // [5m
        Strike, // [9m
        NULL
    };
}
