using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise.TextFormats
{
	public class Percent : IProcessFormat
	{
		private IProcessFormat NextProcess { get; set; }

		public Percent(IProcessFormat processFormat) 
		{
			this.NextProcess = processFormat;
		}

		public string Process(Format format, BankAccount bankAccount)
		{
			if (format == Format.PERCENT)
			{
				string ret = "%";

				foreach (var prop in bankAccount.GetType().GetProperties()) 
				{
					ret += string.Concat(prop.Name, "%");	
				}
				
				return ret == null ? string.Empty : ret;
			}

			return NextProcess.Process(format, bankAccount);
		}
	}
}
