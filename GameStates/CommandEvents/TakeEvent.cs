namespace ZorksRevenge.GameStates.CommandEvents
{
    internal class TakeEvent : CommandEvent
    {
        private string _noun;
        private bool _didTake;

        public TakeEvent(string noun)
        {
            _noun = noun;
        }

        public override void Process()
        {
            GameObject gameObject = GameData.FindGameObjectByName(_noun);
            _didTake = false;

            if (gameObject.LocationID == Player.CurrentRoomID)
            {
                foreach (Item item in GameData.Items)
                {
                    if (item.ID == gameObject.ID)
                    {
                        _didTake = true;
                        // Add to Player's Inventory.
                        Player.Inventory.Add(gameObject.ID);
                        // Remove from Room. 
                        GameData.FindRoomByID(Player.CurrentRoomID).GameObjectsIDs.Remove(gameObject.ID);
                        // Set Location ID to Blank.
                        gameObject.LocationID = "";
                        return;
                    }
                }
            }

            foreach (Container container in GameData.Containers)
            {
                if (container.isOpened &&
                    container.ItemIDs.Count != 0)
                {
                    foreach (string id in container.ItemIDs)
                    {
                        if (id == gameObject.ID)
                        {
                            _didTake = true;
                            // Add to Player's Inventory.
                            Player.Inventory.Add(gameObject.ID);
                            // Remove from Room. 
                            container.ItemIDs.Remove(gameObject.ID);
                            // Set Location ID to Blank.
                            gameObject.LocationID = "";
                            return;
                        }
                    }
                }
            }
            
            

        }
        public override void Display()
        {
            if (_didTake)
            {
                ZorkPrinter.Print("You took the ");
                ZorkPrinter.PrintLine($"{GameData.FindGameObjectByName(_noun).Name}", GameData.FindGameObjectByName(_noun).Colour);
            }
            else
            {
                ZorkPrinter.PrintLine($"You can't take Sphinxs");
                ZorkPrinter.PrintLine($"And can't take Containers (but You can Take what's Inside, if you Open it)");
                ZorkPrinter.Print($"Can't Find the Item: ");
                ZorkPrinter.PrintLine($"{_noun}", ZorkPrinter.ItemColour);
            }

        }
    }
}
