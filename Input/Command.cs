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
        public Verb _verb;// {  get; private set; }
        public string _noun; // { get; private set; }

        private Item _takenItem;
        private Item _dropItem;
        private Direction _dir;

        public Command(Verb verb, String noun)
        {
            _verb = verb;
            _noun = noun;
            _takenItem = new Item("NULL", "NULL");
            _dropItem = new Item("NULL", "NULL");
            _dir = Direction.NULL;
        }

        public void Process(List<Room> gameWorld, PlayerData playerData)
        {
            switch (_verb)
            {
                case Verb.Take:
                    _takenItem = new Item("NULL", "NULL");

                    foreach (Item item in playerData.CurrentRoom.Items)
                    {
                        if (item.Name.ToUpper() == _noun.ToUpper() &&
                            item.Name.ToUpper() != "NULL")
                        {
                            _takenItem = item;
                            playerData.Inventory.Add(_takenItem);
                            playerData.CurrentRoom.Items.Remove(_takenItem);
                            break;
                        }
                    }
                    break;

                case Verb.Move:
                    _dir = ConvertStringToDirection(_noun);
                    playerData.CurrentRoom = playerData.CurrentRoom.Paths.GetRoom(_dir);
                    break;

                case Verb.Drop:
                    _dropItem = new Item("NULL", "NULL");

                    foreach (Item item in playerData.Inventory)
                    {
                        if (item.Name.ToUpper() == _noun.ToUpper() &&
                            item.Name.ToUpper() != "NULL")
                        {
                            _dropItem = item;
                            playerData.Inventory.Remove(_dropItem);
                            playerData.CurrentRoom.Items.Add(_dropItem);
                            break;
                        }
                    }
                    break;
            }            
        }

        public void Display(PlayerData playerData)
        {
            ZorkPrinter.PrintLine($"Command: \"{_verb}\", \"{_noun}\"\n", ZorkPrinter.PlayerColour);

            switch (_verb)
            {
                case Verb.Take:
                {
                    if (_takenItem.Name == "NULL")
                    {
                        ZorkPrinter.PrintLine("No Item with that name is in this Room");
                    }
                    else
                    {
                        ZorkPrinter.Print("You took the ");
                        ZorkPrinter.PrintLine($"{_takenItem.Name}", ZorkPrinter.ItemColour);
                    }
                    break;
                }
                case Verb.Move:
                {
                    ZorkPrinter.Print("You moved ");
                    ZorkPrinter.PrintLine($"{_dir}");
                    ZorkPrinter.Print($"You are now in ");
                    ZorkPrinter.PrintLine($"{playerData.CurrentRoom.Name}", ZorkPrinter.RoomColour);
                    break;
                }
                case Verb.Drop:
                {
                    if (_dropItem.Name == "NULL")
                    {
                        ZorkPrinter.PrintLine("No Item with that name is in your Inventory");
                    }
                    else
                    {
                        ZorkPrinter.Print("You dropped ");
                        ZorkPrinter.PrintLine($"{_dropItem.Name}", ZorkPrinter.ItemColour);
                    }
                    break;
                }
                case Verb.Look:
                {
                    playerData.CurrentRoom.Print();
                    break;
                }
                case Verb.Inventory:
                {
                    playerData.PrintInventory();
                    break;
                }
                case Verb.Help:
                    {
                        //TODO
                        break;
                    }
                case Verb.NULL:
                {
                    ZorkPrinter.PrintLine("Unknown Command");
                    ZorkPrinter.PrintLine(" -Please type an appropriate command");
                    ZorkPrinter.PrintLine(" -Type 'help' for a guide on commands");
                    break;
                }
                case Verb.Speak:
                {
                    NPC npc = playerData.CurrentRoom.NPC;
                    ZorkPrinter.Print("The Great and Mighty Sphinx: ");
                    ZorkPrinter.Print($"{npc.Name} ", ZorkPrinter.NPCColour);
                    ZorkPrinter.Print("says... ");
                    ZorkPrinter.PrintLine($"{npc.Instructions}");
                    break;
                }
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

        public Verb Verb{  get; private set; }
        public string Noun { get; private set; }
    }
}
