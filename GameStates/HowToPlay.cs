using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.GameStates
{
    /// <summary>
    /// This is the How To Play Menu State
    /// Instructions on how how text-based adventures work will go here. 
    /// Once instructions have been read player can press any key to return to the Main Menu. 
    /// </summary>
    public class HowToPlay : GameState
    {
        // Instructions on how how text-based adventures work
        public override void Display(GameData gameData)
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

        public override void ReadInput(GameData gameData)
        {
            PressAnyKey();
        }

        // Once instructions have been read player can press any key to return to the Main Menu.
        public override void Process(GameData gameData)
        {
            gameData.State = new MainMenu();
        }
    }
}
