using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class VendingMachine
	{
		

		// CONSTRUCTOR
		public VendingMachine() //(decimal balance, decimal amountToDeposit)
		{
			//this.Balance = balance;
			//this.AmountToDeposit = amountToDeposit;
		}

		// PROPERTIES
		public decimal Balance { get; set; }
		public decimal AmountToDeposit { get; set; }


		// METHODS
		public decimal Deposit(decimal amountToDeposit, decimal startingBalance)
		{
			// Declare the output variable
			decimal updatedBalance = startingBalance;

			// Add the amount to deposit into the current balance
			updatedBalance = amountToDeposit + startingBalance;
			
			// Return the output variable
			return updatedBalance;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="slot"></param>
		/// <returns></returns>
		//public Inventory Purchase(string slot)
		//{
			//Dictionary<string, Inventory> vendingInventory = new Dictionary<string, Inventory>();

			//if(vendingInventory.ContainsKey())

			// Need updated balance
			//call in balance property


			// Need price for slot entered

			// Call list to see if there is inventory on slot
			// Check that enough money was entered
			// If yes for both, update the balance. Report that vend was successful and the new balance
			// If no, do not update balance. Report that vent was unsuccessful and the new (same) balance
		//}

		/// <summary>
		/// returns change
		/// </summary>
		/// <returns></returns>
		public Change ReturnChange()
		{
			
			Change change = new Change(Balance);
			return change;
		}
		


	}
}
