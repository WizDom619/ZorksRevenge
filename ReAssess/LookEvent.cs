using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.Event
{
    internal class LookEvent : GameEvent
    {
        private string _noun;

        public LookEvent(string noun)
        {
            _noun = noun;
        }
    }
}
