namespace ZorksRevenge
{
    internal class SpeakEvent : CommandEvent
    {
        private string _noun;

        public SpeakEvent(string noun)
        {
            _noun = noun;
        }

        public override void Process()
        {
        }

        public override void Display()
        {
            foreach(NPC npc in GameData.NPCS)
            {
                if (npc.LocationID == Player.CurrentRoomID &&
                    npc.Name.ToUpper() == _noun.ToUpper())
                {
                    ZorkPrinter.Print("The Great and Mighty Sphinx: ");
                    ZorkPrinter.Print($"{npc.Name} ", ZorkPrinter.NPCColour);
                    ZorkPrinter.PrintLine("says... ");
                    ZorkPrinter.PrintLine("Bring me..");

                    foreach (KeyValuePair<string, bool> kvp in npc.Wants)
                    {
                        if (npc.Wants.Count == 0)
                        {
                            ZorkPrinter.PrintLine($" -Empty");
                        }
                        else if (kvp.Value == false)
                        {
                            //GameData.FindGameObjectByID(kvp.Key)
                            ZorkPrinter.PrintLine($" -{GameData.FindGameObjectByID(kvp.Key).Name}", GameData.FindGameObjectByID(kvp.Key).Colour);
                        }
                    }
                    return;
                }
            }
            ZorkPrinter.PrintLine($"No Sphinx's here with that name");
        }
    }
}
