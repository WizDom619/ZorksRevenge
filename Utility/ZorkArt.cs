using static System.Console;
using static System.ConsoleColor;

namespace ZorksRevenge.Utility
{
    /// <summary>
    /// This call will print all artworks in the game. 
    /// </summary>
    public static class ZorkArt
    {
        /// <summary>
        /// To be used in the game's menus. 
        /// </summary>
        public static void PrintTitle()
        {
            ZorkPrinter.PrintLine("Hello and welcome to...\n");
            WriteLine("███████╗ ██████╗ ██████╗ ██╗  ██╗'███████╗    ██████╗ ███████╗██╗   ██╗███████╗███╗   ██╗ ██████╗ ███████╗");
            WriteLine("╚══███╔╝██╔═══██╗██╔══██╗██║ ██╔╝ ██╔════╝    ██╔══██╗██╔════╝██║   ██║██╔════╝████╗  ██║██╔════╝ ██╔════╝");
            WriteLine("  ███╔╝ ██║   ██║██████╔╝█████╔╝  ███████╗    ██████╔╝█████╗  ██║   ██║█████╗  ██╔██╗ ██║██║  ███╗█████╗");
            WriteLine(" ███╔╝  ██║   ██║██╔══██╗██╔═██╗  ╚════██║    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╗██║██║   ██║██╔══╝");
            WriteLine("███████╗╚██████╔╝██║  ██║██║  ██╗ ███████║    ██║  ██║███████╗ ╚████╔╝ ███████╗██║ ╚████║╚██████╔╝███████╗");
            WriteLine("╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚══════╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝");
            ZorkPrinter.PrintLine($"{"A fan game by " + GameConstants.GameCreator + " " + GameConstants.Version,106}\n");
        }

        /// <summary>
        /// To be used in the finalie to thank the player. 
        /// </summary>
        public static void PrintEnd()
        {
            ZorkPrinter.PrintLine("", Red);
            ZorkPrinter.PrintLine("           ***************           ***************", Red);
            ZorkPrinter.PrintLine("        *****           *****     *****           *****", Red);
            ZorkPrinter.PrintLine("      ****                 *********                 ****", Red);
            ZorkPrinter.PrintLine("     ****                                               ****", Red);
            ZorkPrinter.PrintLine("    ***                                                   ***", Red);
            ZorkPrinter.PrintLine("   ***                                                     ***", Red);
            ZorkPrinter.PrintLine("  ***                  Thanks for Playing,                  ***", Red);//
            ZorkPrinter.PrintLine("  ***                        The End                        ***", Red);
            ZorkPrinter.PrintLine("  ***                                                       ***", Red);
            ZorkPrinter.PrintLine("  ***      Secret Message so I know you beat the game:      ***", Red);
            ZorkPrinter.PrintLine("  ***                  In my eye, Pizza Pie!                ***", Red);
            ZorkPrinter.PrintLine("  ***                                                       ***", Red);
            ZorkPrinter.PrintLine("   ***                                                     ***", Red);//
            ZorkPrinter.PrintLine("    ***                                                   ***", Red);
            ZorkPrinter.PrintLine("     ****                                               ****", Red);
            ZorkPrinter.PrintLine("       ****                                           ****", Red);
            ZorkPrinter.PrintLine("         *****                                     *****", Red);
            ZorkPrinter.PrintLine("           ******                               ******", Red);
            ZorkPrinter.PrintLine("              ******                         ******", Red);
            ZorkPrinter.PrintLine("                 ******                   ******", Red);
            ZorkPrinter.PrintLine("                    ******             ******", Red);
            ZorkPrinter.PrintLine("                       ******       ******", Red);
            ZorkPrinter.PrintLine("                          *************", Red);
            ZorkPrinter.PrintLine("                             *******", Red);
            ZorkPrinter.PrintLine("                                *", Red);

            while (true)
            {
                ReadLine();
            }
        }

        public static void PrintRoomArt(string roomId)
        {
            switch (roomId)
            {
                case "R001":
                    break;
            }
        }
    }
}
