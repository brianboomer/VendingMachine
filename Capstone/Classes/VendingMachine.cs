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
		public VendingMachine (decimal balance, decimal amountToDeposit)
		{
			this.Balance = balance;
			this.AmountToDeposit = amountToDeposit;
		}

		// PROPERTIES
		decimal Balance { get; set; }
		decimal AmountToDeposit { get; set; }


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

		public decimal Purchase(string slot)
		{
			// Need updated balance
			// Need price for slot entered
			
			// Call list to see if there is inventory on slot
			// Check that enough money was entered
				// If yes for both, update the balance. Report that vend was successful and the new balance
				// If no, do not update balance. Report that vent was unsuccessful and the new (same) balance
		}


	}
}
