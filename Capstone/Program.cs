using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Capstone.Classes;

namespace Capstone
{
    class Program
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
		}
	}
}
