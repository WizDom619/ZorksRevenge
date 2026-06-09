namespace ZorksRevenge
{
    /// <summary>
    /// Zork's Revenge Main
    /// </summary>
    /* I am unsure is having a my second custom main is neccessary. 
     * It just feels cooler though, this is where the real program begins.  
     */
    internal class ZorksRevengeMain
    {
        GameManager _gameManager;

        //First thing all good games should begin with is the Main Menu. 
        public ZorksRevengeMain()
        {
            //Putup the console window configurations. 
            Console.Title = "Zork's Revenge";

            //Usesure if I want this....
            Console.CursorVisible = false;

            Console.Clear();

            //Open with the game's Main Menu.
            _gameManager = new GameManager();
            _gameManager.Update();
        }
    }
}
