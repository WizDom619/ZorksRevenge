namespace ZorksRevenge.Test
{
    /// <summary>
    /// The Menu Handler that holds the where the Menu System is managed. 
    /// </summary>    
    public class MenuHandler
    {
        /*// While this is srue, the game will be in the Menu state. 
        private bool inMenu = true;

        // A Dictionary of all the Menu States and their Classes. 
        private readonly Dictionary<MenuState, MenuBase> _menus;

        // The enum that ditermines the current menu state. 
        private MenuState _currentState = MenuState.MainMenu;

        public MenuHandler()
        {
            _menus = new Dictionary<MenuState, MenuBase>
            {
                { MenuState.MainMenu, new MainMenu() },
                { MenuState.NewGame, new NewGame() },
                { MenuState.LoadGame, new LoadGame() },
                { MenuState.HowToPlay, new HowToPlayMenu() },
                { MenuState.Quit, new QuitGame() }
            };            
        }

        public void Update()
        {
            while (inMenu)
            {
                // Firstly display the menu to the player. 
                _menus[_currentState].Display();

                // Read the player's input 
                string response = ReadInput();

                // The Transition to the next menu is relative to it's current state. 
                // So each menu processes the input to ditermine which is the next state. 
                _currentState = _menus[_currentState].TransitionTo(response);

                // New Game and Load Game are not menu states.
                // So we no longer need to be in the main menu. 
                if (_currentState == MenuState.NewGame ||
                    _currentState == MenuState.LoadGame)
                {
                    inMenu = false;
                }

            }
        }

        private string ReadInput()
        {
            
        }*/
    }
}