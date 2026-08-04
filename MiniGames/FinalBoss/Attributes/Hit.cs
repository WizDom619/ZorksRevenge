using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.MiniGames.FinalBoss.Attributes
{
    public class Hit : mAttribute
    {
        private int _dmg;

        public Hit(int dmg)
        {
            _dmg = dmg;
        }

        public override void Action()
        {
            BattleData.UpdateEnemyHP(_dmg);
        }
    }
}
