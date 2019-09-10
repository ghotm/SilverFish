using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_809 : SimTemplate //* Fire Fly
	{
		//Battlecry: Add a 1/2 Elemental to your hand.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardIdEnum.UNG_809t1, own.own, true);
        }
	}
}