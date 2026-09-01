using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames.FinalBoss.Attributes
{
    public class Stun : mAttribute
    {
        public override void Action()
        {
            BattleData.UpdateEnemyStatus(Status.Stun);
        }
    }
}
