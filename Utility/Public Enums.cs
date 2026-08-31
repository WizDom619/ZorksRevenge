///<summary>
/// A space for all public Enums to be set.
/// </summary>
namespace ZorksRevenge.Utility
{
    // This will be used by the InputParser and Command classes to determine what Verb the command is. 
    public enum Verb
    {
        Drop,
        Give,
        Help,
        Inventory,
        Look,
        Move,
        Open,
        Play,
        Save,
        Speak,
        Quit,
        Take, 
        NULL
    };
    public enum DataDir
    {
        Containers,
        Items,
        NPCS,
        Player,
        Rooms,
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
