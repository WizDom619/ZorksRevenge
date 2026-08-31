using ZorksRevenge.Utility;

namespace ZorksRevenge.CommandEvents
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
                    ZorkPrinter.Print("The Great and Mighty Sphinx ");
                    ZorkPrinter.Print($"{npc.Name}, ", ZorkPrinter.NPCColour);
                    ZorkPrinter.PrintLine("says... ");
                    ZorkPrinter.PrintLine(" Bring me..");

                    foreach (KeyValuePair<string, bool> kvp in npc.Wants)
                    {
                        if (npc.Wants.Count == 0)
                        {
                            ZorkPrinter.PrintLine($" -Empty");
                        }
                        else if (kvp.Value == false)
                        {
                            ConsoleColor CC = ZorkPrinter.ItemColour;

                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I001") { CC = ConsoleColor.Yellow; }
                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I002") { CC = ConsoleColor.Blue; }
                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I003") { CC = ConsoleColor.Green; }
                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I004") { CC = ConsoleColor.Cyan; }
                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I005") { CC = ConsoleColor.Red; }
                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I006") { CC = ConsoleColor.Magenta; }
                            if (GameData.FindGameObjectByID(kvp.Key).ID == "I007") { CC = ConsoleColor.White; }


                            ZorkPrinter.PrintLine($"  -{GameData.FindGameObjectByID(kvp.Key).Name}", CC);
                        }
                    }
                    return;
                }
            }
            ZorkPrinter.PrintLine($"No Sphinx's here with that name");
        }
    }
}
