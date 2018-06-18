using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace Capstone.Tests
{
	[TestClass]
	public class ChangeTest
	{
		[TestMethod]
		public void Change_Test_LessThanDollar()
		{
			Change change = new Change(.90M);

			Assert.AreEqual(3, change.Quarters);
			Assert.AreEqual(1, change.Dimes);
			Assert.AreEqual(1, change.Nickels);
			Assert.AreEqual(0, change.Pennies);
		}
		[TestMethod]
		public void Change_Test_MoreThanADollar()
		{

			Change change = new Change(2.65M);

			Assert.AreEqual(10, change.Quarters);
			Assert.AreEqual(1, change.Dimes);
			Assert.AreEqual(1, change.Nickels);
			Assert.AreEqual(0, change.Pennies);



		} 
        
    }
}
