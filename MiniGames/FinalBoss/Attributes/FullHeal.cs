namespace ZorksRevenge.MiniGames.FinalBoss.Attributes
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
