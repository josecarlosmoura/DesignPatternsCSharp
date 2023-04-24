using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise.TextFormats
{
	public class Csv : IProcessFormat
	{
		private IProcessFormat NextProcess { get; set; }

		public Csv(IProcessFormat processFormat)
		{
			this.NextProcess = processFormat;
		}

		public string Process(Format format, BankAccount bankAccount)
		{
			if (format == Format.CSV)
			{
				string ret = ";";

				foreach (var prop in bankAccount.GetType().GetProperties())
				{
					ret += string.Concat(prop.Name, ";");
				}

				return ret == null ? string.Empty : ret;
			}

			return NextProcess.Process(format, bankAccount);
		}
	}
}
