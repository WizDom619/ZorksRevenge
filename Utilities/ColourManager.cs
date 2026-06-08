using static System.Console;
using static System.ConsoleColor;

namespace ZorksRevenge.Utilities
{
    internal static class ColourManager
    {
        public static void TEST_PrintAllColours()
        {
            BackgroundColor = White;
            WriteLine("Black", Black);
            WriteLine("DarkBlue", DarkBlue);
            WriteLine("DarkGreen", DarkGreen);
            WriteLine("DarkCyan", DarkCyan);
            WriteLine("DarkRed", DarkRed);
            WriteLine("DarkMagenta", DarkMagenta);
            WriteLine("DarkYellow", DarkYellow);
            WriteLine("Gray", Gray);
            WriteLine("DarkGray", DarkGray);
            WriteLine("Blue", Blue);
            WriteLine("Green", Green); // Success
            WriteLine("Cyan", Cyan); // Item
            WriteLine("Red", Red); // Enemy, Dies, Error
            WriteLine("Magenta", Magenta);
            WriteLine("Yellow", Yellow); // Warning. Room
            WriteLine("White", White);
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