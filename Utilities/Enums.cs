///<summary>
/// A space for all public Enums to be set.
/// </summary>

namespace ZorksRevenge.Utilities
{
    // This will be used by the InputParser and Command classes to ditermine what action the command is. 
    public enum Verb
    {
        Take,
        Move,
        Look,
        Drop,
        Inventory,
        Talk,
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
        Instructions,
        Quit,
        Invalid
    }
}
