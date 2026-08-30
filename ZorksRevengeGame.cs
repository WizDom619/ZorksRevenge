using System.Runtime.InteropServices;

namespace ZorksRevenge
{
    /// <summary>
    /// The begginning of the Zork's Revenge Game
    /// Before the game actually starts, this is a good place to set all the console window configurations.  
    /// Such as... Title, Cursor Visibility, Screen Size or Margin Size. 
    /// Afterwards, instantiate a GameManager and the game actually begins. 
    /// </summary>
    public class ZorksRevengeGame
    {
        private GameManager _gameHandler;
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

        public ZorksRevengeGame()
        {
            //Set the window title. 
            Console.Title = "Zork's Revenge";

            //Set cursor visibility
            //TODO Unsure if I want this true of false... 
            Console.CursorVisible = false;

            //Clears to screen incase of any initial loading output. 
            //Guarantee a clean slate to begin the game. 
            Console.Clear();

            EnableAnsiSupport();

            //Begin the game with the Game Manager
            _gameHandler = new GameManager();
        }
    }
}
