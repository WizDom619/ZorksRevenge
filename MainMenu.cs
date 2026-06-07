using System;
using static System.Console;

/* When the game begins there should be an opening menu. 
 * Player can choose a variety of options before beginning a game.  
 */
namespace ZorksRevenge
{
    internal class Main_Menu
    {
        enum Player_Response
        {
            main_menu,
            new_game,
            load_game,
            instructions,
            quit
        }

        GameManager game_manager;
        // Holds the players response to prompts. 
        Player_Response player_response  = Player_Response.main_menu;

        public Main_Menu()
        {
            while (true)
            {
                Print_Title();

                switch (player_response)
                {
                    case Player_Response.main_menu: // Default, lists options
                        Display_Options();
                        break;

                    case Player_Response.new_game: // Begin a new game;
                        game_manager = new GameManager();
                        break;

                    case Player_Response.load_game: // Load a save
                        break;

                    case Player_Response.instructions: // Print Instructions
                        Display_Instructions();
                        break;

                    case Player_Response.quit: // Quit Game
                        Display_Quit_Game();
                        break;
                }
                 Clear();
            }
        }

        //A cool title to introduce the game. 
        void Print_Title()
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
        void Read_Input()
        {
            Write("Response: ");

            switch(int.Parse(ReadLine()))
            {
                case 0:
                    player_response = Player_Response.main_menu;
                    break;

                case 1:
                    player_response = Player_Response.new_game;
                    break;

                case 2:
                    player_response = Player_Response.load_game;
                    break;

                case 3:
                    player_response = Player_Response.instructions;
                    break;

                case 4:
                    player_response = Player_Response.quit;
                    break;
            }
        }
        //Read any key, it doesn't matter what. 
        void Read_Any_Key()
        {
            Write("\n*Press Enter Key* ");
            ReadLine();
            player_response = Player_Response.main_menu;
        }
        //Players options to navigate the main menu
        void Display_Options()
        {
            WriteLine("Please Select a Number:\n");
            WriteLine("  (1): New Game");
            WriteLine("  (2): Load Game");
            WriteLine("  (3): Game Instructions");
            WriteLine("  (4): Quit Game\n");
            Read_Input();
        }
        // Instructions on how what this game is and how to play
        void Display_Instructions()
        {
            WriteLine("Zork's Revenge is a fan made game inspired by the 1977 text based adventure game 'Zork’. The game’s loop involves ");
            WriteLine("typing from a Put of instructions to interact with a virtual text based world (meaning no modern video game graphics).");
            WriteLine("Instructions range from moving, grabbing and using items. This game’s puzzles will test your wit and wisdom in order to escape!\n");
            WriteLine("But most importantly, Have FUN :)");

            Read_Any_Key();
        }
        //Player has Quit the Game
        void Display_Quit_Game()
        {
            //Game has Ended, display a Goodbye Message. 
            WriteLine("Thanks for Playing!");
            Read_Any_Key();
            Environment.Exit(0);
        }
    }
}
