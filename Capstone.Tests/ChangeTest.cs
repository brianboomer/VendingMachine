using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace Capstone.Tests
{
    [TestClass]
    public class ChangeTest
    {
		[TestMethod]
		public void Change_Test()
		{
			//arrange
			VendingMachine changeTest = new VendingMachine();

			//act
			changeTest.ReturnChange();
			//assert



		}
        
    }
}
