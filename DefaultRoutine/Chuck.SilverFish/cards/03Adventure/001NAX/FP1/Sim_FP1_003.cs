using System.Collections.Generic;
using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._001NAX.FP1
{
    class Sim_FP1_003 : SimTemplate //* Echoing Ooze
	{
        //Battlecry: Summon an exact copy of this minion at the end of the turn.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.playedThisTurn && triggerEffectMinion.own == turnEndOfOwner)
            {
                p.CallKid(triggerEffectMinion.handcard.card, triggerEffectMinion.zonepos, turnEndOfOwner);
                List<Minion> temp = (turnEndOfOwner) ? p.ownMinions : p.enemyMinions;
                foreach (Minion mnn in temp)
                {
                    if (mnn.name == CardName.echoingooze && triggerEffectMinion.entitiyID != mnn.entitiyID)
                    {
                        mnn.setMinionToMinion(triggerEffectMinion);
                        break;
                    }
                }
            }
        }

	}
}