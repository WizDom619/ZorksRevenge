using ZorksRevenge.Utility;

namespace ZorksRevenge.Data
{
    /// <summary>
    /// This class hold all relevant information about the Player
    /// Both personal information such as Name
    /// And gameplay data such as Current Room ID and InventoryID
    /// </summary>
    public class PlayerData
    {
        // Set properties and default values. 
        // The user's unique name
        public string Name { get; set; }

        // Use for check if player can take items ect...
        // (The item must be in the same room as the player) 
        public string CurrentRoomID { get; set; }

        // Increases each time player moves to another Room. 
        public int MoveCount { get; set; }

        // Set true once player defeats the final boss
        public bool DidBeatGame { get; set; }

        // All items the player is holding
        public List<string> InventoryID { get; set; }

        public PlayerData() 
        { 
            Name = "No Player Name" + NOINPUT;
            CurrentRoomID = "R001";
            MoveCount = 0;
            DidBeatGame = false;
            InventoryID = new List<string>();
        }
    }    
}
