using static System.Console;
using static System.ConsoleColor;

namespace ZorksRevenge.ReAssess.Utilities
{
    internal static class ColourPrinter
    {
        public static ConsoleColor RoomColour = DarkYellow;
        public static ConsoleColor ItemColour = DarkCyan;
        public static ConsoleColor PlayerColour = DarkGreen;

        public static void TEST_PrintAllColours()
        {
            BackgroundColor = White;
            WriteLine("Black", Black);
            Write("Diamond ", White);    WriteLine("DarkGray", DarkGray);
            Write("Sapphire ", Blue);   WriteLine("DarkBlue", DarkBlue);
            Write("Emerald ", Green);   WriteLine("DarkGreen", DarkGreen); // Success
            Write("Aquamarine ", Cyan); WriteLine("DarkCyan", DarkCyan); // Item
            Write("Ruby ", Red);        WriteLine("DarkRed", DarkRed); // Enemy, Dies, Error
            Write("Amethyst ", Magenta);WriteLine("DarkMagenta", DarkMagenta);
            Write("Topaz ", Yellow);    WriteLine("DarkYellow", DarkYellow); // Warning. Room
            Write("Gray ", Gray);
            WriteLine("", Black);
        }
        
        public static void Write(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Console.Write(text);
            ResetColor();
        }

        public static void WriteLine(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Console.WriteLine(text);
            ResetColor();
        }   
    }
}