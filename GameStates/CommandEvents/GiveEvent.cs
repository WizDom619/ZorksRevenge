namespace ZorksRevenge
{
    internal class GiveEvent : CommandEvent
    {
        private string _noun;
        private bool _didGive = false;

        public GiveEvent(string noun)
        {
            _noun = noun;
        }

        public override void Process()
        {
            _didGive = false;

            GameObject gameObjectToGive = GameData.FindGameObjectByName(_noun);

            foreach (string id in Player.Inventory)
            {
                if (id == gameObjectToGive.ID)
                {
                    foreach (NPC npc in GameData.NPCS)
                    {
                        if (npc.IsAlive)
                        {
                            foreach (KeyValuePair<string, bool> kvp in npc.Wants)
                            {
                                if (kvp.Key == gameObjectToGive.ID)
                                {
                                    npc.Wants[kvp.Key] = true;
                                    _didGive = true;                                        
                                }
                            }

                            bool readyToBeHappy = true;

                            foreach (KeyValuePair<string, bool> kvp in npc.Wants)
                            {
                                if (kvp.Value == false)
                                {
                                    readyToBeHappy = false;
                                }
                            }

                            if (readyToBeHappy)
                            {
                                npc.IsHappy = true;
                            }
                        }
                    }


                }
            }

            if (_didGive)
            {
                Player.Inventory.Remove(GameData.FindGameObjectByName(_noun).ID);
            }
        }

        public override void Display()
        {
            foreach (NPC npc in GameData.NPCS)
            {
                if (npc.LocationID == Player.CurrentRoomID)
                {
                    if (_didGive)
                    {
                        ZorkPrinter.Print("You gave the ");
                        ZorkPrinter.Print($"{GameData.FindGameObjectByName(_noun).Name} ", GameData.FindGameObjectByName(_noun).Colour);
                        ZorkPrinter.Print("to ");
                        ZorkPrinter.PrintLine($"{npc.Name}", ZorkPrinter.NPCColour);
                    }
                    else
                    {
                        ZorkPrinter.Print($"{npc.Name} ", ZorkPrinter.NPCColour);
                        ZorkPrinter.PrintLine("Does not want that");
                        return;
                    }

                    if (npc.IsHappy)
                    {
                        ZorkPrinter.Print($"\n{npc.Name} ", ZorkPrinter.NPCColour);
                        ZorkPrinter.PrintLine("is Pleased with you, you may now Play it's Game");
                        return;
                    }                    
                }
                else
                {
                    ZorkPrinter.Print("No ");
                    ZorkPrinter.Print("Sphinx ", ZorkPrinter.NPCColour);
                    ZorkPrinter.PrintLine("Here to give anything to");
                    return;
                }
            }
            
        }
    }
}
