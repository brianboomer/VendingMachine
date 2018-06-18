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
		public string Action { get; set; }
		public decimal Before { get; set; }
		public decimal After { get; set; }


		// METHODS
		public decimal Deposit(decimal amountToDeposit, decimal startingBalance)
		{
			// Declare the output variable
			decimal updatedBalance = startingBalance;
			this.Before = startingBalance;

			// Add the amount to deposit into the current balance
			updatedBalance = amountToDeposit + startingBalance;

			// Set Audit Log Properties
			this.Action = "DEPOSIT";
			this.After = updatedBalance;

			// Run Audit Log
			AuditLog createNewAuditLine = new AuditLog(Action, Before, After);
			createNewAuditLine.WriteToLog();

			// Return the output variable
			return updatedBalance;
		}

		/// <summary>
		/// method for purchasing an item
		/// </summary>
		/// <param></param>
		/// <returns></returns>
		public decimal Purchase()
		{
			Console.WriteLine("Select your goodie");
			string selectedSlot = Console.ReadLine().ToUpper();

			
			try
			{
				if (Inventory.ItemsInventory.ContainsKey(selectedSlot) && Balance >= Inventory.ItemsInventory[selectedSlot][0].Price)
				{
					var item = Inventory.ItemsInventory[selectedSlot][0];
					Before = Balance;
					Balance -= item.Price;
					After = Balance;
					Action = $"{Inventory.ItemsInventory[selectedSlot][0].Name} {Inventory.ItemsInventory[selectedSlot][0].Slot}";

					// Run Audit Log
					AuditLog createNewAuditLine = new AuditLog(Action, Before, After);
					createNewAuditLine.WriteToLog();

					Inventory.ItemsInventory[selectedSlot].RemoveAt(0);

					Consume sound = new Consume(item.Type);
					sound.SoundMunch(item.Type);
					Console.ReadKey();
				}
				else if (Inventory.ItemsInventory.ContainsKey(selectedSlot) && Balance < Inventory.ItemsInventory[selectedSlot][0].Price)
				{
					Console.WriteLine("you dont have enough money");
					Console.ReadKey();
				}
				else if (!Inventory.ItemsInventory.ContainsKey(selectedSlot))
				{
					Console.WriteLine("Slot does not exist");
					Console.ReadKey();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("This Item Is Sold Out!!");

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
