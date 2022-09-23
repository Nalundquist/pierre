using System;
using System.Collections.Generic;

namespace Bake.Loaves
{
	abstract class BakedGood
	{
		public string BakedType { get; set; }
		public int BakedPrice { get; set; }
		public Order()
		{
			List<Item> BakedGoods = new List<Item> {};
		}

		public static int OrderTab(List order)
		{
			int orderPrice = 0;
			foreach (BakedGood good in order)
			{
			orderPrice += good.BakedPrice;
			}
			return orderPrice;
		}

		public static void ClearOrder()
		{
			Order.Clear();
		}
	}

	public class Bread : BakedGood
	{
		Order breadOrder = new Order<Bread> {};
		public Bread(string breadType, int breadPrice)
		{
			BakedType = breadType;
			BakedPrice = breadPrice;
			breadOrder.Add(this);
		}
		public static int BreadTab(){
			for (int i = 2; i < breadOrder.Count; i += 3)
			{
				breadOrder[i].BakedPrice = 0;
			}
			return OrderTab(breadOrder);
		}
	}
}