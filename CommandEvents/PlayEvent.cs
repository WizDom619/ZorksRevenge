using ZorksRevenge.GameObjects;
using ZorksRevenge.Utility;

namespace ZorksRevenge.CommandEvents
{
    internal class PlayEvent : CommandEvent
    {
        private bool _isGameComplete = false;
        private bool _didPlay = false;
        private NPC _targetNPC;

        public PlayEvent()
        {
            foreach (NPC npc in GameData.NPCS)
            {
                if (npc.LocationID == Player.CurrentRoomID)
                {
                    _targetNPC = npc;
                }
            }
        }
        public override void Process()
        {
            _isGameComplete = false;
            _didPlay = false; 

            foreach (NPC npc in GameData.NPCS)
            {
                if (npc.LocationID == Player.CurrentRoomID &&
                    npc.IsHappy &&
                    npc.IsAlive)
                {
                    _didPlay = true;

                    if (npc.Play())
                    {
                        // Beat Game
                        _isGameComplete = true;
                        npc.IsAlive = false;

                        Player.Inventory.Add(npc.PrizeID);
                    }                    
                }                
            }

            if (_isGameComplete)
            {
                GameData.NPCS.Remove(_targetNPC);
            }
        }

        public override void Display()
        {
            if (_didPlay)
            {
                if (_isGameComplete)
                {
                    foreach (Item item in GameData.Items)
                    {
                        if (item.ID == "I001") { item.Colour = ConsoleColor.Yellow; }
                        if (item.ID == "I002") { item.Colour = ConsoleColor.Blue; }
                        if (item.ID == "I003") { item.Colour = ConsoleColor.Green; }
                        if (item.ID == "I004") { item.Colour = ConsoleColor.Cyan; }
                        if (item.ID == "I005") { item.Colour = ConsoleColor.Red; }
                        if (item.ID == "I006") { item.Colour = ConsoleColor.Magenta; }
                        if (item.ID == "I007") { item.Colour = ConsoleColor.White; }

                        if (item.ID == "I033") { item.Colour = ConsoleColor.DarkGreen; }
                        if (item.ID == "I034") { item.Colour = ConsoleColor.DarkRed; }
                        if (item.ID == "I035") { item.Colour = ConsoleColor.DarkBlue; }
                    }

                    ZorkPrinter.Print("You recieved the ");
                    ZorkPrinter.PrintLine($"{GameData.FindGameObjectByID(_targetNPC.PrizeID).Name}\n", GameData.FindGameObjectByID(_targetNPC.PrizeID).Colour);
                    ZorkPrinter.Print("The Sphinx ");
                    ZorkPrinter.Print($"{_targetNPC.Name} ", ZorkPrinter.NPCColour);
                    ZorkPrinter.PrintLine("Has been Defeated!");
                    return;
                }
                else
                {
                    ZorkPrinter.PrintLine("You Failed the Game, try again");
                    return;
                }
            }
            
            if (_targetNPC == null )
            {
                ZorkPrinter.PrintLine($"No Sphinx's here");
                return;
            }

            if(!_targetNPC.IsHappy)
            {
                ZorkPrinter.PrintLine("Give the Sphinx what it Wants before Playing it's game");
                return;
            }
        }
    }
}
