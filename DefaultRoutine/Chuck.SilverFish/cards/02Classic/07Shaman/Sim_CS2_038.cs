namespace Chuck.SilverFish.cards._02Classic._07Shaman
{
	class Sim_CS2_038 : SimTemplate //ancestralspirit
	{

//    verleiht einem diener „todesröcheln:/ ruft diesen diener erneut herbei.“
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            target.ancestralspirit++;
		}

	}
}