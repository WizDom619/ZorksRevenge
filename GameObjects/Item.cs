namespace ZorksRevenge
{
    /// <summary>
    /// Item is a GameObject that contains all the data relevant to an item. 
    /// </summary>
   
    public class Item : GameObject
    {        
        public Item()
        {

        }
        public override void Print()
        {
            ZorkPrinter.Print("-", ZorkPrinter.ItemColour);
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