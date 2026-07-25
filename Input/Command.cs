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
        private NPC _talkedNPC;
        private Container _openedContainer;
        private Item _givenItem;
        private Direction _dir;

        public Command(Verb verb, String noun)
        {
            _verb = verb;
            _noun = noun;
            _takenItem = new Item("NULL", "NULL");
            _dropItem = new Item("NULL", "NULL");
            _talkedNPC = new Sphinx("NULL");
            _openedContainer = new Container("NULL");
            _givenItem = new Item("NULL", "NULL");
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
                        if (item.GetType() == typeof(Money) &&
                            item.Name.ToUpper() == _noun.ToUpper() &&
                            item.Name.ToUpper() != "NULL")
                        {
                            Money money = (Money)item;
                            _takenItem = money;
                            playerData.Money += money.Value;
                            playerData.CurrentRoom.Items.Remove(money);
                            break;
                        }
                        else if (item.Name.ToUpper() == _noun.ToUpper() &&
                                 item.Name.ToUpper() != "NULL")
                        {
                            _takenItem = item;
                            playerData.Inventory.Add(_takenItem);
                            playerData.CurrentRoom.Items.Remove(_takenItem);
                            break;
                        }
                    }

                    foreach (Container container in playerData.CurrentRoom.Containers)
                    {
                        if (container.Opened &&
                            container.Contents.Count != 0)
                        {
                            foreach (Item item in container.Contents)
                            {
                                if (item.Name.ToUpper() == _noun.ToUpper() &&
                                    item.Name.ToUpper() != "NULL")
                                {
                                    _takenItem = item;
                                    playerData.Inventory.Add(_takenItem);
                                    container.Contents.Remove(_takenItem);
                                    break;
                                }
                            }
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

                case Verb.Speak:
                    _talkedNPC = new Sphinx("NULL");

                    if (playerData.CurrentRoom.NPC.Name.ToUpper() == _noun.ToUpper())
                    {
                        _talkedNPC = playerData.CurrentRoom.NPC;
                    }

                    break;

                
                case Verb.Open:
                    _openedContainer = new Container("NULL");

                    foreach (Container container in playerData.CurrentRoom.Containers)
                    {
                        if (container.Name.ToUpper() == _noun.ToUpper() &&
                            container.Name.ToUpper() != "NULL")
                        {
                            _openedContainer = container;
                            _openedContainer.Opened = true;
                            break;
                        }
                    }
                    break;

                case Verb.Give:
                    _givenItem = new Item("NULL", "NULL");

                    if (playerData.CurrentRoom.NPC.Want.Count == 1)
                    {
                        if (playerData.CurrentRoom.NPC.Want.First().ToUpper() == _noun.ToUpper() &&
                        playerData.CurrentRoom.NPC.IsAlive)
                        {
                            foreach (Item item in playerData.Inventory)
                            {
                                if (item.Name.ToUpper() == _noun.ToUpper())
                                {
                                    _givenItem = item;
                                    playerData.Inventory.Remove(item);
                                    playerData.CurrentRoom.NPC.IsHappy = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach(string s in playerData.CurrentRoom.NPC.Want)
                        {
                            foreach (Item item in playerData.Inventory)
                            {
                                if (item.Name.ToUpper() == _noun.ToUpper())
                                {
                                    _givenItem = item;
                                    playerData.Inventory.Remove(item);
                                    playerData.CurrentRoom.NPC.IsHappy = true;
                                    break;
                                }
                            }
                        }
                    }
                    
                    break;

                case Verb.Play:
                    
                    break;
                    
            }            
        }

        public void Display(PlayerData playerData)
        {
            ZorkPrinter.PrintLine($"Command: \"{_verb}\", \"{_noun}\"\n", ZorkPrinter.PlayerColour);

            switch (_verb)
            {
                case Verb.Take:                
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
                
                case Verb.Move:                
                    ZorkPrinter.Print("You moved ");
                    ZorkPrinter.PrintLine($"{_dir}");
                    ZorkPrinter.Print($"You are now in ");
                    ZorkPrinter.PrintLine($"{playerData.CurrentRoom.Name}", ZorkPrinter.RoomColour);
                    break;
                
                case Verb.Drop:                
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
                
                case Verb.Look:
                    playerData.CurrentRoom.Print();
                    break;
                
                case Verb.Inventory:                
                    playerData.PrintInventory();
                    break;
                
                case Verb.Help:                
                    //TODO
                    break;
                
                case Verb.NULL:                
                    ZorkPrinter.PrintLine("Unknown Command");
                    ZorkPrinter.PrintLine(" -Please type an appropriate command");
                    ZorkPrinter.PrintLine(" -Type 'help' for a guide on commands");
                    break;
                
                case Verb.Speak:       
                    if (_talkedNPC.Name != "NULL")
                    {
                        ZorkPrinter.Print("The Great and Mighty Sphinx: ");
                        ZorkPrinter.Print($"{_talkedNPC.Name} ", ZorkPrinter.NPCColour);
                        ZorkPrinter.Print("says... ");
                        ZorkPrinter.PrintLine($"{_talkedNPC.Instructions}");
                    }
                    
                    break;

                case Verb.Open:
                    ZorkPrinter.PrintLine($"{_openedContainer.Name} is Opened");                    
                    playerData.CurrentRoom.Print();
                    break;

                case Verb.Give:
                    ZorkPrinter.Print("You gave the ");
                    ZorkPrinter.Print($"{_givenItem.Name} ", ZorkPrinter.ItemColour);
                    ZorkPrinter.Print("to ");
                    ZorkPrinter.PrintLine($"{playerData.CurrentRoom.NPC.Name} ", ZorkPrinter.NPCColour);
                    ZorkPrinter.PrintLine("You may now play the Sphinx's Game");
                    break;

                case Verb.Play:
                    if (playerData.CurrentRoom.NPC.IsHappy &&
                        playerData.CurrentRoom.NPC.IsAlive)
                    {
                        if (playerData.CurrentRoom.NPC.Play())
                        {
                            // Beat Game
                            playerData.AddItem(playerData.CurrentRoom.NPC.Prize);
                            ZorkPrinter.Print("You recieved the ");
                            ZorkPrinter.Print($"{playerData.CurrentRoom.NPC.Prize.Name}", ZorkPrinter.ItemColour);
                            playerData.CurrentRoom.NPC.IsAlive = false;
                        }
                        else
                        {
                            // Failed Game
                        }
                    }
                    
                    break;
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
