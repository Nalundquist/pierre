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
			Console.WriteLine("- Buy Two Loaves of Bread, Get One Free!");
			Console.WriteLine("- Buy Two Pastries, get one half off!");
			Console.WriteLine("Browse our (B)read or (P)astry selections (or any other entry to exit)");
			string userInput = Console.ReadLine().ToLower();
			if (userInput == "bread" || userInput == "b")
			{
				Console.WriteLine("This Week's Breads");
				Console.WriteLine("- (P)umpernickel");
				Console.WriteLine("- (O)live");
				Console.WriteLine("- (W)heat");
				Console.WriteLine("- (C)hallah");
				string userInput2 = Console.ReadLine().ToLower();
				if (userInput2 == "pumpernickel" || userInput2 == "p")
				{
					OrderBread("Pumpernickel", 6);
				}
				else if (userInput2 == "olive" || userInput2 == "o")
				{
					OrderBread("Olive", 6);
				}
				else if (userInput2 == "wheat" || userInput2 == "w")
				{
					OrderBread("Wheat", 5);
				}
				else if (userInput2 == "challah" || userInput2 == "c")
				{
					OrderBread("Challah", 7);
				}
				else {
					Console.WriteLine("Please input a type of bread.");
					Main();
				}
			}
			else if (userInput == "Pastry" || userInput == "p")
			{
				Console.WriteLine("This Week's Pastrys");
				Console.WriteLine("- (E)clair");
				Console.WriteLine("- (C)roissant");
				Console.WriteLine("- Cream (P)uff");
				Console.WriteLine("- (M)acaron");
				string userInput2 = Console.ReadLine().ToLower();
				if (userInput2 == "eclair" || userInput2 == "e")
				{
					OrderPastry("Eclair", 2);
				}
				else if (userInput2 == "croissant" || userInput2 == "c")
				{
					OrderPastry("Croissant", 2);
				}
				else if (userInput2 == "cream puff" || userInput2 == "creampuff" || userInput2 == "p")
				{
					OrderPastry("Cream Puff", 2);
				}
				else if (userInput2 == "macaron" || userInput2 == "m")
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
			int userInput = 0;
			if (Int32.TryParse(Console.ReadLine(), out userInput) == false)
			{
				Console.WriteLine("Please input a number.");
				Main();
			}
			for (int i=0; i < userInput; i++)
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
			int userInput = 0;
			if (Int32.TryParse(Console.ReadLine(), out userInput) == false)
			{
				Console.WriteLine("Please input a number.");
				Main();
			}
			for (int i=0; i < userInput; i++)
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
			Console.WriteLine("Your final total is $" + (Bread.BreadTab() + Pastry.PastryTab()) + ".");
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