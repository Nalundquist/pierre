using System;
using System.Collections.Generic;

namespace Bake.Cakes
{
	public class Pastry
	{
		public string PastryType { get; set; }
		public int PastryPrice { get; set; }
		private static List<Pastry> _pastryOrder = new List<Pastry> {};
		public Pastry(string pastryType, int pastryPrice)
		{
			PastryType = pastryType;
			PastryPrice = pastryPrice;
			_pastryOrder.Add(this);
		}
		public static int PastryTab()
		{
			int orderPrice = 0;
			for (int i = 2; i < _pastryOrder.Count; i += 3)
			{
				_pastryOrder[i].PastryPrice -= 1;
			}
			foreach (Pastry pastry in _pastryOrder)
			{
				orderPrice += pastry.PastryPrice;
			}
			return orderPrice;
		}
		
		public static void ClearOrder()
		{
			_pastryOrder.Clear();
		}
	}
}