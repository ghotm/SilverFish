using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._008GIL
{
    /// <summary>
    /// WANTED!
    /// 通缉令
    /// </summary>
    public class Sim_GIL_687 : SimTemplate
    {
        /// <summary>
        /// Deal $3 damage to a minion. If that kills it, add a Coin to your hand.
        /// 对一个随从造成$3点伤害。如果“通缉令”杀死该随从，将一个幸运币置入你的手牌。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            if (dmg >= target.HealthPoints && !target.DivineShield && !target.immune)
            {
                p.drawACard(CardName.thecoin, ownplay, true);
            }
            p.minionGetDamageOrHeal(target, dmg);
        }
    }
}
