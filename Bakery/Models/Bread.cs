using System;
using System.Collections.Generic;

namespace Bake.Loaves
{
	public class Bread
	{
		public string BreadType { get; set; }
		public int BreadPrice { get; set; }
		public static List<Bread> BreadOrder = new List<Bread> { get; set; }
		public Bread(string breadType, int breadPrice)
		{
			BreadType = breadType;
			BreadPrice = breadPrice;
			_breadOrder.Add(this);
		}
		public static int BreadTab()
		{
			int orderPrice = 0;
			for (int i = 2; i < _breadOrder.Count; i += 3)
			{
				_breadOrder[i].BreadPrice = 0;
			}
			foreach (Bread bread in _breadOrder)
			{
			orderPrice += bread.BreadPrice;
			}
			return orderPrice;
		}
		public static void ClearOrder()
		{
			_breadOrder.Clear();
		}
	}
}