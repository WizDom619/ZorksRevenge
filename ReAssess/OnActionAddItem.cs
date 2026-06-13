using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.EventArgs
{
    internal class OnActionAddItem : IGameEvent
    {
        public string _itemName { get; }
        public string _itemDesc { get; }

        public OnActionAddItem(string itemName, string itemDesc)
        {
            _itemName = itemName;
            _itemDesc = itemDesc;
        }
    }
}
