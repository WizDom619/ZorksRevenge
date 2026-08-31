using ZorksRevenge.Utility;

namespace ZorksRevenge.CommandEvents
{
    internal class OpenEvent : CommandEvent
    {
        private string _noun;
        private bool _didOpen; 

        public OpenEvent(string noun)
        {
            _noun = noun;
        }

        public override void Process()
        {
            _didOpen = false; 

            foreach (Container container in GameData.Containers)
            {
                if (container.LocationID == Player.CurrentRoomID &&
                    container.Name.ToUpper() == _noun.ToUpper())
                {
                    _didOpen = true;
                    container.isOpened = true;
                    break;
                }
            }
        }

        public override void Display()
        {
            if (_didOpen)
            {
                ZorkPrinter.PrintLine($"{GameData.FindGameObjectByName(_noun).Name} is Opened");
            }
            else
            {
                ZorkPrinter.PrintLine($"Could not Open {_noun}");
            }
        }
    }
}
