using System.Collections.Generic;
using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._006ICC
{
    class Sim_ICC_252: SimTemplate //* Coldwraith
    {
        // Battlecry: If an enemy is Frozen, draw a card.

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            bool frozen = false;
            if (m.own ? p.enemyHero.frozen : p.ownHero.frozen) frozen = true;

            if (!frozen)
            {
                List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
                foreach (Minion mnn in temp)
                {
                    if (mnn.frozen)
                    {
                        frozen = true;
                        break;
                    }
                }
            }

            if (frozen) p.drawACard(CardName.unknown, m.own);
        }
    }
}