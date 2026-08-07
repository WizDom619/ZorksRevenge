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
            GameObject gameObject = null;
            gameObject = GameData.FindGameObjectByName(_noun);

            if (gameObject != null)
            {
                if (gameObject.ID == Player.CurrentRoomID)
                {
                    foreach (string id in GameData.FindRoomByID(Player.CurrentRoomID).GameObjectsIDs)
                    {
                        if (gameObject is Item item)
                        {
                            ZorkPrinter.Print($"You looking at... ");
                            ZorkPrinter.Print($"{item.Name}: ", item.Colour);
                            ZorkPrinter.PrintLine($"{gameObject.Desc}");
                            return;
                        }
                        else if (gameObject is NPC npc)
                        {
                            ZorkPrinter.Print($"You looking at... ");
                            ZorkPrinter.Print($"{npc.Name}: ", ZorkPrinter.NPCColour);
                            ZorkPrinter.PrintLine($"{gameObject.Desc}");
                            return;
                        }
                        else if (gameObject is Container container)
                        {
                            ZorkPrinter.Print($"You looking at... ");
                            ZorkPrinter.Print($"{container.Name}: ", ZorkPrinter.ContainerColour);
                            ZorkPrinter.PrintLine($"{gameObject.Desc}");
                            return;
                        }
                    }
                }                

                foreach (Container container in GameData.Containers)
                {
                    if (container.isOpened)
                    {
                        foreach (string itemIDs in container.ItemIDs)
                        {
                            foreach (GameObject GO in GameData.Items)
                            {
                                if (itemIDs == gameObject.ID)
                                {
                                    ZorkPrinter.Print($"You looking at... ");
                                    ZorkPrinter.Print($"{GO.Name}: ", ZorkPrinter.ContainerColour);
                                    ZorkPrinter.PrintLine($"{GO.Desc}");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
                
            ZorkPrinter.Print($"Can't Find: ");
            ZorkPrinter.PrintLine($"{_noun}", gameObject.Colour);
            
        }
    }
}
