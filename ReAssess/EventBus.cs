using ZorksRevenge;
using ZorksRevenge.Event;
using ZorksRevenge.Parser;
using ZorksRevenge.Utilities;

namespace ZorksRevenge
{
    internal static class EventBus
    {
        // EventBus.dispatch receives a Command, translates it, publishes
        public static void Dispatch(Command command)
        {
            GameEvent gameEvent = Resolve(command);

            if (gameEvent == null)
            {
                ZorkPrinter.PrintLine("I don't understand that."));
                return;
            }

            Publish(gameEvent);
        }

        public static void Publish(GameEvent gameEvent)
        {
            // notify all subscribers
        }

        public static GameEvent Resolve(Command command) 
        {
            switch (command.Verb)
            {
                case Verb.Look:
                    return new LookEvent(command.Noun);

                default:
                    return null;
            }
            //"go" => new PlayerMovedEvent(command.Noun),
            //"take" => new ItemTakenEvent(command.Noun),
            //"drop" => new ItemDroppedEvent(command.Noun),
            //_ => null
        }
    }
}

// Subscribers register themselves
//WorldManager.subscribe(EventBus);  // listens for PlayerMovedEvent
//Inventory.subscribe(EventBus);     // listens for ItemTakenEvent, ItemDroppedEvent
//Narrator.subscribe(EventBus);      // listens for everything to print output
//SaveSystem.subscribe(EventBus);    // listens for state-changing events