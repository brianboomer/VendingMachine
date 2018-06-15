using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
	public class AuditLog
	{
		//public string File { get; set; }
		public string Action { get; set; }
		public decimal Before { get; set; }
		public decimal After { get; set; }

		public AuditLog(string action, decimal before, decimal after)
		{
			//this.File = file;
			this.Action = action;
			this.Before = before;
			this.After = after;
		}

		public void WriteToLog()
		{
			{
				string auditLog = Path.Combine(Environment.CurrentDirectory, "AuditLog.txt");
				try
				{
					using (StreamWriter sw = new StreamWriter(auditLog, true))
					{
						//sw.WriteLine("Date & Time".PadRight(30) + "Action".PadRight(20) + "Balance Before".PadRight(20) + "Balance After".PadRight(20));
						sw.WriteLine($"{DateTime.UtcNow.ToLocalTime().ToString().PadRight(30)}{Action.PadRight(20)}{Before.ToString("C2").PadRight(20)}{After.ToString("C2").PadRight(20)}");
					}
				}
				catch (IOException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
