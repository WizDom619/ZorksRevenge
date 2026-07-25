using static System.Console;
using static System.ConsoleColor;

/// <summary>
/// The Zork Printer is a static printer class that handels all Print()'s to Console. 
/// The additional features available over the Console.WriteLine() is...
/// Coloured Text, Italic, Underline, Blinking, Strike.  
/// </summary>
namespace ZorksRevenge
{
    internal static class ZorkPrinter
    {
        //TODO Confirm Game Objects spefic colours. 
        public static ConsoleColor ItemColour = DarkCyan;
        public static ConsoleColor RoomColour = DarkMagenta;
        public static ConsoleColor PlayerColour = DarkGreen;
        public static ConsoleColor NPCColour = DarkRed;

        // The speed of the printing effect. (25) 
        private static int _printSpeed = 1;        

        // This Method is the main Print method. 
        private static void Print(string text, ConsoleColor color, PrintEffect parEffect, bool isNewLine)
        {
            // Set the colour, 
            ForegroundColor = color;
            // Set the Effect
            string effect = "";

            if (parEffect != PrintEffect.NULL)
            {
                effect = $"\u001b" + SetEffect(parEffect);
            }

            // Turn the parameter string into an arrays of chars. 
            // This will print each char with a small delay. 
            // This give the ouput a typing effect, letter by letter.
            // Easier on the eyes than a wall of text instantly appearing. 
            // Print by letter
                //char[] textBrokenUP = text.ToCharArray();
            // Print by word. 
            string[] textBrokenUP = text.Split(" ");
            Write("");
            for (int i = 0; i < textBrokenUP.Length; i++)
            {
                string c = textBrokenUP[i];
                // This is so there isn't a space on the final word of a print. This messessup other formatting. 
                bool isLast = i == textBrokenUP.Length - 1;

                if (isLast)
                {
                    Write($"{effect}{c}");
                }
                else
                {
                    Write($"{effect}{c} ");
                }
                
                Thread.Sleep(_printSpeed);
            }
            Write("\u001b[0m");

            // If it's a PrintLine(), then finish with a new line. 
            if (isNewLine)
            {
                Console.Write('\n');
            }
            ResetColor();
        }

        // All Write() / WriteLine() methods call the same Print(),
        // They just filter the parameters going into Print().
        // If the parameter is not provided the corosponding field will substitue instead. 
        public static void Print(string text)
        {
            Print(text, Gray, PrintEffect.NULL, false);
        }
        public static void Print(string text, ConsoleColor color)
        {
            Print(text, color, PrintEffect.NULL, false);
        }
        public static void Print(string text, ConsoleColor color, PrintEffect parEffect)
        {
            Print(text, color, parEffect, false);
        }
        public static void PrintLine(string text)
        {
            Print(text, Gray, PrintEffect.NULL, true);
        }
        public static void PrintLine(string text, ConsoleColor color)
        {
            Print(text, color, PrintEffect.NULL, true);
        }
        public static void PrintLine(string text, ConsoleColor color, PrintEffect parEffect)
        {
            Print(text, color, parEffect, true);
        }
        
        // This method turns the PrintEffect Enum into the appropriate ASCII Escape character.
        // Returns the string to be placed in the interpolated string.  
        private static string SetEffect(PrintEffect effect)
        {
            switch(effect)
            {
                case PrintEffect.Italic:
                    return "[3m";

                case PrintEffect.Underline:
                    return "[4m";

                case PrintEffect.Blinking:
                    return "[5m";

                case PrintEffect.Strike:
                    return "[9m";
            }

            // If the switch does not return an escape character,
            // This means no effect was applied. 
            return "";
        }

        // This method prints a cool title for the game. To be used in the game's menus. 
        public static void PrintTitle()
        {
            PrintLine("Hello and welcome to...\n");
            WriteLine("███████╗ ██████╗ ██████╗ ██╗  ██╗'███████╗    ██████╗ ███████╗██╗   ██╗███████╗███╗   ██╗ ██████╗ ███████╗");
            WriteLine("╚══███╔╝██╔═══██╗██╔══██╗██║ ██╔╝ ██╔════╝    ██╔══██╗██╔════╝██║   ██║██╔════╝████╗  ██║██╔════╝ ██╔════╝");
            WriteLine("  ███╔╝ ██║   ██║██████╔╝█████╔╝  ███████╗    ██████╔╝█████╗  ██║   ██║█████╗  ██╔██╗ ██║██║  ███╗█████╗");
            WriteLine(" ███╔╝  ██║   ██║██╔══██╗██╔═██╗  ╚════██║    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╗██║██║   ██║██╔══╝");
            WriteLine("███████╗╚██████╔╝██║  ██║██║  ██╗ ███████║    ██║  ██║███████╗ ╚████╔╝ ███████╗██║ ╚████║╚██████╔╝███████╗");
            WriteLine("╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚══════╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝");
            PrintLine($"{"A fan game by Dominic Towns. Version 1.3",106}\n");
        }
        public static void PrintAllColours()
        {
            BackgroundColor = Black;
            PrintLine("Black", Black);
            Print("Diamond", White); PrintLine("   DarkGray", DarkGray);
            Print("Sapphire", Blue); PrintLine("  DarkBlue", DarkBlue);
            Print("Emerald", Green); PrintLine("   DarkGreen", DarkGreen); // Success
            Print("Aquamarine", Cyan); PrintLine("DarkCyan", DarkCyan); // Item
            Print("Ruby", Red); PrintLine("      DarkRed", DarkRed); // Enemy, Dies, Error
            Print("Amethyst", Magenta); PrintLine("  DarkMagenta", DarkMagenta);
            Print("Topaz", Yellow); PrintLine("     DarkYellow", DarkYellow); // Warning. Room
            Print("Gray", Gray);
            PrintLine("", Black);
        }

        public static void PrintEnd()
        {
            ZorkPrinter.PrintLine("", ConsoleColor.Red);
            ZorkPrinter.PrintLine("           ***************           ***************", ConsoleColor.Red);
            ZorkPrinter.PrintLine("        *****           *****     *****           *****", ConsoleColor.Red);
            ZorkPrinter.PrintLine("      ****                 *********                 ****", ConsoleColor.Red);
            ZorkPrinter.PrintLine("     ****                                               ****", ConsoleColor.Red);
            ZorkPrinter.PrintLine("    ***                                                   ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("   ***                                                     ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("  ***                                                       ***", ConsoleColor.Red);//
            ZorkPrinter.PrintLine("  ***                                                       ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("  ***                                                       ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("  ***                   Thanks for Playing,                 ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("  ***                        The End                        ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("  ***                                                       ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("   ***                                                     ***", ConsoleColor.Red);//
            ZorkPrinter.PrintLine("    ***                                                   ***", ConsoleColor.Red);
            ZorkPrinter.PrintLine("     ****                                               ****", ConsoleColor.Red);
            ZorkPrinter.PrintLine("       ****                                           ****", ConsoleColor.Red);
            ZorkPrinter.PrintLine("         *****                                     *****", ConsoleColor.Red);
            ZorkPrinter.PrintLine("           ******                               ******", ConsoleColor.Red);
            ZorkPrinter.PrintLine("              ******                         ******", ConsoleColor.Red);
            ZorkPrinter.PrintLine("                 ******                   ******", ConsoleColor.Red);
            ZorkPrinter.PrintLine("                    ******             ******", ConsoleColor.Red);
            ZorkPrinter.PrintLine("                       ******       ******", ConsoleColor.Red);
            ZorkPrinter.PrintLine("                          *************", ConsoleColor.Red);
            ZorkPrinter.PrintLine("                             *******", ConsoleColor.Red);
            ZorkPrinter.PrintLine("                                *", ConsoleColor.Red);
        }
    }
}