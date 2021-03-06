using Chuck.SilverFish;
using SilverFish.Helpers;

namespace SilverFish._cards._04Expansion._011DAL
{
    /// <summary>
    /// EVIL Cable Rat
    /// 怪盗布缆鼠
    /// </summary>
    public class Sim_DAL_400 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Add a Lackey to your hand.
        /// 战吼：将一张跟班牌置入你的手牌。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            var cardIdEnum = LackeyHelper.Instance.GetRandomLackey();
            p.drawACard(cardIdEnum, own.own, true);
        }
    }
}