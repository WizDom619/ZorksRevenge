namespace ZorksRevenge.CommandEvents
{
    public class DropEvent : CommandEvent
    {
        private string _noun;
        private bool _didDrop;

        public DropEvent(string noun)
        {
            _noun = noun;
        }

        public override void Process()
        {
            GameObject gameObject = GameData.FindGameObjectByName(_noun);
            _didDrop = false; 

            foreach (string id in Player.Inventory)
            {
                if (id == gameObject.ID)
                {
                    _didDrop = true;
                    
                    // Add to Current Room
                    GameData.FindRoomByID(Player.CurrentRoomID).AddGameObject(gameObject.ID);
                    // Update CurrentRoomID
                    gameObject.LocationID = GameData.FindRoomByID(Player.CurrentRoomID).ID;
                }
            }

            if (_didDrop) 
            {
                // Remove from Inventory
                Player.Inventory.Remove(gameObject.ID);
            }
        }

        public override void Display()
        {
            if (_didDrop)
            {
                ZorkPrinter.Print("You dropped ");
                ZorkPrinter.PrintLine($"{GameData.FindGameObjectByName(_noun).Name}", GameData.FindGameObjectByName(_noun).Colour);
            }
            else
            {
                ZorkPrinter.Print("Could not find ");
                ZorkPrinter.Print($"{_noun} ", ZorkPrinter.ItemColour);
                ZorkPrinter.PrintLine($"in your Inventory");
            }
        }
    }
}
