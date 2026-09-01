using ZorksRevenge.Data;

namespace ZorksRevenge.MiniGames
{
    /// <summary>
    /// MiniGames are object that contain some kind of challenge. 
    /// The player will Play() challenge.
    /// Each challenge will continuous loop until the task is complete. 
    /// 
    /// Now that I think about kid MiniGames could have been a different kind of state
    /// Much like Campaign and the Menu States. 
    /// If I were to ever build this game again Minigames would just be a kind of GameState. 
    /// </summary>
    public abstract class MiniGame
    {
        public MiniGame()
        {
        }

        // If either constructors are called an error has gone wrong. 
        public virtual bool Play()
        {
            Console.WriteLine("ERROR: called the wrong constructor");
            return false;
        }

        // This constructor will only be called for the FinalBoss() Minigame. 
        public virtual bool Play(GameData gameData)
        {
            Console.WriteLine("ERROR: called the wrong constructor");
            return false;
        }
    }
}
