using static System.Console;
using static System.ConsoleColor;

namespace ZorksRevenge.Utilities
{
    internal static class ColourPrinter
    {
        public static ConsoleColor RoomColour = DarkYellow;
        public static ConsoleColor ItemColour = DarkCyan;
        public static ConsoleColor PlayerColour = DarkGreen;

        public static void TEST_PrintAllColours()
        {
            BackgroundColor = White;
            Write("Black", Black);      WriteLine(" White", White);
            Write("Gray ", Gray);       WriteLine("DarkGray", DarkGray);
            Write("Blue ", Blue);       WriteLine("DarkBlue", DarkBlue);
            Write("Green ", Green);     WriteLine("DarkGreen", DarkGreen); // Success
            Write("Cyan ", Cyan);       WriteLine("DarkCyan", DarkCyan); // Item
            Write("Red ", Red);         WriteLine("DarkRed", DarkRed); // Enemy, Dies, Error
            Write("Magenta ", Magenta); WriteLine("DarkMagenta", DarkMagenta);
            Write("Yellow ", Yellow);   WriteLine("DarkYellow", DarkYellow); // Warning. Room
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