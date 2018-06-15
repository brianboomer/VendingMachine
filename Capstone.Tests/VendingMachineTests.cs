using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;

namespace Capstone.Tests
{
	[TestClass]
	public class VendingMachineTests
	{
		[TestMethod]
		public void Deposit_Test()
		{
			VendingMachine depositTest = new VendingMachine();

			decimal depo = depositTest.Deposit(10, 0);

			Assert.AreEqual(10, depo);
		}

		[TestMethod]
		public void Purchase_Test()
		{
			VendingMachine purchaseItem = new VendingMachine();
			string[] stringArray = new string[4] { "Test1", "1", "Test3", "Test4" };
			Item item = new Item(stringArray);
			List<Item> listOfItems = new List<Item>();
			listOfItems.Add(item);

			Dictionary<string, List<Item>> inventory = new Dictionary<string, List<Item>>();
			inventory.Add("A1", listOfItems);
			inventory.Add("A1", listOfItems);

			purchaseItem.Purchase();

			Assert.AreEqual(1, inventory["A1"].Count);
		
			

			



		}
	}
}
