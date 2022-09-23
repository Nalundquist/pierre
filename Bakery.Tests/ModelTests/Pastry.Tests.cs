using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bake.Cakes;
using System;

namespace Bake.Cakes.Tests
{
	[TestClass]
	public class PastryTests : IDisposable
	{
		public void Dispose()
		{
			Pastry.ClearOrder();
		}

		[TestMethod]
		public void Pastry_HoldsLoaf_True()
		{
			Pastry newEclair = new Pastry("Eclair", 2);
			Assert.AreEqual("Eclair", newEclair.PastryType);
		}		
		[TestMethod]
		public void Pastry_HoldsPrice_True()
		{
			Pastry newEclair = new Pastry("Eclair", 2);
			Assert.AreEqual(2, newEclair.PastryPrice);
		}
		[TestMethod]
		public void PastryTab_ReturnsPastryPrices_True()
		{
			Pastry newEclair = new Pastry("Eclair", 2);
			Pastry newCrois = new Pastry("Croissant", 2);
			Assert.AreEqual(4, Pastry.PastryTab());
		}
		[TestMethod]
		public void PastryTab_ReturnsDiscountPrice_True()
		{
			Pastry newEclair = new Pastry("Eclair", 2);
			Pastry newCrois = new Pastry("Croissant", 2);
			Pastry newEclair2 = new Pastry("Eclair", 2);
			Pastry newCrois2 = new Pastry("Croissant", 2);
			Pastry newEclair3 = new Pastry("Eclair", 2);
			Pastry newCrois3 = new Pastry("Croissant", 2);
			Pastry newCrois4 = new Pastry("Croissant", 2);
			Pastry newEclair4 = new Pastry("Eclair", 2);
			Pastry newCrois5 = new Pastry("Croissant", 2);
			Assert.AreEqual(15, Pastry.PastryTab());
		}
	}
}