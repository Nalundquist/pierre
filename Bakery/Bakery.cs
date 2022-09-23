using System;
using System.Collections.Generic;
using Bake.Loaves;
using Bake.Cakes;

namespace Bake
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("---------------------------");
			Console.WriteLine("Welcome to Pierre's Bakery!");
			Console.WriteLine("---------------------------");
			Console.WriteLine("Breads - $ 5 ||| Pastries - $ 2");
			Console.WriteLine("Deals: ");
			Console.WriteLine("- Buy two loaves of bread, get one Free!");
			Console.WriteLine("- Buy two pastries, get one half off!");
			Console.WriteLine("- 25% off bulk orders of 10 or more loaves of bread *or* 25 or more pastries!");
			Console.WriteLine("Browse our (B)read or (P)astry selections (or any other entry to exit)");
			string userinput1 = Console.ReadLine().ToLower();
			if (userinput1 == "bread" || userinput1 == "b")
			{
				Console.WriteLine("This Week's Breads");
				Console.WriteLine("- (P)umpernickel");
				Console.WriteLine("- (O)live");
				Console.WriteLine("- (W)heat");
				Console.WriteLine("- (C)hallah");
				string userinput2 = Console.ReadLine().ToLower();
				if (userinput2 == "pumpernickel" || userinput2 == "p")
				{
					OrderBread("Pumpernickel", 5);
				}
				else if (userinput2 == "olive" || userinput2 == "o")
				{
					OrderBread("Olive", 5);
				}
				else if (userinput2 == "wheat" || userinput2 == "w")
				{
					OrderBread("Wheat", 5);
				}
				else if (userinput2 == "challah" || userinput2 == "c")
				{
					OrderBread("Challah", 5);
				}
				else {
					Console.WriteLine("Please input a type of bread.");
					Main();
				}
			}
			else if (userinput1 == "Pastry" || userinput1 == "p")
			{
				Console.WriteLine("This Week's Pastrys");
				Console.WriteLine("- (E)clair");
				Console.WriteLine("- (C)roissant");
				Console.WriteLine("- Cream (P)uff");
				Console.WriteLine("- (M)acaron");
				string userinput2 = Console.ReadLine().ToLower();
				if (userinput2 == "eclair" || userinput2 == "e")
				{
					OrderPastry("Eclair", 2);
				}
				else if (userinput2 == "croissant" || userinput2 == "c")
				{
					OrderPastry("Croissant", 2);
				}
				else if (userinput2 == "cream puff" || userinput2 == "creampuff" || userinput2 == "p")
				{
					OrderPastry("Cream Puff", 2);
				}
				else if (userinput2 == "macaron" || userinput2 == "m")
				{
					OrderPastry("Macaron", 2);
				}
				else {
					Console.WriteLine("Please input a type of pastry.");
					Main();
				}
			}
			else
			{
				if (Bread.BreadTab() == 0 && Pastry.PastryTab() == 0)
				{
				Console.WriteLine("Adieu.");
				}
				else
				{
					Console.WriteLine("You have items in your cart and have not checked out.  Would you like to (C)heckout? (Any other key to exit)");
					string userInput3 = Console.ReadLine().ToLower();
					if (userInput3 == "checkout" || userInput3 == "check out" || userInput3 == "c")
					{
						Checkout();
					}
					else
					{
						Console.WriteLine("Adieu.");
					}
				}
			}
		}

		public static void OrderBread(string bread, int price)
		{
			Console.WriteLine("Input the quantity you would like:");
			int userinput = Int32.Parse(Console.ReadLine());
			for (int i=0; i < userinput; i++)
			{
				Bread loaf = new Bread(bread, price);
			}
			Console.WriteLine("Would you like to (O)rder more or (C)heckout?");
			string userInput4 = Console.ReadLine().ToLower();
			if (userInput4 == "checkout" || userInput4 == "check out" || userInput4 == "c")
			{
				Checkout();
			}
			else if (userInput4 == "order" || userInput4 == "o")
			{
				Main();
			}
			else
			{
				Console.WriteLine("Please input either (O)rder or (C)heckout.");
				Main();
			}
		}

		public static void OrderPastry(string pastry, int price)
		{
			Console.WriteLine("Input the quantity you would like:");
			int userinput = Int32.Parse(Console.ReadLine());
			for (int i=0; i < userinput; i++)
			{
				Pastry cake = new Pastry(pastry, price);
			}
			Console.WriteLine("Would you like to (O)rder more or (C)heckout?");
			string userInput4 = Console.ReadLine().ToLower();
			if (userInput4 == "checkout" || userInput4 == "c")
			{
				Checkout();
			}
			else if (userInput4 == "order" || userInput4 == "o")
			{
				Main();
			}
			else
			{
				Console.WriteLine("Please input either (O)rder or (C)heckout.");
				Main();
			}
		}

		public static void Checkout()
		{
			float finalPrice = (Bread.BreadTab() + Pastry.PastryTab());
			if (Bread.Count >= 10 || Pastries.Count >= 25)
			{
				finalPrice *= .75;
			}
			finalPrice.ToString("n2");
			Console.WriteLine("Your final total is $" + finalPrice + ".");
			Console.WriteLine("Enter a name for your order:");
			string userName = Console.ReadLine();
			Console.WriteLine("Thanks very much for your order, " + userName + ".");
			Console.WriteLine("Pick up your order at:");
			Console.WriteLine("Pierre's Bakery");
			Console.WriteLine("123 Fake St NE");
			Console.WriteLine("Newark, NJ 12345");
		}
	}
}