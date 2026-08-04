using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.GameStates.CommandEvents
{
    internal class InventoryEvent : CommandEvent
    {
        public override void Process()
        {

        }
        public override void Display()
        {
            Player.PrintInventory();
        }
    }
}
