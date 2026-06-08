using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge
{
    class TestRandomTemp
    {
    }
}

// Fills screen, looks bad. 
/*public static void Test()
        {
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.White;
            Clear();

            WriteLine("Welcome to Zork's Revenge!");
            WriteLine("The dungeon is dark...");

            ReadLine();
        }
        /*public static void SetDarkDungeon()
        {
            BackgroundColor = Black;
            ForegroundColor = DarkGray;
            Clear();
        }

        public static void SetCaveBlue()
        {
            BackgroundColor = DarkBlue;
            ForegroundColor = Gray;
            Clear();
        }

        public static void SetHell()
        {
            BackgroundColor = DarkRed;
            ForegroundColor = Yellow;
            Clear();
        }

        public static void Success(string text)
            => WriteLine(text, ConsoleColor.Green);

        public static void Error(string text)
            => WriteLine(text, ConsoleColor.Red);

        public static void Info(string text)
            => WriteLine(text, ConsoleColor.Cyan);

        public static void Warning(string text)
            => WriteLine(text, ConsoleColor.Yellow);

 
        

        private static Random rng = new Random();

        public static void Flicker(string text, int times = 30)
        {
            ConsoleColor[] flickerColors =
            {
                ConsoleColor.DarkYellow,
                ConsoleColor.Yellow,
                ConsoleColor.DarkRed,
                ConsoleColor.Red,
                ConsoleColor.Gray
            };

            for (int i = 0; i < times; i++)
            {
                ConsoleColor color = flickerColors[rng.Next(flickerColors.Length)];

                ForegroundColor = color;
                ClearLine();
                Write("\r" + text);

                Thread.Sleep(80);
            }

            ResetColor();
            WriteLine();
        }


        private static void ClearLine()
        {
            Write("\r" + new string(' ', 80) + "\r");
        }*/