using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.CommandEvents
{
    internal class BlankEvent : CommandEvent
    {
        public override void Process()
        {

        }

        public override void Display()
        {
            ZorkPrinter.PrintLine("Unknown Command");
            ZorkPrinter.PrintLine(" -Please type an appropriate command");
            ZorkPrinter.PrintLine(" -Type 'help' for a guide on commands");
        }
    }
}
