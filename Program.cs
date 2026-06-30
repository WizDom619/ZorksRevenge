namespace ZorksRevenge
{
    /// <summary>
    /// This is the Main of the Program. 
    /// To keep things clean I just created the game's actual Main.
    /// So all the program has to do it 'Start'
    /// </summary>
    class Program
    {
        private static ZorksRevengeGame game;
        static void Main(string[] args)
        {
            game = new ZorksRevengeGame();
        }
    }
}
