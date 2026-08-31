namespace ZorksRevenge.Data
{
    /// <summary>
    /// This class hold all relevant information about the player
    /// Both personal information such as Name
    /// And gameplay data such as Current Room ID and InventoryID
    /// </summary>
    public class Player
    {
        // Set properties and default values. 
        // The user's unique name
        public string? Name { get; set; } = "No Name";
        // Use for check if player can take items ect...
        // (The item must be in the same room as the player) 
        public string? CurrentRoomID { get; set; } = "R001";
        // Increases each time player moves to another Room. 
        public int MoveCount { get; set; } = 0;
        // Set true once player defeats the final boss
        public bool DidBeatGame { get; set; } = false;
        // All items the player is holding
        public List<string> InventoryID { get; set; } = new List<string>();  
    }    
}
