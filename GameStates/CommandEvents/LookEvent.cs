namespace ZorksRevenge.GameStates.CommandEvents
{
    internal class LookEvent : CommandEvent
    {
        private string _noun;

        public LookEvent(string noun)
        {
            _noun = noun;
        }

        public override void Process()
        {
            
        }
        public override void Display()
        {
            GameObject gameobject = GameData.FindGameObjectByName(_noun);

            foreach (Container container in GameData.Containers)
            {
                if (container.isOpened)
                {
                    foreach (string itemIDs in container.ItemIDs)
                    {
                        if (itemIDs == gameobject.ID)
                        {
                            ZorkPrinter.Print($"You looking at... ");
                            ZorkPrinter.Print($"{gameobject.Name}: ", gameobject.Colour);
                            ZorkPrinter.PrintLine($"{gameobject.Desc}");
                            return;
                        }
                    }
                }
            }

            if (gameobject.LocationID == Player.CurrentRoomID)
            {
                ZorkPrinter.Print($"You looking at... ");
                if (gameobject is Item item)
                {
                    ZorkPrinter.Print($"{gameobject.Name}: ", gameobject.Colour);                    
                }
                else if (gameobject is NPC npc)
                {
                    ZorkPrinter.Print($"{gameobject.Name}: ", gameobject.Colour);
                }
                else if (gameobject is Container container)
                {
                    ZorkPrinter.Print($"{gameobject.Name}: ");
                }
                ZorkPrinter.PrintLine($"{gameobject.Desc}");
            }
            else
            {
                ZorkPrinter.Print($"Can't Find: ");
                ZorkPrinter.PrintLine($"{_noun}", gameobject.Colour);
            }
            
        }
    }
}
