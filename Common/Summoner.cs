﻿using Terraria.ModLoader;

namespace VoidArsenal.Common
{
	public class Summoner : ModPlayer
	{
		public bool auraliteMinion;

		public override void ResetEffects()
		{
			auraliteMinion = false;
		}
	}
}