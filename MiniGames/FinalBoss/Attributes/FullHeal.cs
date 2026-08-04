using ZorksRevenge.MiniGames.FinalBoss.Attributes;

namespace ZorksRevenge
{
    public class FullHeal : mAttribute
    {
        public override void Action()
        {
            int hp = 100 - BattleData.PlayerHP;
            BattleData.UpdatePlayerHP(hp);
        }
    }
}
