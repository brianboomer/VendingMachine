﻿using System;
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
			
			// Read in the text file that contains the information about the inventory
			string path = Path.Combine(Environment.CurrentDirectory, "Inventory.txt");

			// Create a dictionary of items
			Dictionary<string, List<Item>> itemsInventory = new Dictionary<string, List<Item>>();

			try
			{
				using (StreamReader sr = new StreamReader(path))
				while (!sr.EndOfStream)
					{
						string currentLine = sr.ReadLine();
						string[] currentItemArray = currentLine.Split('|');

						Item currentItem = new Item(currentItemArray);

						List<Item> stockOfCurrentItem = new List<Item>();

						// There are 5 of each item, by default
						for (int i = 0; i < 5; i++)
						{
							stockOfCurrentItem.Add(currentItem);
						}

						itemsInventory.Add(currentItemArray[0], stockOfCurrentItem);
					}
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
			}

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
							DisplayInventory(itemsInventory);
							break;

						case 2: // bring up a new menu with (feed money, select product, finish trans)(METHOD)
							DisplayPurchaseMenu();
							break;

						case 3:
							mainMenuBool = false;
							break;

					}
				}
			}
			

			void DisplayInventory(Dictionary<string,List<Item>> itemsToDisplay)
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
				while (true)
				{
					Console.Clear();
					Console.WriteLine(" 1. Insert Money");
					Console.WriteLine(" 2. select a goodie");
					Console.WriteLine(" 3. Finish Transaction");
					Console.WriteLine(" 4. return to main menu");
					Console.WriteLine();
					Console.WriteLine($"Current balance: TODO Balance");
					Console.ReadKey();
				}

			}


		}

		
	}
}
