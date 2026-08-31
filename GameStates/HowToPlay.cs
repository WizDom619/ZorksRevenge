using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the How To Play Menu Class
    /// Will inherit from Menu Base because it is a type of menu. 
    /// Instruction on how to play will be displayed here. 
    /// </summary>
    public class HowToPlay : GameState
    {

        public override void Display()
        {
            ZorkPrinter.PrintLine("----------------------------------------------------------------------------------------------");
            Console.Write("                                      ");
            ZorkPrinter.PrintLine("*How to Play*");
            ZorkPrinter.PrintLine("----------------------------------------------------------------------------------------------");

            ZorkPrinter.PrintLine("\n    Zork's Revenge is a fan made game inspired by the 1977 text based adventure game 'Zork’");
            ZorkPrinter.Print("    This is a ");
            ZorkPrinter.PrintLine("text based adventure", ConsoleColor.Gray, PrintEffect.Underline);
            ZorkPrinter.PrintLine("    This means there game in entirely played through the input and output of text");
            ZorkPrinter.PrintLine("    There are no fancy video game graphics here");
            ZorkPrinter.PrintLine("    This game runs on good'old fashioned cold hard logic", ConsoleColor.Gray, PrintEffect.Italic);
            ZorkPrinter.PrintLine("    You Play the Game through commands such is...");
            ZorkPrinter.PrintLine("\t-Look [Item Name]");
            ZorkPrinter.PrintLine("\t-Grab [Item Name], or ");
            ZorkPrinter.PrintLine("\t-Move [Item Direction]\n");
            ZorkPrinter.PrintLine("    The game revolves around exploring, collecting and solving puzzles in order to escape!");
            ZorkPrinter.PrintLine("    This will be a test your wit and wisdom");
            ZorkPrinter.PrintLine("");
            ZorkPrinter.PrintLine("    But most importantly, Have fun! :)\n\n");
            
        }

        public override void ReadInput()
        {
            PressAnyKey();
        }

        public override GameState Update()
        {
            return new MainMenu();
        }
    }
}
