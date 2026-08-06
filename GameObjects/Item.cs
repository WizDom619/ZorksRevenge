namespace ZorksRevenge
{
    /// <summary>
    /// Item is a GameObject that contains all the data relevant to an item. 
    /// </summary>
   
    public class Item : GameObject
    {        
        public Item()
        {
            _colour = ZorkPrinter.ItemColour;

        }
        public override void Print()
        {
            if (ID == "I001") { Colour = ConsoleColor.Yellow; }
            if (ID == "I002") { Colour = ConsoleColor.Blue; }
            if (ID == "I003") { Colour = ConsoleColor.Green; }
            if (ID == "I004") { Colour = ConsoleColor.Cyan; }
            if (ID == "I005") { Colour = ConsoleColor.Red; }
            if (ID == "I006") { Colour = ConsoleColor.Magenta; }
            if (ID == "I007") { Colour = ConsoleColor.White; }

            if (ID == "I033") { Colour = ConsoleColor.DarkGreen; }
            if (ID == "I034") { Colour = ConsoleColor.DarkRed; }
            if (ID == "I035") { Colour = ConsoleColor.DarkBlue; }

            ZorkPrinter.Print("-", Colour);
            ZorkPrinter.PrintLine(_name, GameData.FindGameObjectByName(_name).Colour);
        }

        public void PrintTest()
        {
            Console.WriteLine("ID " + _id);
            Console.WriteLine("Location " + GameData.FindRoomByID(_locationID).Name + " (" + _locationID + ")");
            Console.WriteLine("Name " + _name);
            Console.WriteLine("Desc " + _description);
            Console.WriteLine("-------------------");
        }

    }
}