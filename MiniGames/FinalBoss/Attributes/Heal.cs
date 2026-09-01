namespace ZorksRevenge.MiniGames.FinalBoss.Attributes
{
    public class Heal : mAttribute
    {
        private int _hp; 

        public Heal (int hp)
        {
            _hp = hp;
        }
        public override void Action()
        {
            BattleData.UpdatePlayerHP(_hp);
        }
    }
}
