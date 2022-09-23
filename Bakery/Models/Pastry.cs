using System;
using System.Collections.Generic;
using Bake.Loaves;

namespace Bake.Cakes
{
	public class Pastry : BakedGood
	{
		Order pastryOrder = new Order<Pastry> {};
		public Bread(string pastryType, int pastryPrice)
		{
			BakedType = pastryType;
			BakedPrice = pastryPrice;
			pastryOrder.Add(this);
		}
		public static int pastryTab(){
			for (int i = 2; i < pastryOrder.Count; i += 3)
			{
				pastryOrder[i].BakedPrice = 0;
			}
			return OrderTab(breadOrder);
		}
	}
}