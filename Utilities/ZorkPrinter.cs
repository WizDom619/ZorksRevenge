using static System.Console;
using static System.ConsoleColor;

/// <summary>
/// The Zork Printer is a static printer class that handels all Print()'s to Console. 
/// The additional features available over the Console.WriteLine() is...
/// Coloured Text, Italic, Underline, Blinking, Strike.  
/// </summary>
namespace ZorksRevenge.Utilities
{
    internal static class ZorkPrinter
    {
        //TODO Confirm Game Objects spefic colours. 
        public static ConsoleColor RoomColour = DarkYellow;
        public static ConsoleColor ItemColour = DarkCyan;
        public static ConsoleColor PlayerColour = DarkGreen;

        // The speed of the printing effect. 
        private static int _printSpeed = 5;

        // The default colour of all text, unless otherwise specified 
        private static ConsoleColor _color = Gray;

        // The default PrintEffects of all text, unless otherwise specified 
        private static PrintEffect _effect = PrintEffect.NULL; 


        // A testing method to show off all colours available to print. 
        public static void TEST_PrintAllColours()
        {
            BackgroundColor = White;
            WriteLine("Black", Black);
            Write("Diamond ", White);   WriteLine("DarkGray", DarkGray);
            Write("Sapphire ", Blue);   WriteLine("DarkBlue", DarkBlue);
            Write("Emerald ", Green);   WriteLine("DarkGreen", DarkGreen); // Success
            Write("Aquamarine ", Cyan); WriteLine("DarkCyan", DarkCyan); // Item
            Write("Ruby ", Red);        WriteLine("DarkRed", DarkRed); // Enemy, Dies, Error
            Write("Amethyst ", Magenta);WriteLine("DarkMagenta", DarkMagenta);
            Write("Topaz ", Yellow);    WriteLine("DarkYellow", DarkYellow); // Warning. Room
            Write("Gray ", Gray);
            WriteLine("", Black);
        }

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
            char[] textBrokenUP = text.ToCharArray();
            Write("> ");
            foreach (char c in textBrokenUP)
            {
                Write($"{effect}{c}");
                Thread.Sleep(_printSpeed);
            }
            Write("\u001b[0m");

            // If it's a PrintLine(), then finish with a new line. 
            if (isNewLine)
            {
                Console.Write('\n');
            }            
        }

        // All Write() / WriteLine() methods call the same Print(),
        // They just filter the parameters going into Print().
        // If the parameter is not provided the corosponding field will substitue instead. 
        public static void Print(string text)
        {
            Print(text, _color, _effect, false);
        }
        public static void Print(string text, ConsoleColor color)
        {
            Print(text, color, _effect, false);
        }
        public static void Print(string text, ConsoleColor color, PrintEffect parEffect)
        {
            Print(text, color, parEffect, false);
        }
        public static void PrintLine(string text)
        {
            Print(text, _color, _effect, true);
        }
        public static void PrintLine(string text, ConsoleColor color)
        {
            Print(text, color, _effect, true);
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
    }
}