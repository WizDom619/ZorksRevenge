using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    class TestRandomTemp
    {
        // Create All Rooms 
        // And add Items to the Rooms. 
        /*_rooms = new List<Room>
        {
            .AddItem(new Item("Cake", ""))
            .AddNPC(new NPC("Bob")
                .AddInstructions("Play my Game for a prize")
                .AddWant("Rock")
                .AddWant("Skull")
                .AddMiniGame(new FinalBoss())
                .AddPrize(new Item("Gold", "shiney and yellow"))
                )
            .AddContainer(new Container("Box")
                .AddItem(new Item("Fork", "stabby"))),


            new Room("Hallway", "You are in a long hallway")

            new Room("Bedroom", "A room where you sleep")
        }; 

        // Set all paths between Rooms. 
        ConnectPaths(FindRoom("Entry"), Direction.North, FindRoom("Hallway"));
        ConnectPaths(FindRoom("Hallway"), Direction.East, FindRoom("Bedroom"));

        return _rooms;
        
         [DllImport("kernel32.dll")]
        static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        const int STD_OUTPUT_HANDLE = -11;
        const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

        static void EnableAnsiSupport()
        {
            var handle = GetStdHandle(STD_OUTPUT_HANDLE);
            GetConsoleMode(handle, out uint mode);
            SetConsoleMode(handle, mode | ENABLE_VIRTUAL_TERMINAL_PROCESSING);
        }
        
        // EnableAnsiSupport();
        // EnableAnsiSupport();


        //_rooms 


        private static void ConnectExits(Room room1, Direction dir, Room room2)
        {
            room1.Exits[dir] = room2.ID;

            if (dir == Direction.North) { room2.Exits[Direction.South] = room1.ID; }
            else if (dir == Direction.South) { room2.Exits[Direction.North] = room1.ID; }
            else if (dir == Direction.East) { room2.Exits[Direction.West] = room1.ID; }
            else { room2.Exits[Direction.East] = room1.ID; }
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

        */
    }
}
