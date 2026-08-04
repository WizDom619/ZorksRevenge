using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.MiniGames.FinalBoss.Attributes
{
    public class Stun : mAttribute
    {
        public override void Action()
        {
            BattleData.UpdateEnemyStatus("Stun");
        }
    }
}
