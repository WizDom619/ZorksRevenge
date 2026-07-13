using ZorksRevenge.GameObjects;

namespace ZorksRevenge.Input
{
    /// <summary>
    /// A Command will contain a Verb and a Noun.
    /// This object's properities will then be used affect the game world.
    ///     <example>
    ///     Take, Ruby
    ///     Move, North
    ///     Look, 'current room'
    ///     Drop, Rock
    ///     </example>
    /// </summary>
    internal class Command
    {
        public Verb Verb {  get; private set; }
        public string Noun { get; private set; }

        public Command(Verb verb, String noun)
        {
            Verb = verb;
            Noun = noun;
        }

        public void Process(List<Room> gameWorld, PlayerData playerData)
        {
            switch (Verb)
            {
                case Verb.Take:
                    Item takenItem = new Item("NULL", "NULL");

                    foreach (Item item in playerData.CurrentRoom.Items)
                    {
                        if (item.Name.ToUpper() == Noun.ToUpper())
                        {
                            takenItem = item;
                            break;
                        }
                    }

                    playerData.Inventory.Add(takenItem);
                    playerData.CurrentRoom.Items.Remove(takenItem);
                    break;

                case Verb.Move:
                    Direction dir = ConvertStringToDirection(Noun);
                    playerData.CurrentRoom = playerData.CurrentRoom.Paths.GetRoom(dir);
                    break;

                case Verb.Drop:
                    Item dropItem = new Item("NULL", "NULL");

                    foreach (Item item in playerData.Inventory)
                    {
                        if (item.Name.ToUpper() == Noun.ToUpper())
                        {
                            dropItem = item;
                            break;
                        }
                    }

                    playerData.Inventory.Remove(dropItem);
                    playerData.CurrentRoom.Items.Add(dropItem);
                    break;
            }

            // newVerb = Verb.Speak;
        }

        public void Display(PlayerData playerData)
        {
            ZorkPrinter.PrintLine($"Command: \"{Verb}\", \"{Noun}\"\n", ZorkPrinter.PlayerColour);

            if (Verb == Verb.Look)
            {
                playerData.CurrentRoom.Print();
            }
            else if (Verb == Verb.Inventory)
            {
                playerData.PrintInventory();
            }
            else if (Verb == Verb.Help)
            {
                //TODO
            }
            else if (Verb == Verb.NULL)
            {
                ZorkPrinter.PrintLine("Unknown Command");
                ZorkPrinter.PrintLine(" -Please type an appropriate command");
                ZorkPrinter.PrintLine(" -Type 'help' for a guide on commands");
            }
        }

        private Direction ConvertStringToDirection(String noun)
        {
            Direction dir = Direction.NULL;

            if (noun.ToUpper() == "NORTH") { dir = Direction.North; }
            if (noun.ToUpper() == "SOUTH") { dir = Direction.South; }
            if (noun.ToUpper() == "EAST") { dir = Direction.East; }
            if (noun.ToUpper() == "WEST") { dir = Direction.West; }

            return dir;
        }
    }
}
