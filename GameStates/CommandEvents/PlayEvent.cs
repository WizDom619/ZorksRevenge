using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZorksRevenge.GameStates.CommandEvents
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
