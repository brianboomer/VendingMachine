using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Classes
{   /// <summary>
//	/// HVending MEnus handles the VM UI
//	/// </summary>
//	public class VendingMenus
//	{
//		private VendingMachine VM;

//		public VendingMenus(VendingMachine vm)
//		{
//			this.VM = vm;
//		}

//		public void MainMenu()
//		{
//			//varibles


//			//user interface 
//			Console.Clear();
//			Console.WriteLine("VendoMatic 5000");
//			Console.WriteLine();
//			while (true)
//			{
//				Console.WriteLine("please select an option: ");
//				Console.WriteLine("1. Display vending machine items");
//				Console.WriteLine("2. make a purchese");
//				Console.WriteLine("Q. Quit");
//				var menuChoice = Console.ReadLine().ToLower();

//				//when one option is selected clear the menu option and bring up the next menu
//				switch (menuChoice)
//				{
//					//case 1:
//						//clear main menu
//						Console.Clear();

//						//show whats in the vending machine(METHOD)
//						//DisplayInventory();

//						break;

//					//case 2:
//						//clear out the main menu
//						Console.Clear();

//						//pring up a new menu with (feed money, select product, finish trans)(METHOD)
//						//DisplayPurcheseMenu();
//						break;

//				}
//			}




//		}
//		private void DisplayPurcheseMenu()
//		{
//			while (true)
//			{
//				Console.WriteLine(" 1. Insert Money");
//				Console.WriteLine(" 2. select a goodie");
//				Console.WriteLine(" 3. Finish Transaction");
//				Console.WriteLine(" 4. return to main menu");
//				Console.WriteLine();
//				Console.WriteLine($"Current balance: {VM.Balance}")
//			}



//		}
//	}
}	
