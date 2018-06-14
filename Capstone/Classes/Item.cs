using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class Item
	{
		// Properties of an item
		public string Slot { get; set; }
		public string Name { get; }
		public decimal Price { get; }
		public string Type { get; }

		// Constructor
		public Item (string[] currentItem)
		{
			this.Slot = currentItem[0];
			this.Name = currentItem[1];
			this.Price = decimal.Parse(currentItem[2]);
			this.Type = currentItem[3];
		}
	}
}
