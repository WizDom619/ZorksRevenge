namespace ZorksRevenge.GameData
{
    public class Player
    {
        public string? Name { get; set; }
        public string? CurrentRoomID { get; set; }
        public int MoveCount { get; set; }
        public bool DidBeatGame { get; set; }
        public List<string> InventoryID { get; set; }

        public Player()
        {
            InventoryID = new List<string>();
        }       
    }    
}
