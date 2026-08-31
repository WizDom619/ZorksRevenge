using ZorksRevenge.Utility;

namespace ZorksRevenge.CommandEvents
{
    internal class HelpEvent : CommandEvent
    {
        public override void Process()
        {

        }
        public override void Display()
        {
            ZorkPrinter.PrintLine("These are all the possible commands...");
            ZorkPrinter.PrintLine("(Use the single for quick input)\n");

            ZorkPrinter.PrintLine("L, Look  [Item]      -To see what's in the room you are inside");
            ZorkPrinter.PrintLine("T, Take  [Item]      -Take an Item and put it in your inventory");
            ZorkPrinter.PrintLine("D, Drop  [Item]      -Drops an Item from your Inventory");
            ZorkPrinter.PrintLine("O, Open  [Container] -Open containers to see what's inside");
            ZorkPrinter.PrintLine("S, Speak [Name]      -Talk to a Sphinx they will tell you what it wants");
            ZorkPrinter.PrintLine("G, Give  [Item]      -Give the item the Sphinx wants (if you have it)");
            ZorkPrinter.PrintLine("P, Play              -When a Sphinx has it's gift, you can play it's game");
            ZorkPrinter.PrintLine("I, Inventory         -Look at the Items you are carrying");
            ZorkPrinter.PrintLine("M, Move  [Direction] -Use the four compass directions (North, South, East and West) to move around the game world");
            ZorkPrinter.PrintLine("H, Help              -To recall these instructions again\n");
            
            ZorkPrinter.PrintLine("Save                 -Save your progress, this has no quick command.");
            ZorkPrinter.PrintLine("Quit                 -Quit and return to the Main Menu, this has no quick command.\n");

            ZorkPrinter.PrintLine("Type in a commmand and see what happens...");
        }
    }
}
