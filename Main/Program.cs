namespace ZorksRevenge.Main
{
    /// <summary>
    /// This is the Main of the while program. 
    /// Keeping things clean, all the Main has to do is start
    /// </summary>
    class Program
    {        
        static void Main(string[] args)
        {
            // Instantiate and Run the game 
            ZorksRevengeGame game = new ZorksRevengeGame();
            game.Run();
        }
    }
}
