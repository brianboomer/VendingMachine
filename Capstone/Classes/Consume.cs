using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;
using System.IO;

namespace Capstone
{
	public class Consume
	{
		//properites

		public string ItemType { get; }

		//constructor

		public Consume(string itemType)
		{
			this.ItemType = itemType;
		}
		
		public void SoundMunch(string itemType)
		{
			string soundEffect = "";

			if (itemType == "Chip")
			{
				soundEffect = "Crunch Crunch, Yum!";
			}
			else if (itemType == "Candy")
			{
				soundEffect = "Munch Munch, Yum!";
			}
			else if (itemType == "Drink")
			{
				soundEffect = "Glug Glug, Yum!";
			}
			else if (itemType == "Gum")
			{
				soundEffect = "Chew Chew, Yum!";
			}

			Console.WriteLine(soundEffect); 

		}

	}
}
