using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
		/// <param></param>
		/// <returns></returns>
		public decimal Purchase()
		{
			Console.WriteLine("Select your goodie");
			string selectedSlot = Console.ReadLine().ToUpper();

			//Dictionary<string, List<Item>> purchaseInventory = Inventory.ItemsInventory;
			try
			{
				if (Inventory.ItemsInventory.ContainsKey(selectedSlot) && Balance >= Inventory.ItemsInventory[selectedSlot][0].Price)
				{
					var item = Inventory.ItemsInventory[selectedSlot][0];
					Balance -= item.Price;
					Inventory.ItemsInventory[selectedSlot].RemoveAt(0);

				}
				else
				{
					Console.WriteLine("you dont have enough money");
					Console.ReadKey();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("This Item Is Sold Out!!");
				//Inventory.ItemsInventory[selectedSlot][0].Name = "Sold out";
				//Inventory.ItemsInventory[selectedSlot][0].Price = 0;
				//Inventory.ItemsInventory[selectedSlot][0].Slot = "Sold out";
				//Inventory.ItemsInventory[selectedSlot][0].Type = "Sold out";
				Console.ReadKey();
			}
			return Balance;
		}


		//Need updated balance
		//  call in balance property


		//Need price for slot entered

		//Call list to see if there is inventory on slot
		//Check that enough money was entered
		//If yes for both, update the balance.Report that vend was successful and the new balance
		//If no, do not update balance.Report that vent was unsuccessful and the new(same) balance


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
