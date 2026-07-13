namespace ZorksRevenge.GameStates
{
    internal class GameState
    {
        protected string? _response = "";

        public virtual void Display() { }  
        public virtual void ReadInput()
        {
            _response = null;

            ZorkPrinter.Print(":> ");
            _response = Console.ReadLine();

            // A check incase the player enters nothing the returns a NULL
            if (_response == null)
            {
                _response = "-1";
            }
        }
        public virtual GameState? Update() { return null; }

        protected void PressAnyKey()
        {
            ZorkPrinter.PrintLine(" *Press Any Key*");

            Console.ReadLine();
        }
    }
}
