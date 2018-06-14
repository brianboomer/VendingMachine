using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Capstone.Classes;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
		
			MainMenu();

			void MainMenu()
			{
				Console.Clear();
				Console.WriteLine("VendoMatic 5000");
					
				Console.WriteLine();

				bool mainMenuBool = true;
				while (mainMenuBool)
				{
					Console.WriteLine("please select an option: ");
					Console.WriteLine("1. Display vending machine items");
					Console.WriteLine("2. make a purchese");
					Console.WriteLine("3. Quit");
					int menuChoice = int.Parse(Console.ReadLine());

					//when one option is selected clear the menu option and bring up the next menu
					switch (menuChoice)
					{
						case 1: //show whats in the vending machine(METHOD)
							Dictionary<string, List<Item>> vendingInventory = Inventory.InitalizeInventory();

							DisplayInventory(vendingInventory);
							
							break;

						case 2: // bring up a new menu with (feed money, select product, finish trans)(METHOD)
							DisplayPurchaseMenu();
							break;

						case 3: //figure out why it keeps jumping to the last called menu
							mainMenuBool = false;
							break;

					}
				}
			}


			void DisplayInventory(Dictionary<string, List<Item>> itemsToDisplay)
			{
				bool displayInventoryBool = true;
				while (displayInventoryBool)
				{
					Console.Clear();
					Console.WriteLine("Slot".PadRight(20) + "Name".PadRight(20) + "Quantity".PadRight(20) + "Price");
					Console.WriteLine("-----------------------------------------------------------------------------");
					foreach (var item in itemsToDisplay)
					{
						Console.WriteLine(item.Key.PadRight(20) + item.Value[0].Name.PadRight(20) + item.Value.Count().ToString().PadRight(20) + item.Value[0].Price.ToString("C2"));

					}
					Console.WriteLine();
					Console.Write("Press a key to return to the Main Menu: ");
					Console.ReadKey();
					MainMenu();
				}

			}

			void DisplayPurchaseMenu()
			{
				var test = new VendingMachine();
				while (true)
				{
					Console.Clear();
					Console.WriteLine(" 1. Insert Money");
					Console.WriteLine(" 2. select a goodie");
					Console.WriteLine(" 3. Finish Transaction");
					Console.WriteLine(" 4. return to main menu");
					Console.WriteLine();
					Console.WriteLine($"Current balance: {test.Balance.ToString("C2")}");

					int menuChoice = int.Parse(Console.ReadLine());

					//switch method for the purchese menu

					switch (menuChoice)
					{
						case 1: //feed money
							//balance keeps getting reset the when nw money is added (fixed) 
							Console.Clear();
							Console.WriteLine("How much would you like to insert?");
							int money = int.Parse(Console.ReadLine());
							test.Balance += test.Deposit(money, 0);
							break;

						case 2: //select an Item
							Console.Clear();

							//display the list of items....just wanted to use the dispay inventory method again but it has teh console.readkey and isnt working properly
							Dictionary<string, List<Item>> vendingInventory = Inventory.InitalizeInventory();
							DisplayInventory(vendingInventory);

							Console.WriteLine("Select your goodie");
							string selectedSlot = Console.ReadLine().ToUpper();
							break;

						case 3: //finish transaction
							//not showing the amount of money total returned (fixed)
							//display total change that is returned
							Change chingChing = test.ReturnChange();
							Console.WriteLine($"Your change is {chingChing.TotalChange.ToString("C2")}");
							//quarters returned
							Console.WriteLine($"Total Quarters given: {chingChing.Quarters}");
							//dimes returned
							Console.WriteLine($"Total Dimes given: {chingChing.Dimes}");
							//nickels returned
							Console.WriteLine($"Total Nickles given: {chingChing.Nickels}");
							Console.ReadKey();

							break;

						case 4: //return to menu 
							break;





					}
				



				}

			}


		}
	
	}
}
