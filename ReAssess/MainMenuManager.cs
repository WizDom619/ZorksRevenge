using static System.Console;
/* When the game begins there should be an opening menu. 
 * Player can choose a variety of options before beginning a game.  
 */
namespace ZorksRevenge.ReAssess.Managers
{
    internal class MainMenuManager
    {
        
        private bool isMainMenuActive = true;

        // Holds the players response to prompts. 
        MenuState _playerResponse = MenuState.MainMenu;

        public event EventHandler OnNewGame;

        public void Update()
        {
            while (isMainMenuActive)
            {
                PrintTitle();

                switch (_playerResponse)
                {
                    case MenuState.MainMenu: // Default, lists options
                        DisplayOptions();
                        break;

                    case MenuState.NewGame: // Begin a new game;
                        //OnNewGame?.Invoke(this, EventArgs.Empty);
                        isMainMenuActive = false;
                        break;

                    case MenuState.LoadGame: // Load a save
                        break;

                    case MenuState.Instructions: // Print Instructions
                        DisplayInstructions();
                        break;

                    case MenuState.Quit: // Quit Game
                        DisplayQuitGame();
                        break;

                    case MenuState.Invalid:
                        DisplayInvalidResponse();
                        break;
                }
                Clear();
            }
        }

        //A cool title to introduce the game. 
        void PrintTitle()
        {
            WriteLine("Hello and welcome to... \n");
            WriteLine("███████╗ ██████╗ ██████╗ ██╗  ██╗'███████╗    ██████╗ ███████╗██╗   ██╗███████╗███╗   ██╗ ██████╗ ███████╗");
            WriteLine("╚══███╔╝██╔═══██╗██╔══██╗██║ ██╔╝ ██╔════╝    ██╔══██╗██╔════╝██║   ██║██╔════╝████╗  ██║██╔════╝ ██╔════╝");
            WriteLine("  ███╔╝ ██║   ██║██████╔╝█████╔╝  ███████╗    ██████╔╝█████╗  ██║   ██║█████╗  ██╔██╗ ██║██║  ███╗█████╗");
            WriteLine(" ███╔╝  ██║   ██║██╔══██╗██╔═██╗  ╚════██║    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╗██║██║   ██║██╔══╝");
            WriteLine("███████╗╚██████╔╝██║  ██║██║  ██╗ ███████║    ██║  ██║███████╗ ╚████╔╝ ███████╗██║ ╚████║╚██████╔╝███████╗");
            WriteLine("╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚══════╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝");
            WriteLine($"{"A fan game by Dominic Towns",106}\n");
        }
        //Read the player's Input
        void ReadInput()
        {
            Write("Response: ");
            string? unvereifiedResponse = ReadLine();
            int response;

            if (int.TryParse(unvereifiedResponse, out response))
            {
            }
            else
            {
                response = -1;
            }

            switch (response)
            {
                case 0:
                    _playerResponse = MenuState.MainMenu;
                    break;

                case 1:
                    _playerResponse = MenuState.NewGame;
                    break;

                case 2:
                    _playerResponse = MenuState.LoadGame;
                    break;

                case 3:
                    _playerResponse = MenuState.Instructions;
                    break;

                case 4:
                    _playerResponse = MenuState.Quit;
                    break;

                case -1:
                    _playerResponse = MenuState.Invalid;
                    break;
            }
        }
        //Read any key, it doesn't matter what. 
        void ReadAnyKey()
        {
            Write("\n*Press Enter Key* ");
            ReadLine();
            _playerResponse = MenuState.MainMenu;
        }
        //Players options to navigate the main menu
        void DisplayOptions()
        {
            WriteLine("Please Select a Number:\n");
            WriteLine("  (1): New Game");
            WriteLine("  (2): Load Game");
            WriteLine("  (3): Game Instructions");
            WriteLine("  (4): Quit Game\n");
            ReadInput();
        }
        // Instructions on how what this game is and how to play
        void DisplayInstructions()
        {
            WriteLine("Zork's Revenge is a fan made game inspired by the 1977 text based adventure game 'Zork’. The game’s loop involves ");
            WriteLine("typing from a Put of instructions to interact with a virtual text based world (meaning no modern video game graphics).");
            WriteLine("Instructions range from moving, grabbing and using items. This game’s puzzles will test your wit and wisdom in order to escape!\n");
            WriteLine("But most importantly, Have FUN :)");

            ReadAnyKey();
        }
        //Player has Quit the Game
        void DisplayQuitGame()
        {
            //Game has Ended, display a Goodbye Message. 
            WriteLine("Thanks for Playing!");
            ReadAnyKey();
            Environment.Exit(0);
        }

        void DisplayInvalidResponse()
        {
            WriteLine("Please enter a valid response");
            ReadAnyKey();
            _playerResponse = MenuState.MainMenu;
        }
    
    }
}
