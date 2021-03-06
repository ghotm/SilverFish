using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_625t : SimTemplate //* Mind Spike
	{
		//Hero Power: Deal 2 damage.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
		}
	}
}